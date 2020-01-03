using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class detectReport
    {
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string note
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验结论
        /// </summary>
        public string detectResult
        {
            get;
            set;
        }

        public tractorInfo tractorInfo
        {
            get;
            set;
        }

        public trailerInfo trailerInfo
        {
            get;
            set;
        }

        public List<manualTestResult> manualTestResult
        {
            get;
            set;
        }

        public List<performanceItem> performanceItem
        {
            get;
            set;
        }
    }
}
