using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class mainLamp
    {
        /// <summary>
        /// 获取或设置灯类型
        /// </summary>
        public string lampType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置灯高（近光）
        /// </summary>
        public string nearLightLampHight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置灯高（远光）
        /// </summary>
        public string farLightLampHight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置远光光强
        /// </summary>
        public string farLightStrong
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置远光偏移（垂直）
        /// </summary>
        public string farLightVOffset
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置远光偏移（水平）
        /// </summary>
        public string farLightHOffset
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置近光偏移（垂直）
        /// </summary>
        public string nearLightVOffset
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置近光偏移（水平）
        /// </summary>
        public string nearLightHOffset
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
