using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class driveBrake
    {
        /// <summary>
        /// 获取或设置初速度
        /// </summary>
        public string initialVelocity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置试车道宽度
        /// </summary>
        public string laneWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制动距离
        /// </summary>
        public string brakeDistance
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MFDD
        /// </summary>
        public string mfdd
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制动稳定性
        /// </summary>
        public string brakeStability
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置汽车列车制动协调时间
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
