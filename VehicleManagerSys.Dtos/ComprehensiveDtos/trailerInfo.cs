using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class trailerInfo
    {
        /// <summary>
        /// 获取或设置号牌号码
        /// </summary>
        public string vehicleNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置委托人
        /// </summary>
        public string client
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆类型
        /// </summary>
        public string vehicleType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置品牌/型号
        /// </summary>
        public string vehicleBrandModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置营运证号
        /// </summary>
        public string transCertificateCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置注册登记日期
        /// </summary>
        public string registDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂年月
        /// </summary>
        public string productionDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆识别代号
        /// </summary>
        public string vinNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置有效行驶证件
        /// </summary>
        public string driveLicense
        {
            get;
            set;
        }


    }
}
