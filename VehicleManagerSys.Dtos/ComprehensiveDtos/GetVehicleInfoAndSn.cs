using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{

    public class GetVehicleInfoAndSn
    {
        /// <summary>
        /// 获取或设置检验检测机构唯一编码，见附录B.1
        /// </summary>
        public string dsId
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车牌号码
        /// </summary>
        public string vehicleNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车牌颜色代码，见附录B.3
        /// </summary>
        public string plateColorCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆识别代码
        /// </summary>
        public string vinNo
        {
            get;
            set;
        }


    }


}
