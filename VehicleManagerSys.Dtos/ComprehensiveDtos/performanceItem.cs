using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class performanceItem
    {
        /// <summary>
        /// 获取或设置检测项编码
        /// </summary>
        public string itemCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测数据
        /// </summary>
        public string detectData
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置标准限值
        /// </summary>
        public string standardValue
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


    }
}
