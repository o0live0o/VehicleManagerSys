using Live0xUtils.WebServiceUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using VehicleManagerSys.Common;
using VehicleManagerSys.Common.Attributes;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Dtos.SafetyTest;

namespace VehicleManagerSys.Core.Services.SafetyTestServices
{
    public class SafetyTestService
    {
        public AppMessage Request18C49(string plateNo, string vin, string plateType)
        {
            AppMessage appMessage = new AppMessage();
            VehicleInfo vehicleInfo = new VehicleInfo();
            Response_18C49 response_18C49 = null;
            try
            {
                Request_18C49 request_18C49 = new Request_18C49();
                request_18C49.clsbdh = vin;
                request_18C49.hphm = plateNo;
                request_18C49.hpzl = plateType;
                request_18C49.jyjgbh = AppHelper.SafetyTestConfigs?.StationNo;
                string reqXml = Live0xUtils.XMLUtils.XMLHelper.CreateXMLEx0(request_18C49, "root", "GBK");
                LogHelper.Trace("18C49查询:" + reqXml);
                var rspXml = Request("queryObjectOut", "18C49", reqXml);
                rspXml = HttpUtility.HtmlDecode(rspXml ?? "");
                LogHelper.Trace("18C49返回:" + (rspXml ?? ""));
                if (!string.IsNullOrEmpty(reqXml))
                {
                    if ("1".Equals(Live0xUtils.RegexUtils.RegexXML.MatchField(rspXml, "code", false)))
                    {
                        appMessage.Succ = true;
                        response_18C49 = Live0xUtils.RegexUtils.RegexXML.XmlToModelByName<Response_18C49>(rspXml);
                        if (response_18C49 != null)
                        {
                            FillEntity(response_18C49, vehicleInfo);
                            vehicleInfo.FuelTypeTxt = AppHelper.GetDefineName("RLLB", vehicleInfo.FuelType);
                            vehicleInfo.UseType = AppHelper.GetLocalType("SYXZ",vehicleInfo.UseType);
                            vehicleInfo.UseTypeTxt = AppHelper.GetDefineName("SYXZ", vehicleInfo.UseType);
                            vehicleInfo.VehicleTypeTxt = AppHelper.GetDefineName("CLZL", vehicleInfo.VehicleType);
                            vehicleInfo.PlateTypeTxt = AppHelper.GetDefineName("HPZL",vehicleInfo.PlateType);
                            if (DateTime.TryParse(vehicleInfo.RegisterDate ?? "", out DateTime d))
                                vehicleInfo.RegisterDate = d.ToString("yyyy-MM-dd");
                            appMessage.VehicleInfo = vehicleInfo;
                        }
                    }
                    else
                    {
                        appMessage.Succ = false;
                        appMessage.Msg = Live0xUtils.RegexUtils.RegexXML.MatchField(rspXml, "message", false);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("18C49解释异常:" + ex.Message);
                appMessage.Msg = ex.Message;
            }
            return appMessage;
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
                                LogHelper.Debug("转换对象异常:"+ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private string Request(string method, string interfaceId,string xml)
        {
            var rspXml = "";
            try
            {
                WebServiceHelper webServiceHelper = new WebServiceHelper();
                Hashtable hashtable = new Hashtable();
                hashtable.Add("xtlb", "18");
                hashtable.Add("jkxlh", AppHelper.SafetyTestConfigs?.SerialNo);
                hashtable.Add("jkid", interfaceId);
                hashtable.Add("cjsqbh", "01");
                hashtable.Add("dwjgdm", "500000008255");
                hashtable.Add("dwmc", AppHelper.SafetyTestConfigs?.StationName);
                hashtable.Add("yhbz", "");
                hashtable.Add("yhxm", "");
                hashtable.Add("zdbs", AppHelper.GetLocalIP());
                hashtable.Add("QueryXmlDoc", xml);
                rspXml = webServiceHelper.SoapMethod(AppHelper.SafetyTestConfigs?.NameSpace,
                  AppHelper.SafetyTestConfigs?.ServiceUrl,
                     method, hashtable);
            }
            catch (WebException wex)
            {
                LogHelper.Error("安检联网异常："+wex.Message);
            }
            catch (Exception ex)
            {
                LogHelper.Error("安检联网异常：" + ex.Message);
            }
            return rspXml;
        }
    }
}
