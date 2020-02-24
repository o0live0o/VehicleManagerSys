using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public AppMessage SendCar(VehicleInfo info)
        {
            AppMessage message = new AppMessage() { Succ = false,Msg = "程序异常"};
            try
            {
                HWDL hwdl = new HWDL();
                AppTools.FillEntiyByAttr(info, hwdl);
                //TODO 特殊转换
                Hashtable hashtable = new Hashtable();
                hashtable.Add("jkid","");
                hashtable.Add("jkxlh","");
                hashtable.Add("writejson","");
                Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
                string s = httpRequest.HttpPost("url", JsonConvert.SerializeObject(hashtable));
                hashtable.Clear();
                hashtable = JsonConvert.DeserializeObject<Hashtable>(s);
                message.Msg = hashtable["msg"] == null ? "" : hashtable["msg"].ToString();
                message.Succ = hashtable["code"] == null ? false :
                    (hashtable["code"].ToString().Equals("success") ? true : false);
                if (message.Succ)
                {
                    Hashtable data = new Hashtable();
                    data = JsonConvert.DeserializeObject<Hashtable>(hashtable["JYLSH"].ToString());
                    message.NetTestNo = data["JYLSH"].ToString();
                    message.Times = data["JYCS"].ToString();
                }
            }
            catch (Exception ex)
            {
                message.Msg = ex.Message;
            }
            return message;
        }
    }
}
