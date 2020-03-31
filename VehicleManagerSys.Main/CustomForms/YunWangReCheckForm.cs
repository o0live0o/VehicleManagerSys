using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live0xUtils.DbUtils.SqlServer;
using System.Collections;
using CI.UIComponents.Helper;
using VehicleManagerSys.Common;
using HZH_Controls;
using VehicleManagerSys.Entity.IVS;
using Newtonsoft.Json;
using VehicleManagerSys.Dtos;
using System.Net;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class YunWangReCheckForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();

        public YunWangReCheckForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<RESULT_VEHICLE_INFO> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT TOP 20 * FROM RESULT_VEHICLE_INFO WHERE 1 =1  ";

                    if (!string.IsNullOrEmpty(txtSeachPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("HPHM", "%" + txtSeachPlateNo.Text.Trim() + "%");
                        sql += " AND HPHM like @HPHM";
                    }
                    sql += " ORDER BY ID DESC";
                    list = _mssqlHelper.QueryList<RESULT_VEHICLE_INFO>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<RESULT_VEHICLE_INFO>(dgv, list);
                        }
                    });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(this, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }

            }, null, AppHelper.MainForm, true, "正在查询……", 200);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;
            //RESULT_VEHICLE_INFO info = CGridHelper.GetCurrentData<RESULT_VEHICLE_INFO>(dgv);
            //if(info != null)
            //{
            //    ((MainForm)AppHelper.MainForm).AddForm(new ComprehensiveUploadForm(info));
            //}
            ReCheck();
        }

        private void btnReCheck_Click(object sender, EventArgs e)
        {
            ReCheck();
        }

        private void ReCheck()
        {
            VEHICLE_DISPATCH dispatchInfo = new VEHICLE_DISPATCH();
            if (dgv.CurrentRow.Index < 0) return;
            RESULT_VEHICLE_INFO info = CGridHelper.GetCurrentData<RESULT_VEHICLE_INFO>(dgv);
            if (info != null)
            {
                AppMessage message = new AppMessage() { Succ = false, Msg = "程序异常" };
                YunWangReCheckOptForm optForm = new YunWangReCheckOptForm(info.HPHM, info.PFLSH);
                DialogResult dialogResult = optForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("JYLSH", info.PFLSH);
                        hashtable.Add("JGBH", AppHelper.EnvironmentNetSetting.StationNo);
                        hashtable.Add("SFWGJC", optForm.IsCheckAppearance ? 1 : 0);
                        string writejson = JsonConvert.SerializeObject(hashtable);

                        WebClient webClient = new WebClient();
                        string uploadUrl = (AppHelper.EnvironmentNetSetting.Url.EndsWith("/") ? AppHelper.EnvironmentNetSetting.Url : AppHelper.EnvironmentNetSetting.Url + "/") + "write/";
                        var result = webClient.UploadValues(uploadUrl, new System.Collections.Specialized.NameValueCollection() {
                   { "jkid","HWFDL"},
                   { "jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber},
                   { "writejson", writejson},
                });
                        string s = Encoding.UTF8.GetString(result);
                        LogHelper.Trace("[复检申请]:"+s);
                        //hashtable.Clear();
                        //hashtable.Add("jkid", "HWFDL");
                        //hashtable.Add("jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber);
                        //hashtable.Add("writejson", writejson);
                        //Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
                        //string str = httpRequest.HttpPost(AppHelper.EnvironmentNetSetting.Url, JsonConvert.SerializeObject(hashtable));

                        hashtable.Clear();
                        hashtable = JsonConvert.DeserializeObject<Hashtable>(s);
                        message.Msg = hashtable["msg"] == null ? "" : hashtable["msg"].ToString();
                        message.Succ = hashtable["code"] == null ? false :
                            (hashtable["code"].ToString().Equals("success") ? true : false);
                        if (message.Succ)
                        {
                            Hashtable data = new Hashtable();
                            data = JsonConvert.DeserializeObject<Hashtable>(hashtable["data"].ToString());
                            message.NetTestNo = data["JYLSH"].ToString();
                            message.Times = data["JYCS"].ToString();
                            message.DetectItem = data["JCFFDM"].ToString();
                            message.DetectItem = AppHelper.GetLocalType("JYXM", message.DetectItem);
                            StartProcess(message.NetTestNo, message.Times);
                        }

                        if (message.Succ)
                        {
                            Hashtable queryTable = new Hashtable();
                            string sql = "SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM = @HPHM AND VIN = @VIN";
                            queryTable.Add("HPHM", info.HPHM);
                            queryTable.Add("VIN", info.VIN);
                            LOGIN_VEHICLE_INFO loginInfo = _mssqlHelper.Query<LOGIN_VEHICLE_INFO>(sql, queryTable);


                            foreach (var loginProperty in loginInfo.GetType().GetProperties())
                            {
                                foreach (var dispatchProperty in dispatchInfo.GetType().GetProperties())
                                {
                                    if (loginProperty.Name.Equals(dispatchProperty.Name))
                                    {
                                        dispatchProperty.SetValue(dispatchInfo, loginProperty.GetValue(loginInfo, null), null);
                                    }
                                }
                            }

                            dispatchInfo.JCZT_STATUS = "0";
                            dispatchInfo.YJXM = "";
                            dispatchInfo.FJXM = "";
                            dispatchInfo.PFLSH = message.NetTestNo;
                            dispatchInfo.JCCS = message.Times;
                            dispatchInfo.JYXM = message.DetectItem + ",";
                            dispatchInfo.JCLSH = "P" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                            //string[] carIgnoreArr = (from p in dispatchInfo.GetType().GetProperties()
                            //                where p.GetValue(dispatchInfo, null) == null || string.IsNullOrEmpty(p.GetValue(dispatchInfo, null).ToString())
                            //                select p.Name).ToArray();

                            bool succ = _mssqlHelper.InsertOrUpdate(dispatchInfo, null, new string[] { "HPHM", "VIN" }, new string[] { "ID", "JCZL", "LTGG", "ZJLWZT", "SFJMPZ", "OBDJYY", "WQYCY", "OBDCommCL", "OBDCommCX", "Standard", "VehicleKind", "IsEFI", "IsAsm", "OBDOutlookID", "OutlookID", "GGMINNMD", "GGMAXNMD" });
                            if (succ)
                                FrmTips.ShowTipsSuccess(AppHelper.MainForm, "报检成功！检验项目:" + message.DetectItem, ContentAlignment.MiddleCenter, 3000);
                            else
                                FrmTips.ShowTipsError(AppHelper.MainForm, "报检失败！" + message.Msg, ContentAlignment.MiddleCenter, 3000);
                        }
                        else
                            FrmTips.ShowTips(AppHelper.MainForm, message.Msg, 3000, true, System.Drawing.ContentAlignment.MiddleCenter, null, TipsSizeMode.None, new System.Drawing.Size(400, 200));
                        //FrmTips.ShowTipsError(AppHelper.MainForm, "报检失败！" + message.Msg, ContentAlignment.MiddleCenter, 3000);
                    }
                    catch (Exception ex)
                    {
                        message.Msg = ex.Message;
                        FrmTips.ShowTipsError(AppHelper.MainForm, "报检异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
                    }
                }
            }
        }


        private void StartProcess(string testNo, string testTimes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("JYLSH", testNo);
            dic.Add("JYCS", testTimes);
            dic.Add("JGBH", AppHelper.EnvironmentNetSetting.StationNo);
            dic.Add("JCXBH", AppHelper.EnvironmentNetSetting.LineNo);
            dic.Add("TIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


            WebClient webClient = new WebClient();
            string uploadUrl = (AppHelper.EnvironmentNetSetting.Url.EndsWith("/") ? AppHelper.EnvironmentNetSetting.Url : AppHelper.EnvironmentNetSetting.Url + "/") + "write/";
            var result = webClient.UploadValues(uploadUrl, new System.Collections.Specialized.NameValueCollection() {
                   { "jkid","HWGCKS"},
                   { "jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber},
                   { "writejson", JsonConvert.SerializeObject(dic)},
                });
            string s = Encoding.UTF8.GetString(result);
            LogHelper.Trace("[复检开始]:" + s);
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("jkid", "HWGCKS");
            //hashtable.Add("jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber);
            //hashtable.Add("writejson", JsonConvert.SerializeObject(dic));
            //Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
            //string s = httpRequest.HttpPost("url", JsonConvert.SerializeObject(hashtable));

            AppMessage message = new AppMessage() { Succ = false, Msg = "程序异常" };
            Hashtable hashtable = new Hashtable();
            hashtable = JsonConvert.DeserializeObject<Hashtable>(s);
            message.Msg = hashtable["msg"] == null ? "" : hashtable["msg"].ToString();
            message.Succ = hashtable["code"] == null ? false :
                (hashtable["code"].ToString().Equals("success") ? true : false);

            FrmTips.ShowTips(AppHelper.MainForm, message.Msg, 2000, true, System.Drawing.ContentAlignment.BottomRight, null, TipsSizeMode.None, new System.Drawing.Size(300, 100));
        }
    }
}
