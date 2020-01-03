using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class manualTestResult
    {
        /// <summary>
        /// 获取或设置检验项目
        /// </summary>
        public string detectCls
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

        /// <summary>
        /// 获取或设置不符合项目
        /// </summary>
        public string unqualifiedItem
        {
            get;
            set;
        }


    }
}
