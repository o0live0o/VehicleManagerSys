using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class singleItem
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
        /// 获取或设置检测结果
        /// </summary>
        public string detectResult
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
