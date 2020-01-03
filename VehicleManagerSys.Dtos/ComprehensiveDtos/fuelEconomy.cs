using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class fuelEconomy
    {
        /// <summary>
        /// 获取或设置等速百公里油耗标准限值
        /// </summary>
        public string speedFuelPerHundredKm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置实测值
        /// </summary>
        public string measuredValue
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置判定
        /// </summary>
        public string evaluate
        {
            get;
            set;
        }

        public string count
        {
            get;
            set;
        }
    }
}
