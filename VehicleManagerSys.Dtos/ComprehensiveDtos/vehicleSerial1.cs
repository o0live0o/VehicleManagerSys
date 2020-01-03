using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class vehicleSerial1
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
        /// 获取或设置整车制动率（牵）
        /// </summary>
        public string vehicleBrakeRateTractor
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整车制动率（挂）
        /// </summary>
        public string vehicleBrakeRateTrailer
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
        /// 获取或设置制动协调时间
        /// </summary>
        public string brakeCoordinateTime
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
