using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class SettingEntity
    {
        public SettingEntity()
        {
            url = "";
            CompanyId = "";
            ResultPath = "";
            ImagePath = "";
            WriteJson = false ;
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

        public bool UseImgChange_ZJ{ get; set; }

        public string X_AJ { get; set; }

        public string Y_AJ { get; set; }

        public string X_Station { get; set; }

        public string Y_Station { get; set; }

        public string X_ZJ { get; set; }

        public string Y_ZJ { get; set; }

        public ImgTypeEntity[] ImgList { get; set; }

        public DetectLineEntity[] Lines { get; set; }

        public bool DetectLineC { get; set; }

        public string Token { get; set; }
    }

    public class OperatorEntity
    {
        public string Operator { get; set; }

        public bool IsDefault { get; set; }
    }

    public class DetectLineEntity
    {
        public string LocalLine { get; set; }

        public string DetectLine { get; set; }
    }
}
