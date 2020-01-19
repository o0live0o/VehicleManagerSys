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
            DetectType = "";
            TestNo_Net = "";
            TestNo = "";
            PlateNo = "";
            PlateType = "";
            VIN = "";
            VehicleType = "";
            IsNet = "";
            Owner = "";
            OwnerAddress = "";
            OwnerPhone = "";
            UseType = "";
            VehicleUseType = "";
            Brand = "";
            Model = "";
            EngineNumber = "";
            DriveType = "";
            ManufactureDate = "";
            RegisterDate = "";
            PassengerAmount = "";
            Weight = "";
            KerbWeight = "";
            ApproveWeight = "";
            Length = "";
            Width = "";
            Height = "";
            SteeringAxleAmount = "";
            SuspensionType = "";
            LampType = "";
            LampCanAdjust = "";
            AxleAmount = "";
            ParkingAxle = "";
            DriveAxleAmount = "";
            FuelType = "";
            MaxSpeed = "";
            Mileage = "";
            IsTrain = "";
            Times = "";
            Driver = "";
            Operator = "";
            DetectItem = "";
            PlateColor = "";
        }
        /// <summary>
        /// 获取或设置检验类别
        /// </summary>
        public string DetectType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置联网流水号
        /// </summary>
        public string TestNo_Net
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
        public string UseType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆用途
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
        public string Weight
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
        public string SuspensionType
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前照灯制
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
        public string DetectItem
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌颜色
        /// </summary>
        public string PlateColor
        {
            get;
            set;
        }

    }

}
