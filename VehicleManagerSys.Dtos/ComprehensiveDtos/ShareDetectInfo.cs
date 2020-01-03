using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class ShareDetectInfo
    {
        /// <summary>
        /// 获取或设置检测站编码
        /// </summary>
        public string dsId
        {
            get;
            set;
        }

        public string dsName
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验流水号
        /// </summary>
        public string detectSn
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测类别
        /// </summary>
        public string detectType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测日期
        /// </summary>
        public string detectDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测线别
        /// </summary>
        public string detectLine
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置业务类型
        /// </summary>
        public string busiType
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
        /// 获取或设置委托人
        /// </summary>
        public string client
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
        /// 获取或设置车牌颜色代码/号牌种类
        /// </summary>
        public string plateColorCode
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
        /// 获取或设置挂车牌照号
        /// </summary>
        public string trailerVehicleNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置挂车类型
        /// </summary>
        public string trailerVehicleType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂日期
        /// </summary>
        public string productionDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置注册日期
        /// </summary>
        public string registDate
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
        /// 获取或设置车辆型号
        /// </summary>
        public string vehicleBrandModel
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
        /// 获取或设置车身颜色
        /// </summary>
        public string vehicleBodyColor
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置行驶总里程
        /// </summary>
        public string travelMileage
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动型式
        /// </summary>
        public string driveType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆悬架形式
        /// </summary>
        public string vehicleSuspensionForm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置挂车轴数
        /// </summary>
        public string trailerVehicleAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置压燃式发动机额定功（kW）
        /// </summary>
        public string compressIgnitEnginePower
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置点燃式额定扭矩
        /// </summary>
        public string ratedTorque
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置点燃式额定转速
        /// </summary>
        public string ratedSpeedOfIgnit
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃油类别
        /// </summary>
        public string fuelType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动轮轮胎规格型号
        /// </summary>
        public string driveWheelModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总质量
        /// </summary>
        public string totalWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车高（mm）
        /// </summary>
        public string vehicleHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前轮距（mm）
        /// </summary>
        public string frontTrack
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置客车车长（mm）
        /// </summary>
        public string vehicleLength
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置客车类型与等级
        /// </summary>
        public string busTypeLevel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置货车车身型式
        /// </summary>
        public string truckBodyType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动轴数
        /// </summary>
        public string driveAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动轴空载质量（kg）
        /// </summary>
        public string driveAxleLoadMass
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置牵引车满载总质量（kg）
        /// </summary>
        public string totalWeightOfTractor
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置并装轴形式
        /// </summary>
        public string shaftForm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置转向轴数
        /// </summary>
        public string steeringAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯制
        /// </summary>
        public string lampSystem
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置座位（铺）数
        /// </summary>
        public string seatCount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置单车（主车）轴数
        /// </summary>
        public string mainVehicleAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置外廓尺寸（长×宽×高）（mm）（单车）
        /// </summary>
        public string overallSize
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置外廓尺寸（长×宽×高）（mm）（挂车）
        /// </summary>
        public string overallSizeTrailer
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置远光束能否单独调整
        /// </summary>
        public string farLightCanAdjust
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车轴
        /// </summary>
        public string parkAxle
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车厢栏板高度（单车）
        /// </summary>
        public string carriageSsideboardHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车厢栏板高度（挂车）
        /// </summary>
        public string ssideboardHeightTrailer
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总检次数
        /// </summary>
        public string detectTotalCount
        {
            get;
            set;
        }

        #region 陕西
        public string entryStaff
        {
            get;
            set;
        }
        public string leadStaff
        {
            get;
            set;
        }
        public string exhaustInspector
        {
            get;
            set;
        }
        public string atmoTemp
        {
            get;
            set;
        }
        public string atmoPressure
        {
            get;
            set;
        }
        public string atmoHumidity
        {
            get;
            set;
        }
        public string brakeTestRigCoefficient
        {
            get;
            set;
        }

        #endregion

        public power power
        {
            get;
            set;
        }

        public fuelEconomy fuelEconomy
        {
            get;
            set;
        }

        public brake brake
        {
            get;
            set;
        }

        public emission emission
        {
            get;
            set;
        }

        public List<suspension> suspension
        {
            get;
            set;
        }

        public List<mainLamp> mainLamp
        {
            get;
            set;
        }

        public List<singleItem> singleItem
        {
            get;
            set;
        }


    }
}
