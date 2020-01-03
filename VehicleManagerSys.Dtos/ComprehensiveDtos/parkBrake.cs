using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    //驻车制动
    public class parkBrake
    {
        /// <summary>
        /// 获取或设置驻车坡度
        /// </summary>
        public string parkSlope
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置不少于5min坡道驻车情况
        /// </summary>
        public string parkResult
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
