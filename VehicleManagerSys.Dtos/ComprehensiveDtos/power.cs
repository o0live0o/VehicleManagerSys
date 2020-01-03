using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class power
    {
        /// <summary>
        /// 获取或设置达标功率
        /// </summary>
        public string standardPower
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置额定车速
        /// </summary>
        public string ratedSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置加载力
        /// </summary>
        public string loadingForce
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置稳定车速
        /// </summary>
        public string steadySpeed
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
