using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class initData
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
        /// 获取或设置水平称重轮荷（左轮）
        /// </summary>
        public string leftHorizontalLoadWheel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置水平称重轮荷（右轮）
        /// </summary>
        public string rightHorizontalLoadWheel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置复合台称重轴荷
        /// </summary>
        public string axleLoadOfCompoundTable
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置动态轮荷（左轮）
        /// </summary>
        public string leftDynamicWheelLoad
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置动态轮荷（右轮）
        /// </summary>
        public string rightDynamicWheelLoad
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置行车制动力（左轮）
        /// </summary>
        public string leftDriveBrakeForce
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置行车制动力（右轮）
        /// </summary>
        public string rightDriveBrakeForce
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车制动力（左轮）
        /// </summary>
        public string leftParkBrakeForce
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车制动力（右轮）
        /// </summary>
        public string rightParkBrakeForce
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
