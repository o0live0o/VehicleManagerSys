using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class gasolineVehicle
    {
        /// <summary>
        /// 获取或设置CO_高怠速
        /// </summary>
        public string highCo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_高怠速
        /// </summary>
        public string highHc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置λ_高怠速
        /// </summary>
        public string highL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CO_低怠速
        /// </summary>
        public string lowCo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_低怠速
        /// </summary>
        public string lowHc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CO_5025
        /// </summary>
        public string co5025
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_5025
        /// </summary>
        public string hc5025
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置NO_5025
        /// </summary>
        public string no5025
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CO_2540
        /// </summary>
        public string co2540
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_2540
        /// </summary>
        public string hc2540
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置NO_2540
        /// </summary>
        public string no2540
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CO_简易瞬态工况
        /// </summary>
        public string vmasCo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_简易瞬态工况
        /// </summary>
        public string vmasHc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置NO_简易瞬态工况
        /// </summary>
        public string vmasNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HC_NO_简易瞬态工况
        /// </summary>
        public string vmasHcNo
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
