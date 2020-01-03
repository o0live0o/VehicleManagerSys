using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class singleVehicle
    {
        /// <summary>
        /// 获取或设置水平称重
        /// </summary>
        public string horizontalWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整车制动率
        /// </summary>
        public string wholeVehicleBrakeRate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车制动率
        /// </summary>
        public string parkBrakeRate
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
