using System;
using System.Data;

namespace VehicleManagerSys.Dtos.IVS
{
    public class RESULT_ASM
    {

        public RESULT_ASM()
        {
            ID = "";
            JCLSH = "";
            ASMJCCS = "";
            HC5025JG = "";
            CO5025JG = "";
            NO5025JG = "";
            HC2540JG = "";
            CO2540JG = "";
            NO2540JG = "";
            HC5025XZ = "";
            CO5025XZ = "";
            NO5025XZ = "";
            HC2540XZ = "";
            CO2540XZ = "";
            NO2540XZ = "";
            HC5025_PD = "";
            CO5025_PD = "";
            NO5025_PD = "";
            HC2540_PD = "";
            CO2540_PD = "";
            NO2540_PD = "";
            ASM_5025_PD = "";
            ASM_2540_PD = "";
            ASM_PD = "";
            ASMWD = "";
            ASMDQY = "";
            ASMSD = "";
            ASMYW = "";
            DSYW = "";
            DSHC = "";
            DSCO = "";
            DSHCXZ = "";
            DSCOXZ = "";
            DSHC_PD = "";
            DSCO_PD = "";
            GL5025 = "";
            GL2540 = "";
            CO25025JG = "";
            CO22540JG = "";
            CO2DSJG = "";
            O25025JG = "";
            O22540JG = "";
            O2DSJG = "";
            RPM5025JG = "";
            RPM2540JG = "";
            RPMDSJG = "";
            DSNO = "";
            NMD5025JG = "";
            NMD2540JG = "";
            NMDDSJG = "";
            OBD5025CODE = "";
            OBD2540CODE = "";
            CO25025XZ = "";
            CO22540XZ = "";
            CO2DSZX = "";
            O25025XZ = "";
            O22540XZ = "";
            O2DSXZ = "";
            RPM5025XZ = "";
            RPM2540XZ = "";
            RPMDSXZ = "";
            DSNOXZ = "";
            NMD5025XZ_MAX = "";
            NMD5025XZ_MIN = "";
            NMD2540XZ_MAX = "";
            NMD2540XZ_MIN = "";
            NMDDSXZ_MAX = "";
            NMDDSXZ_MIN = "";
            OBD5025_PD = "";
            OBD2540_PD = "";
            CO25025_PD = "";
            CO22540_PD = "";
            CO2DS_PD = "";
            O25025_PD = "";
            O22540_PD = "";
            O2DS_PD = "";
            RPM5025_PD = "";
            RPM2540_PD = "";
            RPMDS_PD = "";
            DSNO_PD = "";
            NMD5025_PD = "";
            NMD2540_PD = "";
            NMDDS_PD = "";
            ASM_DS_PD = "";
            KSSJ = "";
            JSSJ = "";
            AmbientCO = "";
            AmbientCO2 = "";
            AmbientHC = "";
            AmbientNO = "";
            AmbientO2 = "";
            BackgroundCO = "";
            BackgroundCO2 = "";
            BackgroundHC = "";
            BackgroundNO = "";
            BackgroundO2 = "";
            ResidualHC = "";
            DCF5025 = "";
            Kh5025 = "";
            DCF2540 = "";
            Kh2540 = "";
            Has5025FastPassed = "";
            Has5025Passed = "";
            Has2540FastPassed = "";
            Has2540Passed = "";
            StopReason = "";
            PT_CO5025JG = "";
            PT_HC5025JG = "";
            PT_NO5025JG = "";
            PT_CO2540JG = "";
            PT_HC2540JG = "";
            PT_NO2540JG = "";
            PT_ASM_PD = "";
            THP5025 = "";
            THP2540 = "";
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
        /// 获取或设置ASMJCCS
        /// </summary>
        public string ASMJCCS
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC5025JG
        /// </summary>
        public string HC5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO5025JG
        /// </summary>
        public string CO5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO5025JG
        /// </summary>
        public string NO5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC2540JG
        /// </summary>
        public string HC2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2540JG
        /// </summary>
        public string CO2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO2540JG
        /// </summary>
        public string NO2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC5025XZ
        /// </summary>
        public string HC5025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO5025XZ
        /// </summary>
        public string CO5025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO5025XZ
        /// </summary>
        public string NO5025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC2540XZ
        /// </summary>
        public string HC2540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2540XZ
        /// </summary>
        public string CO2540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO2540XZ
        /// </summary>
        public string NO2540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC5025_PD
        /// </summary>
        public string HC5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO5025_PD
        /// </summary>
        public string CO5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO5025_PD
        /// </summary>
        public string NO5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置HC2540_PD
        /// </summary>
        public string HC2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2540_PD
        /// </summary>
        public string CO2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NO2540_PD
        /// </summary>
        public string NO2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASM_5025_PD
        /// </summary>
        public string ASM_5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASM_2540_PD
        /// </summary>
        public string ASM_2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASM_PD
        /// </summary>
        public string ASM_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASMWD
        /// </summary>
        public string ASMWD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASMDQY
        /// </summary>
        public string ASMDQY
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASMSD
        /// </summary>
        public string ASMSD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASMYW
        /// </summary>
        public string ASMYW
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSYW
        /// </summary>
        public string DSYW
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSHC
        /// </summary>
        public string DSHC
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSCO
        /// </summary>
        public string DSCO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSHCXZ
        /// </summary>
        public string DSHCXZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSCOXZ
        /// </summary>
        public string DSCOXZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSHC_PD
        /// </summary>
        public string DSHC_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSCO_PD
        /// </summary>
        public string DSCO_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置GL5025
        /// </summary>
        public string GL5025
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置GL2540
        /// </summary>
        public string GL2540
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO25025JG
        /// </summary>
        public string CO25025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO22540JG
        /// </summary>
        public string CO22540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2DSJG
        /// </summary>
        public string CO2DSJG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O25025JG
        /// </summary>
        public string O25025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O22540JG
        /// </summary>
        public string O22540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O2DSJG
        /// </summary>
        public string O2DSJG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM5025JG
        /// </summary>
        public string RPM5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM2540JG
        /// </summary>
        public string RPM2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPMDSJG
        /// </summary>
        public string RPMDSJG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSNO
        /// </summary>
        public string DSNO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD5025JG
        /// </summary>
        public string NMD5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD2540JG
        /// </summary>
        public string NMD2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMDDSJG
        /// </summary>
        public string NMDDSJG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置OBD5025CODE
        /// </summary>
        public string OBD5025CODE
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置OBD2540CODE
        /// </summary>
        public string OBD2540CODE
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO25025XZ
        /// </summary>
        public string CO25025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO22540XZ
        /// </summary>
        public string CO22540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2DSZX
        /// </summary>
        public string CO2DSZX
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O25025XZ
        /// </summary>
        public string O25025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O22540XZ
        /// </summary>
        public string O22540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O2DSXZ
        /// </summary>
        public string O2DSXZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM5025XZ
        /// </summary>
        public string RPM5025XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM2540XZ
        /// </summary>
        public string RPM2540XZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPMDSXZ
        /// </summary>
        public string RPMDSXZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSNOXZ
        /// </summary>
        public string DSNOXZ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD5025XZ_MAX
        /// </summary>
        public string NMD5025XZ_MAX
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD5025XZ_MIN
        /// </summary>
        public string NMD5025XZ_MIN
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD2540XZ_MAX
        /// </summary>
        public string NMD2540XZ_MAX
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD2540XZ_MIN
        /// </summary>
        public string NMD2540XZ_MIN
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMDDSXZ_MAX
        /// </summary>
        public string NMDDSXZ_MAX
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMDDSXZ_MIN
        /// </summary>
        public string NMDDSXZ_MIN
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置OBD5025_PD
        /// </summary>
        public string OBD5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置OBD2540_PD
        /// </summary>
        public string OBD2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO25025_PD
        /// </summary>
        public string CO25025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO22540_PD
        /// </summary>
        public string CO22540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置CO2DS_PD
        /// </summary>
        public string CO2DS_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O25025_PD
        /// </summary>
        public string O25025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O22540_PD
        /// </summary>
        public string O22540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置O2DS_PD
        /// </summary>
        public string O2DS_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM5025_PD
        /// </summary>
        public string RPM5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPM2540_PD
        /// </summary>
        public string RPM2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置RPMDS_PD
        /// </summary>
        public string RPMDS_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DSNO_PD
        /// </summary>
        public string DSNO_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD5025_PD
        /// </summary>
        public string NMD5025_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMD2540_PD
        /// </summary>
        public string NMD2540_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置NMDDS_PD
        /// </summary>
        public string NMDDS_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ASM_DS_PD
        /// </summary>
        public string ASM_DS_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置KSSJ
        /// </summary>
        public string KSSJ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置JSSJ
        /// </summary>
        public string JSSJ
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置AmbientCO
        /// </summary>
        public string AmbientCO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置AmbientCO2
        /// </summary>
        public string AmbientCO2
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置AmbientHC
        /// </summary>
        public string AmbientHC
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置AmbientNO
        /// </summary>
        public string AmbientNO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置AmbientO2
        /// </summary>
        public string AmbientO2
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置BackgroundCO
        /// </summary>
        public string BackgroundCO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置BackgroundCO2
        /// </summary>
        public string BackgroundCO2
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置BackgroundHC
        /// </summary>
        public string BackgroundHC
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置BackgroundNO
        /// </summary>
        public string BackgroundNO
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置BackgroundO2
        /// </summary>
        public string BackgroundO2
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置ResidualHC
        /// </summary>
        public string ResidualHC
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DCF5025
        /// </summary>
        public string DCF5025
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Kh5025
        /// </summary>
        public string Kh5025
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置DCF2540
        /// </summary>
        public string DCF2540
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Kh2540
        /// </summary>
        public string Kh2540
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Has5025FastPassed
        /// </summary>
        public string Has5025FastPassed
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Has5025Passed
        /// </summary>
        public string Has5025Passed
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Has2540FastPassed
        /// </summary>
        public string Has2540FastPassed
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置Has2540Passed
        /// </summary>
        public string Has2540Passed
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置StopReason
        /// </summary>
        public string StopReason
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_CO5025JG
        /// </summary>
        public string PT_CO5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_HC5025JG
        /// </summary>
        public string PT_HC5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_NO5025JG
        /// </summary>
        public string PT_NO5025JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_CO2540JG
        /// </summary>
        public string PT_CO2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_HC2540JG
        /// </summary>
        public string PT_HC2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_NO2540JG
        /// </summary>
        public string PT_NO2540JG
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置PT_ASM_PD
        /// </summary>
        public string PT_ASM_PD
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置THP5025
        /// </summary>
        public string THP5025
        {
             get;
             set;
        }

        /// <summary>
        /// 获取或设置THP2540
        /// </summary>
        public string THP2540
        {
             get;
             set;
        }


    }
}
