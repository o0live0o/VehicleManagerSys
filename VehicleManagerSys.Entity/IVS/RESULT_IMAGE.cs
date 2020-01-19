using System;
using System.Data;

namespace VehicleManagerSys.Entity.IVS
{
    public class RESULT_IMAGE
    {

        public RESULT_IMAGE()
        {
            ID = "";
            JCLSH = "";

        }

        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置JCLSH
        /// </summary>
        public string JCLSH
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Lamp_Image
        /// </summary>
        public byte[] Lamp_Image
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Brake_Image
        /// </summary>
        public byte[] Brake_Image
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Power_Image
        /// </summary>
        public byte[] Power_Image
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Chasiss_Image
        /// </summary>
        public byte[] Chasiss_Image
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Appearance_Image
        /// </summary>
        public byte[] Appearance_Image
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置WKCC_IMAGE1
        /// </summary>
        public byte[] WKCC_IMAGE1
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置WKCC_IMAGE2
        /// </summary>
        public byte[] WKCC_IMAGE2
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置WKCC_IMAGE3
        /// </summary>
        public byte[] WKCC_IMAGE3
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置WKCC_IMAGE4
        /// </summary>
        public byte[] WKCC_IMAGE4
        {
             get;
             set;
        }


    }
}
