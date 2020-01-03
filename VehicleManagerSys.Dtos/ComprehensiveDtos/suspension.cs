using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class suspension
    {
        /// <summary>
        /// 获取或设置轴类型
        /// </summary>
        public string axleType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置左吸收率
        /// </summary>
        public string efficiencyOfLeftAxle
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置右吸收率
        /// </summary>
        public string efficiencyOfRightAxle
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置左右差
        /// </summary>
        public string absorbRateDifOfAxle
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
