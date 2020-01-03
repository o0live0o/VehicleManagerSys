using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class GetVehicleInfoAndSnResult
    {
        /// <summary>
        /// 获取或设置检测流水号,见附录B.7
        /// </summary>
        public string detectSn
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

        /// <summary>
        /// 获取或设置所属业户名称
        /// </summary>
        public string ownerName
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车身颜色，见附录B.2
        /// </summary>
        public string vehicleBodyColor
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置挂车牌照号码
        /// </summary>
        public string trailerVehicleNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置厂牌型号参照JT/T 697.7
        /// </summary>
        public string vehicleBrandModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置道路运输证号
        /// </summary>
        public string transCertificateCode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置道路运输证初领日期:YYYYMMDD
        /// </summary>
        public string transCertificateFirstDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机号码
        /// </summary>
        public string engineNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机型号
        /// </summary>
        public string engineModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置底盘号码
        /// </summary>
        public string chassisNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂日期:YYYYMMDD
        /// </summary>
        public string productionDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置注册日期:YYYYMMDD
        /// </summary>
        public string registDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆类型：参照GA24.4
        /// </summary>
        public string vehicleType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置客车类型与等级，参照JT/T697.7
        /// </summary>
        public string busTypeLevel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制动方式，参照GB/T 26765
        /// </summary>
        public string brakeModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车类型，规定值：手刹、脚刹、电子驻车
        /// </summary>
        public string parkType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动型式，如：4×2后驱
        /// </summary>
        public string driveType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置外廓尺寸，格式：长×宽×高 单位：mm
        /// </summary>
        public string overallSize
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆轴数,单位：轴
        /// </summary>
        public string axleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置转向轴数，单位：轴
        /// </summary>
        public string steeringAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆驱动轴数，单位：轴
        /// </summary>
        public string driveAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃油类别，接口传递相应编码
        /// </summary>
        public string fuelType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯制，规定值：二、四
        /// </summary>
        public string lampSystem
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆悬架形式，参照JT/T 697.7
        /// </summary>
        public string vehicleSuspensionForm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整备质量，单位：kg
        /// </summary>
        public string vehicleWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核定载质量，单位：kg
        /// </summary>
        public string approveWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总质量，单位：kg
        /// </summary>
        public string totalWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核定满载人员数，参照JT/T 697.7
        /// </summary>
        public string ratifiedLoadCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置座位（铺）数 ，单位：位，客车必填，货车非必填
        /// </summary>
        public string seatCount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置行驶里程 单位：km
        /// </summary>
        public string travelMileage
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置远光束能否单独调整，值：是、否
        /// </summary>
        public string farLightCanAdjust
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车轴，用数字表示，作用在多轴时，各驻车轴数用“,”分开
        /// </summary>
        public string parkAxle
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置最大设计车速
        /// </summary>
        public string maxDesignSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否涡轮增压
        /// </summary>
        public string isTurbo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否ABS制动
        /// </summary>
        public string isAbs
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机缸
        /// </summary>
        public string engineCylinderNumber
        {
            get;
            set;
        }
    }

}
