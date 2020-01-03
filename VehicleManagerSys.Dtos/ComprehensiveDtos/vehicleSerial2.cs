using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class vehicleSerial2
    {
        /// <summary>
        /// 获取或设置整车制动率比 % (牵引车/列车)
        /// </summary>
        public string brakeRateTractorTrain
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整车制动率比 % (挂车/列车)
        /// </summary>
        public string brakeRateTrailerTrain
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
