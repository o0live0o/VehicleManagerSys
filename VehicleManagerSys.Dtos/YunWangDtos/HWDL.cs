using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common.Attributes;

namespace VehicleManagerSys.Dtos.YunWangDtos
{
    public class HWDL
    {
        public HWDL()
        {
            JGBH = "";
            HPHM = "";
            HPYSDM = "";
            HPZLDM = "";
            CLLXDM = "";
            CLXH = "";
            CLPP = "";
            CLSBDH = "";
            CLSCCS = "";
            FDJXH = "";
            FDJSCCS = "";
            FDJH = "";
            FDJPL = "";
            FDJEDZS = "";
            FDJEDGL = "";
            SYXZDM = "";
            ZCDJRQ = "";
            CCRQ = "";
            CZ = "";
            CZDH = "";
            CZDZ = "";
            PFBZDM = "";
            BSXXSDM = "";
            JQFSDM = "";
            RLZLDM = "";
            RLZLDM2 = "";
            GYFSDM = "";
            QDFSDM = "";
            ZDZZL = "";
            JZZL = "";
            ZBZL = "";
            SFYEGR = "";
            SFYHCLZZ = "";
            HCLZZZLDM = "";
            SFDK = "";
            LCBDS = "";
            QGS = "";
            SFYOBD = "";
            SFYDPF = "";
            SFYSCR = "";
            SFNGBESP = "";
            JDCZTDM = "";
            JDCXH = "";
            DCZZ = "";
            DPXH = "";
            QDLTQY = "";
            SFYRYZFKZZZ = "";
            SFYCHZHQ = "";
            RYGG = "";
            SJCYS = "";
            SSXQ = "";
            HBFLBZDM = "";
            GBDM = "";
            SFJRCZ = "";
            FDJCCS = "";
            DWS = "";
            YXRQ = "";
            DLSJ = "";
            JCLXDM = "";
            DLY = "";
            PFPDYJ = "";
            RLLBDM = "";
            DDJXH = "";
            CNZZXH = "";
            DCRL = "";
            CHZHQXH = "";
            HCLZZXH = "";
            λdown = "";
            λup = "";
            XZFL = "";
            //JYLSH = "";
            //JYCS = "";
            //JCFFDM = "";
        }
        /// <summary>
        /// 获取或设置检测机构编号
        /// </summary>
        public string JGBH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌号码
        /// </summary>
        [Mapper("PlateNo")]
        public string HPHM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌颜色代码
        /// </summary>
        [Mapper("PlateColor")]
        [Define("HPYS")]
        public string HPYSDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌种类代码
        /// </summary>
        [Mapper("PlateType")]
        public string HPZLDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆类型代码
        /// </summary>
        [Mapper("VehicleType")]
        public string CLLXDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆型号
        /// </summary>
        [Mapper("Model")]
        public string CLXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆品牌
        /// </summary>
        [Mapper("Brand")]
        public string CLPP
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆识别代号
        /// </summary>
        [Mapper("VIN")]
        public string CLSBDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆生产厂商
        /// </summary>
        [Mapper("Manufacturer")]
        public string CLSCCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机型号
        /// </summary>
        [Mapper("EngineModel")]
        public string FDJXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机生产厂商
        /// </summary>
        [Mapper("EngineManufacturer")]
        public string FDJSCCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机号
        /// </summary>
        [Mapper("EngineNumber")]
        public string FDJH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机排量(L)
        /// </summary>
        [Mapper("Displacement")]
        public string FDJPL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机额定转速
        /// </summary>
        [Mapper("RatedSpeed")]
        public string FDJEDZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机额定功率
        /// </summary>
        [Mapper("Power")]
        public string FDJEDGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置使用性质
        /// </summary>
        [Mapper("UseType")]
        public string SYXZDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置注册登记日期
        /// </summary>
        [Mapper("RegisterDate")]
        public string ZCDJRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂日期
        /// </summary>
        [Mapper("ManufactureDate")]
        public string CCRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车主
        /// </summary>
        [Mapper("Owner")]
        public string CZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车主电话
        /// </summary>
        [Mapper("OwnerPhone")]
        public string CZDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车主地址
        /// </summary>
        [Mapper("OwnerAddress")]
        public string CZDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排放标准代码
        /// </summary>
        [Mapper("EmissionStandard")]
        public string PFBZDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置变速箱形式代码
        /// </summary>
        [Mapper("TransmissionType")]
        [Define("BSXLX")]
        public string BSXXSDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置进气方式代码
        /// </summary>
        [Mapper("IntakeType")]
        [Define("JQFS")]
        public string JQFSDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料种类代码
        /// </summary>
        [Mapper("FuelType")]
        [Define("RLLB")]
        public string RLZLDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料种类2代码
        /// </summary>
        public string RLZLDM2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置供油方式代码
        /// </summary>
        [Mapper("FuelSupplyType")]
        [Define("GYFS")]
        public string GYFSDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动方式代码
        /// </summary>
        [Mapper("DriveType")]
        [Define("QDXS")]
        public string QDFSDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置最大总质量
        /// </summary>
        [Mapper("TotalWeight")]
        public string ZDZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置基准质量
        /// </summary>
        [Mapper("BasicWeight")]
        public string JZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整备质量
        /// </summary>
        [Mapper("KerbWeight")]
        public string ZBZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有EGR
        /// </summary>
        [Mapper("HasEGR")]
        public string SFYEGR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有后处理装置
        /// </summary>
        [Mapper("HasTreatmentDevice")]
        public string SFYHCLZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置后处理装置种类代码
        /// </summary>
        [Mapper("TreatmentDeviceType")]
        public string HCLZZZLDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否电控
        /// </summary>
        [Mapper("IsElectricControl")]
        public string SFDK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置里程表读数
        /// </summary>
        [Mapper("Mileage")]
        public string LCBDS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置气缸数
        /// </summary>
        [Mapper("NumOfCylinder")]
        public string QGS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有OBD
        /// </summary>
        [Mapper("HasOBD")]
        public string SFYOBD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有DPF
        /// </summary>
        [Mapper("HasDPF")]
        public string SFYDPF
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有EPR
        /// </summary>
        [Mapper("HasSCR")]
        public string SFYSCR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否能关闭车身稳定系统
        /// </summary>
        [Mapper("CloseStabilitySys")]
        public string SFNGBESP
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置机动车状态代码
        /// </summary>
        [Mapper("VehicleStatus")]
        public string JDCZTDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置机动车序号
        /// </summary>
        [Mapper("VehicleSerialNo")]
        public string JDCXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置单车轴重
        /// </summary>
        [Mapper("AxleWeight")]
        public string DCZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置底盘型号
        /// </summary>
        [Mapper("ChassisModel")]
        public string DPXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驱动轮胎气压
        /// </summary>
        [Mapper("TirePressure")]
        public string QDLTQY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有燃油蒸发控制装置
        /// </summary>
        [Mapper("EVAPControl")]
        public string SFYRYZFKZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否有催化转化器
        /// </summary>
        [Mapper("HasCatalyticConverter")]
        public string SFYCHZHQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃油规格
        /// </summary>
        [Mapper("FuelSpecification")]
        public string RYGG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置设计乘员数
        /// </summary>
        [Mapper("PassengerAmount")]
        public string SJCYS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置所属辖区
        /// </summary>
        [Mapper("Jurisdiction")]
        public string SSXQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置环保分类标志
        /// </summary>
        [Mapper("ClassifyMark")]
        public string HBFLBZDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置国别代码
        /// </summary>
        [Mapper("Country")]
        public string GBDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否进入城镇
        /// </summary>
        [Mapper("IsEntryTown")]
        public string SFJRCZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机冲程数
        /// </summary>
        [Mapper("NumOfStroke")]
        public string FDJCCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置档位数
        /// </summary>
        [Mapper("NumOfGear")]
        public string DWS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置有效日期
        /// </summary>
        public string YXRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置登录时间
        /// </summary>
        public string DLSJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检测类型代码
        /// </summary>
        [Mapper("DetectType")]
        public string JCLXDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置登录员
        /// </summary>
        public string DLY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排放判定依据
        /// </summary>
        public string PFPDYJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料类别代码
        /// </summary>
       [Mapper("FuelModel")]
        public string RLLBDM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置电动机型号
        /// </summary>
        [Mapper("ElectricMotorsModel")]
        public string DDJXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置储能装置型号
        /// </summary>
        [Mapper("StroageDeviceModel")]
        public string CNZZXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置电池容量
        /// </summary>
        [Mapper("BatteryCapacity")]
        public string DCRL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置催化转化器型号
        /// </summary>
        [Mapper("CatalyticConverterModel")]
        public string CHZHQXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置后处理装置型号
        /// </summary>
        [Mapper("TreatmentDeviceModel")]
        public string HCLZZXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数下限
        /// </summary>
        public string λdown
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置过量空气系数上限
        /// </summary>
        public string λup
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排放限值分类
        /// </summary>
        [Mapper("LimitType")]
        [Define("XZFL")]
        public string XZFL
        {
            get;
            set;
        }

        ///// <summary>
        ///// 获取或设置检验流水号
        ///// </summary>
        //[Mapper("TestNoForNet")]
        //public string JYLSH
        //{
        //    get;
        //    set;
        //}

        ///// <summary>
        ///// 获取或设置检验次数
        ///// </summary>
        //[Mapper("Times")]
        //public string JYCS
        //{
        //    get;
        //    set;
        //}

        ///// <summary>
        ///// 获取或设置检测方法代码
        ///// </summary>
        //[Mapper("DetectItem")]
        //[Define("JYXM")]
        //public string JCFFDM
        //{
        //    get;
        //    set;
        //}

    }

}
