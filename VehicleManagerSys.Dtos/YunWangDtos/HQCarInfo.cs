using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common.Attributes;

namespace VehicleManagerSys.Dtos.YunWangDtos
{
    public class HQCarInfo
    {
        public HQCarInfo()
        {

        }

        [Mapper("PlateNo")]
        public string License { get; set; }

        [Mapper("PlateColor")]
        public string LicenseType { get; set; }

        [Mapper("PlateType")]
        public string LicenseCode { get; set; }

        [Mapper("VehicleType")]
        public string VehicleType { get; set; }

        [Mapper("Model")]
        public string VehicleModel { get; set; }

        [Mapper("Brand")]
        public string CLPP { get; set; }

        [Mapper("VIN")]
        public string VIN { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        [Mapper("EngineModel")]
        public string Engine { get; set; }


        [Mapper("EngineManufacturer")]
        public string EngineManuf { get; set; }

        [Mapper("EngineNumber")]
        public string FDJH { get; set; }

        [Mapper("Displacement")]
        public string ED { get; set; }

        [Mapper("Power")]
        public string EnginePower { get; set; }

        [Mapper("UseType")]
        public string UseType { get; set; }

        [Mapper("RegisterDate")]
        public string RegisterDate { get; set; }

        [Mapper("ManufactureDate")]
        public string MDate { get; set; }

        [Mapper("Owner")]
        public string CZ { get; set; }

        //[Mapper("EmissionStandard")]
        public string Standard { get; set; }

        [Mapper("FuelType")]
        public string FuelType { get; set; }

        [Mapper("TotalWeight")]
        public string GVM { get; set; }

        [Mapper("BasicWeight")]
        public string RM { get; set; }

        [Mapper("KerbWeight")]
        public string ZBZL { get; set; }

        [Mapper("NumOfCylinder")]
        public string QGS { get; set; }

        [Mapper("VehicleStatus")]
        public string JDCZTDM { get; set; }

        [Mapper("PassengerAmount")]
        public string SJCYS { get; set; }

        [Mapper("Jurisdiction")]
        public string SSXQ { get; set; }

        //[Mapper("FuelModel")]
        public string RLLBDM { get; set; }

        [Mapper("ElectricMotorsModel")]
        public string DDJXH { get; set; }

        [Mapper("BatteryCapacity")]
        public string DCRL { get; set; }

        [Mapper("Manufacturer")]
        public string VehicleManuf { get; set; }

        [Mapper("IntakeType")]
        public string AirIn { get; set; }

        [Mapper("RatedSpeed")]
        public string EngineSpeed { get; set; }

        [Mapper("Mileage")]
        public string Odometer { get; set; }

        [Mapper("EVAPControl")]
        public string Tg { get; set; }

        [Mapper("HasTreatmentDevice")]
        public string Hcl { get; set; }

        [Mapper("TreatmentDeviceType")]
        public string HclType { get; set; }

        [Mapper("HasOBD")]
        public string OBD { get; set; }
    }
}
