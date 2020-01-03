using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Dtos
{

    public class ComprehensiveInfo
    {

        public ComprehensiveInfo()
        {
            url = "";
            CompanyId = "";
            ResultPath = "";
            ImagePath = AppDomain.CurrentDomain.BaseDirectory+ @"\SafetyTechnologyImg";
            WriteJson = false;
            ReadJson = false;
            Key = "";
            UserCode = "";
            Company = "";
            PlateColor = "";
            Token = "";
        }

        public string url { get; set; }

        public string CompanyId { get; set; }

        public string Company { get; set; }

        public string ImagePath { get; set; }

        public string ResultPath { get; set; }

        public bool WriteJson { get; set; }

        public bool ReadJson { get; set; }

        public bool RG_Right { get; set; }

        public string Key { get; set; }

        public string UserCode { get; set; }

        public string PlateColor { get; set; }

        public string AdministrativeAera { get; set; }

        public OperatorEntity[] Operators
        {
            get;
            set;
        }

        public bool UseImgChange_AJ { get; set; }

        public bool UseImgChange_Station { get; set; }

        public bool UseImgChange_ZJ { get; set; }

        public int X_AJ { get; set; }

        public int Y_AJ { get; set; }

        public int X_Station { get; set; }

        public int Y_Station { get; set; }

        public int X_ZJ { get; set; }

        public int Y_ZJ { get; set; }

        public ImgTypeEntity[] ImgList { get; set; }

        public DetectLineEntity[] Lines { get; set; }

        public bool DetectLineC { get; set; }

        public string Token { get; set; }
    }
}

    public class OperatorEntity
    {
        public string Operator { get; set; }

        public bool IsDefault { get; set; }

    public override string ToString()
    {
        return Operator ?? "null";
    }
}

    public class DetectLineEntity
    {
        public string LocalLine { get; set; }

        public string DetectLine { get; set; }

        public string Coefficient { get; set; }
    }

    public class ImgTypeEntity
    {
        public string ImgKey { get; set; }

        public string ImgName { get; set; }

        public string ImgType { get; set; }

    }


