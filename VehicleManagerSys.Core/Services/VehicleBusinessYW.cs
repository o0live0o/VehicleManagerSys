using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common;
using VehicleManagerSys.Common.Attributes;
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
            AppMessage message = new AppMessage() { Succ = false, Msg = "没有查询到相关信息！" };
            VehicleInfo vehicleInfo = new VehicleInfo();
            try
            {
                var obj = new {
                    License = info.PlateNo,
                    LicenseType = info.PlateColor,
                    VIN = info.VIN
                };

                var content = JsonConvert.SerializeObject(obj);
                LogHelper.Trace("[查询条件]：" + content);

                WebClient webClient = new WebClient();
                string uploadUrl = (AppHelper.EnvironmentNetSetting.Url.EndsWith("/") ? AppHelper.EnvironmentNetSetting.Url : AppHelper.EnvironmentNetSetting.Url + "/") + "Query/";
                var result = webClient.UploadValues(uploadUrl, new System.Collections.Specialized.NameValueCollection() {
                   { "jkid","HQCarInfo"},
                   { "jkxlh", AppHelper.EnvironmentNetSetting.SerialNumber},
                   { "queryjson", content},
                });
                string s = Encoding.UTF8.GetString(result);
                LogHelper.Trace("[接收]：" + s);
                //var s = File.ReadAllText("999.txt");
                Hashtable hashtable = new Hashtable();
                hashtable = JsonConvert.DeserializeObject<Hashtable>(s);
                message.Msg = hashtable["msg"] == null ? "" : hashtable["msg"].ToString();
                message.Succ = hashtable["code"] == null ? false :
                    (hashtable["code"].ToString().Equals("success") ? true : false);
                if (message.Succ)
                {
                    var data = JsonConvert.DeserializeObject<HQCarInfo>(hashtable["data"].ToString());
                    FillEntity(data, vehicleInfo);

                    vehicleInfo.PlateColor = AppHelper.GetLocalType("HPYS",vehicleInfo.PlateColor);
                    vehicleInfo.PlateColorTxt = AppHelper.GetDefineName("HPYS",vehicleInfo.PlateColor);

                    //vehicleInfo.PlateType = AppHelper.GetLocalType("HPZL", vehicleInfo.PlateType);
                    vehicleInfo.PlateTypeTxt = AppHelper.GetDefineName("HPZL", vehicleInfo.PlateType);

                    //vehicleInfo.VehicleType = AppHelper.GetLocalType("CLZL",vehicleInfo.VehicleType);
                    vehicleInfo.VehicleTypeTxt = AppHelper.GetDefineName("CLZL", vehicleInfo.VehicleType);

                    vehicleInfo.UseType = AppHelper.GetLocalType("SYXZ", vehicleInfo.UseType);
                    vehicleInfo.UseTypeTxt = AppHelper.GetDefineName("SYXZ", vehicleInfo.UseType);

                    //vehicleInfo.EmissionStandardTxt = AppHelper.GetDefineName("EmissionStandard", vehicleInfo.EmissionStandard);

                    #region 燃料处理

                    if (!string.IsNullOrEmpty(vehicleInfo.FuelType))
                    {
                        var fuelArr = vehicleInfo.FuelType.ToCharArray();
                        if (fuelArr.Length > 0)
                        {
                            vehicleInfo.FuelType = fuelArr[0].ToString();
                            vehicleInfo.FuelType = AppHelper.GetLocalType("RLLB", vehicleInfo.FuelType);
                            vehicleInfo.FuelTypeTxt = AppHelper.GetDefineName("RLLB", vehicleInfo.FuelType);
                        }

                        if (fuelArr.Length > 1)
                        {
                            vehicleInfo.FuelType2 = fuelArr[1].ToString();
                            vehicleInfo.FuelType2 = AppHelper.GetLocalType("RLLB", vehicleInfo.FuelType2);
                            vehicleInfo.FuelTypeTxt2 = AppHelper.GetDefineName("RLLB", vehicleInfo.FuelType2);
                        }
                    }
                    #endregion

                    vehicleInfo.VehicleStatusTxt = AppHelper.GetDefineName("VehicleStatus",vehicleInfo.VehicleStatus);

                    //vehicleInfo.FuelModelTxt = AppHelper.GetDefineName("FuleModel", vehicleInfo.FuelModel);

                    vehicleInfo.IntakeType = AppHelper.GetLocalType("JQFS",vehicleInfo.IntakeType);
                    vehicleInfo.IntakeTypeTxt = AppHelper.GetDefineName("JQFS",vehicleInfo.IntakeType);

                    if ("Y".Equals(vehicleInfo.EVAPControl) || "是".Equals(vehicleInfo.EVAPControl))
                    {
                        vehicleInfo.EVAPControl = "1";
                        vehicleInfo.EVAPControlTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.EVAPControl);
                    }
                    else if ("N".Equals(vehicleInfo.EVAPControl) || "否".Equals(vehicleInfo.EVAPControl))
                    {
                        vehicleInfo.EVAPControl = "0";
                        vehicleInfo.EVAPControlTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.EVAPControl);
                    }
                    else
                    {
                        vehicleInfo.EVAPControl = "";
                        vehicleInfo.EVAPControlTxt = "";
                    }

                    if ("Y".Equals(vehicleInfo.HasTreatmentDevice) || "是".Equals(vehicleInfo.HasTreatmentDevice))
                    {
                        vehicleInfo.HasTreatmentDevice = "1";
                        vehicleInfo.HasTreatmentDeviceTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.HasTreatmentDevice);
                    }
                    else if ("N".Equals(vehicleInfo.HasTreatmentDevice) || "否".Equals(vehicleInfo.HasTreatmentDevice))
                    {
                        vehicleInfo.HasTreatmentDevice = "0";
                        vehicleInfo.HasTreatmentDeviceTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.HasTreatmentDevice);
                    }
                    else
                    {
                        vehicleInfo.HasTreatmentDevice = "";
                        vehicleInfo.HasTreatmentDeviceTxt = "";
                    }

                    vehicleInfo.TreatmentDeviceType = AppHelper.GetLocalType("HCLZZ", vehicleInfo.TreatmentDeviceType);
                    vehicleInfo.TreatmentDeviceTypeTxt = AppHelper.GetDefineName("HCLZZ", vehicleInfo.TreatmentDeviceType);

                    if ("Y".Equals(vehicleInfo.HasOBD) || "是".Equals(vehicleInfo.HasOBD))
                    {
                        vehicleInfo.HasOBD = "1";
                        vehicleInfo.HasOBDTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.HasOBD);
                    }
                    else if ("N".Equals(vehicleInfo.HasOBD) || "否".Equals(vehicleInfo.HasOBD))
                    {
                        vehicleInfo.HasOBD = "0";
                        vehicleInfo.HasOBDTxt = AppHelper.GetDefineName("SysYesOrNo", vehicleInfo.HasOBD);
                    }
                    else
                    {
                        vehicleInfo.HasOBD = "";
                        vehicleInfo.HasOBDTxt = "";
                    }

                    if (DateTime.TryParse(vehicleInfo.RegisterDate, out DateTime regDate))
                    {
                        vehicleInfo.RegisterDate = regDate.ToString("yyyy-MM-dd");
                    }

                    if (DateTime.TryParse(vehicleInfo.ManufactureDate, out DateTime mfDate))
                    {
                        vehicleInfo.ManufactureDate = mfDate.ToString("yyyy-MM-dd");
                    }
                    message.VehicleInfo = vehicleInfo;
                }

            }
            catch (Exception ex)
            {
                message.Succ = false;
                message.Msg = ex.Message;
            }
            return message;
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
                if ("51".Equals(hwdl.HPZLDM) || "52".Equals(hwdl.HPZLDM))
                    hwdl.HPZLDM = "99";
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
                    message.DetectItem = data["JCFFDM"] == null ? "2" : data["JCFFDM"].ToString();
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
            try
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
                LogHelper.Trace("请求过程开始" + JsonConvert.SerializeObject(dic));
                string s = Encoding.UTF8.GetString(result);
                LogHelper.Trace("过程开始响应" + s);
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
            catch (Exception ex)
            {
                FrmTips.ShowTips(AppHelper.MainForm,"过程开始异常，不能进行检测！" + ex.Message, 2000, true, System.Drawing.ContentAlignment.BottomRight,null, TipsSizeMode.None, new System.Drawing.Size(300, 100));
            }
        }

        private void FillEntity<Src, Target>(Src src, Target target)
        {
            PropertyInfo[] srcInfos = src.GetType().GetProperties();
            PropertyInfo[] targetInfos = target.GetType().GetProperties();
            foreach (var item in srcInfos)
            {
                MapperAttribute attribute = item.GetCustomAttributes(typeof(MapperAttribute)).FirstOrDefault() as MapperAttribute;
                if (attribute != null && !string.IsNullOrEmpty(attribute.TagName))
                {
                    foreach (var targetItem in targetInfos)
                    {
                        if (targetItem.Name.ToLower().Equals(attribute.TagName.ToLower()))
                        {
                            try
                            {
                                targetItem.SetValue(target, item.GetValue(src), null);
                            }
                            catch (Exception ex)
                            {
                                LogHelper.Debug("转换对象异常:" + ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}
