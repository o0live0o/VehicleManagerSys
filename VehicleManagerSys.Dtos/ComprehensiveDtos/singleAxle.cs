using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class singleAxle
    {
        /// <summary>
        /// 获取或设置轴序号（第几轴）
        /// </summary>
        public string axleSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轴制动率
        /// </summary>
        public string axleBrakeRate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制动不平衡率
        /// </summary>
        public string brakeUnbalanceRate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过程差最大点（左轮）
        /// </summary>
        public string leftMaxProcessDiff
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过程差最大点（右轮）
        /// </summary>
        public string rightMaxProcessDiff
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车轮阻滞率（左轮）
        /// </summary>
        public string leftRetardingForce
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车轮阻滞率（右轮）
        /// </summary>
        public string rightRetardingForce
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
