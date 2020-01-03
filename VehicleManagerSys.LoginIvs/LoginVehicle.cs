using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleManagerSys.Interface;
using Live0xUtils.DbUtils.SqlServer;

namespace VehicleManagerSys.LoginIvs
{
    public class LoginVehicle : ILoginVehicle
    {
        private MssqlHelper m_mssqlHelper = MssqlHelper.GetInstance();
        public Result<string> Login<VehicleInfo>(VehicleInfo vehicleInfo)
        {
            Result<string> result = new Result<string>();
            try
            {
                string[] carIgnoreArr = (from p in vehicleInfo.GetType().GetProperties()
                                         where p.GetValue(vehicleInfo, null) == null || string.IsNullOrEmpty(p.GetValue(vehicleInfo, null).ToString())
                                         select p.Name).ToArray();
                result.Succ = m_mssqlHelper.InsertOrUpdate(vehicleInfo, null, new string[] { "HPHM","VIN" }, carIgnoreArr);
            }
            catch (Exception ex)
            {
                result.Msg = ex.Message;
            }
            return result;
        }

        public ResultInfo Login<VehicleInfo, ResultInfo>(VehicleInfo vehicleInfo)
        {
            throw new NotImplementedException();
        }

        public string LoginReturnJson<VehicleInfo>(VehicleInfo vehicleInfo)
        {
            throw new NotImplementedException();
        }
    }
}
