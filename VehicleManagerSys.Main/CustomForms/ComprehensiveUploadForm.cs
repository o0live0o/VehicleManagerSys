using CI.UIComponents.Helper;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;
using VehicleManagerSys.Core.Services;
using VehicleManagerSys.Dtos.IVS;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ComprehensiveUploadForm : FrmWithTitle
    {
        private RESULT_VEHICLE_INFO m_RESULT_VEHICLE_INFO = null;

        private ComprehensiveUploadService _comprehensiveUploadService;

        public ComprehensiveUploadForm(RESULT_VEHICLE_INFO info)
        {
            InitializeComponent();
            m_RESULT_VEHICLE_INFO = CloneHelper.Clone(info) as RESULT_VEHICLE_INFO;
        }

        private void InitData()
        {
            _comprehensiveUploadService = new ComprehensiveUploadService(m_RESULT_VEHICLE_INFO);
            _comprehensiveUploadService.InitData(new ComprehensiveUploadService.LogDelegate(AddLog));

            if (AppHelper.ComprehensiveSetting.Operators.Length > 0)
            {
                combAuthor.DataSource = AppHelper.ComprehensiveSetting.Operators;
            }
        }

        private void UploadReport()
        {
            _comprehensiveUploadService.ShareDetectInfo(new ComprehensiveUploadService.LogDelegate(AddLog),chkTrust.Checked);
        }

        private void AddLog(string msg)
        {
            AddLog(msg, Color.Black);
        }

        private void AddLog(string msg,Color color)
        {
            lock (AppHelper.AppLocker)
            {
                txtUploadLog.Invoke(new MethodInvoker(() =>
                {
                    msg = $"[{DateTime.Now}] {msg}\r\n";
                    txtUploadLog.SelectionColor = color;
                    txtUploadLog.AppendText(msg);
                    txtUploadLog.SelectionColor = Color.Black;
                    txtUploadLog.ScrollToCaret();
                }));
            }
        }

        private void ComprehensiveUploadForm_Shown(object sender, EventArgs e)
        {         
            LoadingForm frmLoading = new LoadingForm();
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    Thread.Sleep(500);
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(1, "正在初始化配置...");

                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "初始化UI...");
                    this.Invoke(new MethodInvoker(() => {
                        this.Title = m_RESULT_VEHICLE_INFO.HPHM;
                        this.labTestNo.Text = m_RESULT_VEHICLE_INFO.JCLSH;
                        this.labTestNoNet.Text = m_RESULT_VEHICLE_INFO.ZJLSH;
                        captureEloam1.InitImgType(AppHelper.ComprehensiveSetting.ImgList);
                        captureEloam1.InitCapturePath(Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, m_RESULT_VEHICLE_INFO.HPHM));
                    }));
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(20, "加载数据...");
                    this.Invoke(new MethodInvoker(() => {
                        InitData();
                    }));
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(1000, "初始化完成...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载资源时出现错误");
                }
            };
            frmLoading.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string author = combAuthor.Text;

            AddLog($"签字人：【{author}】");

            if (string.IsNullOrEmpty(author))
            {
                FrmTips.ShowTips(AppHelper.MainForm, "请选择签字人名字", 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 50), TipsState.Error);
                return;
            }

            LoadingForm frmLoading = new LoadingForm("正在上传...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {                
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(1, "正在上传...");
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "获取Token...");
                    _comprehensiveUploadService.GetToken(new ComprehensiveUploadService.LogDelegate(AddLog));
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(20, "获取流水...");
                    _comprehensiveUploadService.ShareVehicleInfo(new ComprehensiveUploadService.LogDelegate(AddLog));
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "上传报告单数据...");
                    UploadReport();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(40, "上传工位照片...");
                    _comprehensiveUploadService.SharePrintImage(new ComprehensiveUploadService.LogDelegate(AddLog),chkTrust.Checked);
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(60, "上传安检结论照片...");
                    _comprehensiveUploadService.ShareReportImage(new ComprehensiveUploadService.LogDelegate(AddLog));
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(80, "上传签字人信息...");
                    _comprehensiveUploadService.ShareSignatureImage(new ComprehensiveUploadService.LogDelegate(AddLog),author);
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(1000, "上传完成...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("上传数据时出现错误：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();
        }

        private void ComprehensiveUploadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                captureEloam1.DisposeContorl();
            }
            catch
            {
                throw;
            }
        }
    }
}
