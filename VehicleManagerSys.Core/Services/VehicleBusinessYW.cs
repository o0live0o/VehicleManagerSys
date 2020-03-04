using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common;
using VehicleManagerSys.Core.Interfaces;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Dtos.YunWangDtos;

namespace VehicleManagerSys.Core.Services
{
    public class VehicleBusinessYW : IVehicleBusiness
    {
        public AppMessage SaveCar(VehicleInfo info)
        {
            throw new NotImplementedException();
        }

        public AppMessage SearchCar(VehicleInfo info)
        {
            AppMessage appMessage = new AppMessage() { Succ = false, Msg = "没有查询到相关信息！" };
            try
            {

            }
            catch (Exception ex)
            {
                appMessage.Succ = false;
                appMessage.Msg = ex.Message;
            }
            return appMessage;
        }

        public AppMessage SendCar(VehicleInfo info)
        {
            AppMessage message = new AppMessage() { Succ = false, Msg = "程序异常" };
            try
            {
                HWDL hwdl = new HWDL();
                AppTools.FillEntiyByAttr(info, hwdl);
                hwdl.JGBH = AppHelper.EnvironmentNetSetting.StationNo;
                //TODO 特殊处理
                hwdl.DLY = AppHelper.UserInfo.UserName;
                hwdl.DLSJ = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                //if (info.DetectItem.Contains("X1"))
                //{
                //    hwdl.λup = "1.05";
                //    hwdl.λdown = "0.95";
                //}

                //    Hashtable hashtable = new Hashtable();
                //    hashtable.Add("jkid","HWDL");
                //    hashtable.Add("jkxlh",AppHelper.EnvironmentNetSetting.SerialNumber);
                //    hashtable.Add("writejson", JsonConvert.SerializeObject(hwdl)) ;
                //    Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
                ///*    string s = "{\"code\":\"success\",\"msg\":\"登录成功\",\"data\":{\"JYLSH\":\"YW1234567890\",\"JYCS\":2,\"JCFFDM\":\"2\"},\"success\":true,\"totalCount\":1}";*/
                //   string  s = httpRequest.HttpPost("url", JsonConvert.SerializeObject(hashtable));
                string content = JsonConvert.SerializeObject(hwdl);
                LogHelper.Trace("[发送]：" + content);
                WebClient webClient = new WebClient();
                string uploadUrl = (AppHelper.EnvironmentNetSetting.Url.EndsWith("/") ? AppHelper.EnvironmentNetSetting.Url : AppHelper.EnvironmentNetSetting.Url + "/") + "write/";
                var result = webClient.UploadValues(uploadUrl, new System.Collections.Specialized.NameValueCollection() {
                   { "jkid","HWDL"},
                   { "jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber},
                   { "writejson", content},
                });
                string s = Encoding.UTF8.GetString(result);
                LogHelper.Trace("[接收]："+s);
                Hashtable hashtable = new Hashtable();
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
            }
            catch (Exception ex)
            {
                message.Msg = ex.Message;
            }
            return message;
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
