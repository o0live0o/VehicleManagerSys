using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos
{
    public class VehicleInfo
    {
        public VehicleInfo()
        {
            DetectTypeTxt = "";
            DetectType = "";
            TestNoForNet = "";
            TestNo = "";
            PlateNo = "";
            PlateTypeTxt = "";
            PlateType = "";
            VIN = "";
            VehicleTypeTxt = "";
            VehicleType = "";
            IsNet = "";
            Owner = "";
            OwnerAddress = "";
            OwnerPhone = "";
            UseTypeTxt = "";
            UseType = "";
            VehicleUseTypeTxt = "";
            VehicleUseType = "";
            Brand = "";
            Model = "";
            EngineNumber = "";
            DriveTypeTxt = "";
            DriveType = "";
            ManufactureDate = "";
            RegisterDate = "";
            PassengerAmount = "";
            TotalWeight = "";
            KerbWeight = "";
            ApproveWeight = "";
            Length = "";
            Width = "";
            Height = "";
            SteeringAxleAmount = "";
            SuspensionTypeTxt = "";
            SuspensionType = "";
            LampTypeTxt = "";
            LampType = "";
            LampCanAdjust = "";
            AxleAmount = "";
            ParkingAxle = "";
            DriveAxleAmount = "";
            FuelTypeTxt = "";
            FuelType = "";
            MaxSpeed = "";
            Mileage = "";
            IsTrain = "";
            Times = "";
            Driver = "";
            Operator = "";
            DetectItemTxt = "";
            DetectItem = "";
            PlateColorTxt = "";
            PlateColor = "";
            BasicWeight = "";
            EngineManufacturer = "";
            Power = "";
            NumOfCylinder = "";
            IsElectricControl = "";
            TransmissionTypeTxt = "";
            TransmissionType = "";
            RatedSpeed = "";
            IntakeTypeTxt = "";
            IntakeType = "";
            Displacement = "";
            FuelSupplyTypeTxt = "";
            FuelSupplyType = "";
            EngineModel = "";
            TirePressure = "";
            FuelSpecification = "";
            NumOfStroke = "";
            NumOfGear = "";
            ElectricMotorsModel = "";
            Manufacturer = "";
            HasDPFTxt = "";
            HasDPF = "";
            DPFModel = "";
            HasSCRTxt = "";
            HasSCR = "";
            SCRFModel = "";
            HasOBDTxt = "";
            HasOBD = "";
            ClassifyMarkTxt = "";
            ClassifyMark = "";
            HasEGRTxt = "";
            HasEGR = "";
            StroageDeviceModel = "";
            EmissionStandardTxt = "";
            EmissionStandard = "";
            LimitTypeText = "";
            LimitType = "";
            VehicleStatusTxt = "";
            VehicleStatus = "";
            VehicleSerialNo = "";
            CountryTxt = "";
            Country = "";
            Jurisdiction = "";
            BatteryCapacity = "";
            IsEntryTownTxt = "";
            IsEntryTown = "";
            CloseStabilitySysTxt = "";
            CloseStabilitySys = "";
            EVAPControlTxt = "";
            EVAPControl = "";
            AxleWeight = "";
            ChassisModel = "";
            HasCatalyticConverterTxt = "";
            HasCatalyticConverter = "";
            CatalyticConverterModel = "";
            HasTreatmentDeviceTxt = "";
            HasTreatmentDevice = "";
            TreatmentDeviceModel = "";
        }
        /// <summary>
        /// 获取或设置检验类别
        /// </summary>
        public string DetectTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验类别代码
        /// </summary>
        public string DetectType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置联网流水号
        /// </summary>
        public string TestNoForNet
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测流水号
        /// </summary>
        public string TestNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌号码
        /// </summary>
        public string PlateNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌种类
        /// </summary>
        public string PlateTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌种类代号
        /// </summary>
        public string PlateType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置VIN
        /// </summary>
        public string VIN
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆种类
        /// </summary>
        public string VehicleTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆种类
        /// </summary>
        public string VehicleType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否联网
        /// </summary>
        public string IsNet
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置所有人
        /// </summary>
        public string Owner
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置住址
        /// </summary>
        public string OwnerAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置联系电话
        /// </summary>
        public string OwnerPhone
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置使用性质
        /// </summary>
        public string UseTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置使用性质代码
        /// </summary>
        public string UseType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆用途
        /// </summary>
        public string VehicleUseTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆用途代码
        /// </summary>
        public string VehicleUseType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置品牌
        /// </summary>
        public string Brand
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置型号
        /// </summary>
        public string Model
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机/电动机码
        /// </summary>
        public string EngineNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动形式
        /// </summary>
        public string DriveTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动形式代码
        /// </summary>
        public string DriveType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂日期
        /// </summary>
        public string ManufactureDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置初始登记日期
        /// </summary>
        public string RegisterDate
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核载人数
        /// </summary>
        public string PassengerAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总质量
        /// </summary>
        public string TotalWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整备质量
        /// </summary>
        public string KerbWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核定载质量
        /// </summary>
        public string ApproveWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置长
        /// </summary>
        public string Length
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置宽
        /// </summary>
        public string Width
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置高
        /// </summary>
        public string Height
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置转向轴数量
        /// </summary>
        public string SteeringAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置悬架形式
        /// </summary>
        public string SuspensionTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置悬架形式代码
        /// </summary>
        public string SuspensionType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯制
        /// </summary>
        public string LampTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯制代码
        /// </summary>
        public string LampType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯远光光束是否可调
        /// </summary>
        public string LampCanAdjust
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总轴数
        /// </summary>
        public string AxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驻车轴位置
        /// </summary>
        public string ParkingAxle
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动轴位置
        /// </summary>
        public string DriveAxleAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料类别
        /// </summary>
        public string FuelTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料类别代码
        /// </summary>
        public string FuelType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置最高设计车速
        /// </summary>
        public string MaxSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置累计行驶里程
        /// </summary>
        public string Mileage
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否汽车列车
        /// </summary>
        public string IsTrain
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测次数
        /// </summary>
        public string Times
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置引车员
        /// </summary>
        public string Driver
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置登录员
        /// </summary>
        public string Operator
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验项目
        /// </summary>
        public string DetectItemTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验项目代码
        /// </summary>
        public string DetectItem
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌颜色
        /// </summary>
        public string PlateColorTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌颜色代码
        /// </summary>
        public string PlateColor
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置基准质量
        /// </summary>
        public string BasicWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机生产厂
        /// </summary>
        public string EngineManufacturer
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置额定功率
        /// </summary>
        public string Power
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置气缸数
        /// </summary>
        public string NumOfCylinder
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否电控
        /// </summary>
        public string IsElectricControl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置变速箱形式
        /// </summary>
        public string TransmissionTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置变速箱形式代码
        /// </summary>
        public string TransmissionType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置额定转速
        /// </summary>
        public string RatedSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置进气方式
        /// </summary>
        public string IntakeTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置进气方式代码
        /// </summary>
        public string IntakeType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排量
        /// </summary>
        public string Displacement
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置供油方式
        /// </summary>
        public string FuelSupplyTypeTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置供油方式代码
        /// </summary>
        public string FuelSupplyType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机型号
        /// </summary>
        public string EngineModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轮胎气压
        /// </summary>
        public string TirePressure
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃油规格
        /// </summary>
        public string FuelSpecification
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机冲程数
        /// </summary>
        public string NumOfStroke
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置档位数
        /// </summary>
        public string NumOfGear
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置电动机型号
        /// </summary>
        public string ElectricMotorsModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆生产企业
        /// </summary>
        public string Manufacturer
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有DPF
        /// </summary>
        public string HasDPFTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有DPF
        /// </summary>
        public string HasDPF
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPF型号
        /// </summary>
        public string DPFModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有SCR
        /// </summary>
        public string HasSCRTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有SCR
        /// </summary>
        public string HasSCR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SCR型号
        /// </summary>
        public string SCRFModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有OBD
        /// </summary>
        public string HasOBDTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有OBD
        /// </summary>
        public string HasOBD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置环保分类标志
        /// </summary>
        public string ClassifyMarkTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置环保分类标志代码
        /// </summary>
        public string ClassifyMark
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有EGR
        /// </summary>
        public string HasEGRTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有EGR
        /// </summary>
        public string HasEGR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置储能装置型号
        /// </summary>
        public string StroageDeviceModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排放标准
        /// </summary>
        public string EmissionStandardTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排放标准
        /// </summary>
        public string EmissionStandard
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置限值类型
        /// </summary>
        public string LimitTypeText
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置限值类型
        /// </summary>
        public string LimitType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆状态
        /// </summary>
        public string VehicleStatusTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆状态
        /// </summary>
        public string VehicleStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆序号
        /// </summary>
        public string VehicleSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置国别
        /// </summary>
        public string CountryTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置国别
        /// </summary>
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置辖区
        /// </summary>
        public string Jurisdiction
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置电池容量
        /// </summary>
        public string BatteryCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否进入城镇
        /// </summary>
        public string IsEntryTownTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否进入城镇
        /// </summary>
        public string IsEntryTown
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否能关闭车身稳定系统
        /// </summary>
        public string CloseStabilitySysTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否能关闭车身稳定系统
        /// </summary>
        public string CloseStabilitySys
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有燃油蒸发控制装置
        /// </summary>
        public string EVAPControlTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有燃油蒸发控制装置
        /// </summary>
        public string EVAPControl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置单车轴重
        /// </summary>
        public string AxleWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置底盘型号
        /// </summary>
        public string ChassisModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有催化转换器
        /// </summary>
        public string HasCatalyticConverterTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有催化转换器
        /// </summary>
        public string HasCatalyticConverter
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置催化转换器型号
        /// </summary>
        public string CatalyticConverterModel
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有后处理装置
        /// </summary>
        public string HasTreatmentDeviceTxt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有后处理装置
        /// </summary>
        public string HasTreatmentDevice
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置后处理装置型号
        /// </summary>
        public string TreatmentDeviceModel
        {
            get;
            set;
        }
    }



}
