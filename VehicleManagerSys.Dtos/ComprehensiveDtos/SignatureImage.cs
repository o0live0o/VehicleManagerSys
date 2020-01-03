using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class SignatureImage
    {
        public SignatureImage()
        {
            dsId = "";
            detectSn = "";
            imageType = "";
            vinNo = "";
            vehicleNo = "";
            plateColorCode = "";
            base64Image = "";
        }
        /// <summary>
        /// 获取或设置授权签字人图片信息
        /// </summary>
        public string dsId
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验检测机构唯一编码，见附录B.1
        /// </summary>
        public string detectSn
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测流水号,见附录B.7
        /// </summary>
        public string imageType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置图片类型，见附录B.16
        /// </summary>
        public string vinNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆识别代码
        /// </summary>
        public string vehicleNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车牌号码
        /// </summary>
        public string plateColorCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车牌颜色代码,见附录B.3
        /// </summary>
        public string base64Image
        {
            get;
            set;
        }

    }

}
