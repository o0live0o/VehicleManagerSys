using HZH_Controls;
using HZH_Controls.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;
using VehicleManagerSys.Entity.IVS;

namespace VehicleManagerSys.Manual
{
    public partial class RoadTestForm : FrmWithTitle
    {
        private VEHICLE_DISPATCH _DISPATCH = null;
        public RoadTestForm(VEHICLE_DISPATCH dispatch)
        {
            InitializeComponent();
            this._DISPATCH = dispatch;
            Init();
        }

        private void Init()
        {
            try
            {
               
                if (_DISPATCH != null)
                {
                    this.Title = this._DISPATCH.HPHM;
                    labNetNo.Text = this._DISPATCH.AJLSH ?? "";
                }
                else
                {
                    FrmTips.ShowTips(this, "基本信息错误", 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                }

               var users =   AppCache.GetUsers(p => !p.EMPLOYEE_ID.Contains("admin") && !string.IsNullOrEmpty(p.EMPLOYEE_NAME ) && !string.IsNullOrEmpty(p.EMPLOYEE_ID_NO)).ToList();
                List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                foreach (var item in users)
                {
                    list.Add(new KeyValuePair<string, string>(item.EMPLOYEE_ID_NO,item.EMPLOYEE_NAME));
                }
                combUsers.Source = list;
            }
            catch (Exception ex)
            {
                FrmTips.ShowTips(this, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
            }
        }

        //18C55
        private void StartTest()
        {
            try
            {
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara>" +
                    $"<jylsh>{_DISPATCH.AJLSH}</jylsh><jyjgbh>1100000050</jyjgbh><jcxdh>1</jcxdh><jycs>{_DISPATCH.AJJCCS}</jycs>" +
                    $"<hpzl>{_DISPATCH.HPZLDH}</hpzl><hphm>{_DISPATCH.HPHM}</hphm><clsbdh>{_DISPATCH.VIN}</clsbdh><gwjysbbh></gwjysbbh>" +
                    $"<jyxm>R</jyxm><kssj>{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}</kssj></vehispara></root>";
                WebSend.Send("18C55", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }

        //18C58
        private void EndTest()
        {
            try
            {
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara><jylsh>{_DISPATCH.AJLSH}</jylsh>" +
                    $"<jyjgbh>1100000050</jyjgbh><jcxdh>1</jcxdh><jyxm>R</jyxm><jycs>{_DISPATCH.AJJCCS}</jycs><hpzl>{_DISPATCH.HPZLDH}</hpzl>" +
                    $"<hphm>{_DISPATCH.HPHM}</hphm><clsbdh>{_DISPATCH.VIN}</clsbdh><gwjysbbh></gwjysbbh>" +
                    $"<jssj>{DateTime.Now.ToString("yyyy-MM-dd HH: mm: ss")}</jssj></vehispara></root>";
                WebSend.Send("18C58", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }

        //18C54
        private void SendResult()
        {
            try
            {
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara><dpdtjyy>{combUsers.SelectedText}</dpdtjyy>" +
                    $"<dpdtjyysfzh>{combUsers.SelectedValue}</dpdtjyysfzh><jyyjy></jyyjy><rcdx>1</rcdx><rybzsq>1</rybzsq>" +
                    $"<rzdx>1</rzdx><rzxx>1</rzxx><jylsh>{_DISPATCH.AJLSH}</jylsh><jyjgbh>1100000050</jyjgbh>" +
                    $"<jcxdh>1</jcxdh><hphm>{_DISPATCH.HPHM}</hphm><hpzl>{_DISPATCH.HPZLDH}</hpzl><clsbdh>{_DISPATCH.VIN}</clsbdh>" +
                    $"<jycs>1</jycs><jyxm>DC</jyxm></vehispara></root>";
                WebSend.Send("18c54", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }

        private void Capture(string zpzl)
        {
            try
            {
                //0344 0342
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara><jylsh>{_DISPATCH.AJLSH}</jylsh><jcxdh>1</jcxdh>" +
                    $"<hphm>{_DISPATCH.HPHM}</hphm><hpzl>{_DISPATCH.HPZLDH}</hpzl><clsbdh>{_DISPATCH.VIN}</clsbdh>" +
                    $"<gwjysbbh>2</gwjysbbh><jyxm>R</jyxm><kssj>{DateTime.Now.ToString("yyyy-MM-dd HH: mm: ss")}</kssj><zpzl>{zpzl}</zpzl></vehispara></root>";
                WebSend.Send("18J31", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }

        private void VideoStart()
        {
            try
            {
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara><jylsh>{_DISPATCH.AJLSH}</jylsh><hphm>{_DISPATCH.HPHM}</hphm>" +
                    $"<hpzl>{_DISPATCH.HPZLDH}</hpzl><clsbdh>{_DISPATCH.VIN}</clsbdh><gwxm>DC</gwxm><jcxdh>1</jcxdh><lx>1</lx></vehispara></root>";
                WebSend.Send("18J11", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }

        private void VideoEnd()
        {
            try
            {
                string xml = $"<?xml version=\"1.0\" encoding=\"GBK\"?><root><vehispara><jylsh>{_DISPATCH.AJLSH}</jylsh><hphm>{_DISPATCH.HPHM}</hphm>" +
                    $"<hpzl>{_DISPATCH.HPZLDH}</hpzl><clsbdh>{_DISPATCH.VIN}</clsbdh><gwxm>R</gwxm><jcxdh>1</jcxdh><lx>1</lx></vehispara></root>";
                WebSend.Send("18J12", xml);
            }
            catch (Exception ex)
            {
                ControlHelper.ThreadInvokerControl(this, () =>
                {
                    FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                });
            }
        }



        

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadingForm frmLoading = new LoadingForm("开始检测...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "发送录像开始指令...");
                    VideoStart();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(60, "开始检测...");
                    StartTest();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(90, "拍照...");
                    Capture("0341");
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "开始检测");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("开始检测异常：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            LoadingForm frmLoading = new LoadingForm("正在结束...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "拍照...");
                    Capture("0343");
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "保存数据...");
                    SendResult();     
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(60, "发送结束指令...");
                    EndTest();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(80, "发送录像结束指令...");
                    VideoEnd();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "检测完成！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("结束异常：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();
        }

        private void btnStartPark_Click(object sender, EventArgs e)
        {
            LoadingForm frmLoading = new LoadingForm("开始检测...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "发送录像开始指令...");
                    VideoStart();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(60, "开始检测...");
                    StartTest();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(90, "拍照...");
                    Capture("0345");
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "开始检测");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("开始检测异常：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();
        }

        private void btnEndPark_Click(object sender, EventArgs e)
        {
            LoadingForm frmLoading = new LoadingForm("正在结束...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "保存数据...");
                    SendResult();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(60, "发送结束指令...");
                    EndTest();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(80, "发送录像结束指令...");
                    VideoEnd();
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "检测完成！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("结束异常：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();
        }
    }
}
