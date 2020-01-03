using Live0xUtils.DbUtils.SqlServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleManagerSys.Interface;

namespace VehicleManagerSys.LoginIvs
{
    public class QueryVehicle : IQueryVehicle
    {
        private MssqlHelper m_mssqlHelper = Live0xUtils.DbUtils.SqlServer.MssqlHelper.GetInstance();

        public Result<VehicleInfo> Query<VehicleInfo>(string plateNo)
        {
            Result<VehicleInfo> result = new Result<VehicleInfo>();
            try
            {
                Hashtable hashtable = new Hashtable();
                string sql = "SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM = @HPHM";
                hashtable.Add("HPHM",plateNo);
                result.Entity = m_mssqlHelper.Query<VehicleInfo>(sql, hashtable);
                result.Succ = true;
            }
            catch (Exception ex)
            {
                result.Msg = ex.Message;
            }
            return result;
        }

        public Result<VehicleInfo> Query<VehicleInfo>(string plateNo, string plateType)
        {
            Result<VehicleInfo> result = new Result<VehicleInfo>();
            try
            {
                Hashtable hashtable = new Hashtable();
                string sql = "SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM = @HPHM";
                hashtable.Add("HPHM", plateNo);
                result.Entity = m_mssqlHelper.Query<VehicleInfo>(sql, hashtable);
            }
            catch (Exception ex)
            {
                result.Msg = ex.Message;
            }
            return result;
        }
    }
}
