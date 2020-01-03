using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Interface
{
    public interface IQueryVehicle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="plateNo">号牌号码</param>
        /// <returns></returns>
        Result<VehicleInfo> Query<VehicleInfo>(string plateNo);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="plateNo">号牌号码</param>
        /// <param name="plateType">号牌种类</param>
        /// <returns></returns>
        Result<VehicleInfo> Query<VehicleInfo>(string plateNo,string plateType);
    }
}
