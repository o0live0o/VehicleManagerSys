using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class reportImage
    {
        /// <summary>
        /// 获取或设置检验站编号
        /// </summary>
        public string dsId
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测流水号
        /// </summary>
        public string detectSn
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆VIN码
        /// </summary>
        public string vinNo
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
        /// 获取或设置车牌颜色代码
        /// </summary>
        public string plateColorCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置安检结论图片信息代码1-机动车安检报告照片 2-机动车安检合格标志照片 3-行驶证照片
        /// </summary>
        public string imageType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置图片信息，经base64编码后字符串
        /// </summary>
        public string base64Image
        {
            get;
            set;
        }


    }
}
