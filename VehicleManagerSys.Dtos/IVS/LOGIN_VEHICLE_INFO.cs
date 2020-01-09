using Live0xUtils.DbUtils.Attributes;
using System;
using System.Data;

namespace VehicleManagerSys.Dtos.IVS
{
    public class LOGIN_VEHICLE_INFO
    {

        public LOGIN_VEHICLE_INFO()
        {
            VEHICLEID = "";
            HPHM = "";
            HPZL = "";
            HPZLDH = "";
            GLCHPHM = "";
            VIN = "";
            JYLB = "";
            JYLBDH = "";
            FDJH = "";
            FDJXH = "";
            FDJZZCS = "";
            DPXH = "";
            PP = "";
            CLZZCS = "";
            XH = "";
            PPXH = "";
            QDXS = "";
            QDXSDH = "";
            QDZWZ = "";
            ZCZWZ = "";
            QZDZ = "";
            QZDZDH = "";
            YGGSNFKT = "";
            YGGSNFKTDH = "";
            RLLB = "";
            RLLBDH = "";
            RYBH = "";
            GYFS = "";
            GYFSDH = "";
            CCDJRQ = "";
            CCRQ = "";
            ZBZL = "";
            ZZL = "";
            CYS = "";
            CSYS = "";
            CSYSDH = "";
            ZDFS = "";
            ZDFSDH = "";
            CLZL = "";
            CLZLDH = "";
            ZXZXJXS = "";
            ZXZXJXSDH = "";
            ZXZLX = "";
            ZXZLXDH = "";
            ZGSJCS = "";
            EDGL = "";
            EDZS = "";
            EDNJZS = "";
            EDNJ = "";
            EDYH = "";
            JQFS = "";
            JQFSDH = "";
            FDJPL = "";
            FDJGS = "";
            FDJCC = "";
            BSXLX = "";
            BSXLXDH = "";
            CXXL = "";
            CXXLDH = "";
            LJXSLC = "";
            LTQY = "";
            LTGG = "";
            LTSL = "";
            SYXZ = "";
            SYXZDH = "";
            YYZH = "";
            SJDW = "";
            SYR = "";
            LXDH = "";
            LXDZ = "";
            YZBH = "";
            DLRQ = "";
            DLY = "";
            YCY = "";
            WGJYY = "";
            DPJYY = "";
            DTDPJYY = "";
            LSJYY = "";
            SQQZR = "";
            WQCZY = "";
            CSC = "";
            CSK = "";
            CSG = "";
            ZJ = "";
            YZLJ = "";
            EZLJ = "";
            SZLJ = "";
            SIZLJ = "";
            WZLJ = "";
            LZLJ = "";
            YZZLZ = "";
            YZYLZ = "";
            YZZZ = "";
            EZZLZ = "";
            EZYLZ = "";
            EZZZ = "";
            SZZLZ = "";
            SZYLZ = "";
            SZZZ = "";
            SIZZLZ = "";
            SIZYLZ = "";
            SIZZZ = "";
            WZZLZ = "";
            WZYLZ = "";
            WZZZ = "";
            LZZLZ = "";
            LZYLZ = "";
            LZZZ = "";
            CHZHQQK = "";
            CHZHQQKDH = "";
            PQHCLZZ = "";
            PQHCLZZDH = "";
            JZZZWZ = "";
            ZZS = "";
            GLCJCLSH = "";
            GLCHPZL = "";
            GLCHPZLDH = "";
            LWCXWZJL = "";
            SFSQCLC = "";
            GLCJYXM = "";
            LWCXWZJLDH = "";
            HDZH = "";
            EDNJGL = "";
            JYXM_EX = "";
            FWQ_ZYXZ = "";
            DSBH = "";
            JCBSB = "";
            JCBXH = "";
            JCBAZRQ = "";
            JCBDYJSB = "";
            JCBDYJXH = "";
            JCBAZGS = "";
            LWLRLSH = "";
            LWLRHENF = "";
            LTGGLX = "";
            LTGGLXDH = "";
            QDZKZZL = "";
            GCZS = "";
            HCCSXS = "";
            YWLX = "";
            YWLXDH = "";
            KCLXDJ = "";
            YXSSZJ = "";
            GCYYZH = "";
            GCYXSSZJ = "";
            JYXM = "";
            ZJXM = "";
            AJXM = "";
            MTCSFDJSS = "";
            MTCSFDJSSDH = "";
            ZYWLB = "";
            ZYWLBDH = "";
            CLSSLB = "";
            CLSSLBDH = "";
            SYRSFZ = "";
            ZJJYRQ = "";
            BXZZRQ = "";
            JYYXQZ = "";
            CLYTDH = "";
            YTSXDH = "";
            BZZXS = "";
            BZZXSDH = "";
            AJLSH = "";
            ZJLSH = "";
            WQLSH = "";
            MTLSH = "";
            JYXM_LW = "";
            GCPZH = "";
            GCLX = "";
            GCLXDH = "";
            QYCMZZZL = "";
            DCZS = "";
            XZQY = "";
            ZCLBGD = "";
            GCLBGD = "";
            GCCSC = "";
            GCCSK = "";
            GCCSG = "";
            GCBZZXS = "";
            GCBZZXSDH = "";
            ZJCLLX = "";
            ZJCLLXDH = "";
            SFSWPC = "";
            DLYSZH = "";
            SFSGSQC = "";
            CLCCLX = "";
            CLCCLXDH = "";
            DWS = "";
            DCZZ = "";
            SYQK = "";
            SYQKDH = "";
            CPMC = "";
            HPYS = "";
            HPYSDH = "";
            HCCSXSDH = "";
            KCLXDJDH = "";
            KCCC = "";
            GCYXXSZJ = "";
            GCVIN = "";
            GCCCDJRQ = "";
            GCCCRQ = "";
            GCPPXH = "";
            YHXZ = "";
            YHSD = "";
            YDXZ = "";
            HXNBCD = "";
            HXNBKD = "";
            HXNBGD = "";
            SFMJ = "";
            BMJYY = "";
            DGSFZXTS = "";
            DGSFZXTSDH = "";
            ZDJGL = "";
            SZDQLX = "";
            SZDQLXDH = "";
            YYZHCLRQ = "";
            PFLSH = "";
            QDZS = "";
            JYZL = "";
            RYBHDH = "";
            EJWHXLC = "";
            EJWHHTH = "";
            SFSQZ = "";
            SFSWPCDH = "";
            QYCMZZL = "";
            BTGXZ = "";
            BZZWZ = "";
            QLJ = "";
            HLJ = "";
            XJXS = "";
            XJXSDH = "";
            SFMJDH = "";
            SFJMPZ = "";
            DDJXH = "";
            CNZZXH = "";
            DCRL = "";
            IsTrainMode = "";
            IsOBD = "";
            OBDWZ = "";
            IsDPF = "";
            DPFXH = "";
            IsSCR = "";
            SCRXH = "";
            IsABS = "";
            IsTurbo = "";
            ZCLX = "";
            ZCLXDH = "";
            DPHM = "";
            ABS = "";
            TURBO = "";
            QZJCDGGP = "";
            CHZHQXH = "";
            OBDCommCL = "";
            OBDCommCX = "";
            Standard = "";
            VehicleKind = "";
            IsEFI = "";
            IsAsm = "";
            OBDOutlookID = "";
            OutlookID = "";
            GGMINNMD = "";
            GGMAXNMD = "";
            ZYJSXZ = "1.2";
            COXZ = "8.0";
            HCXZ = "1.6";
            HC_NOXZ = "2.9";
            GDSCOXZ = "0.3";
            GDSHCXZ = "50";
            GLKQXSSX = "1.05";
            GLKQXSXX = "0.95";
            DSHCXZ = "80";
            DSCOXZ = "0.6";
            GXSXSXZ = "1.2";
            GLXZ = "0.4";
            ZSXZ = "0.7";
            LGMXZ = "1";
            HSUXZ = "40";
            HC5025XZ = "90";
            CO5025XZ = "0.5";
            NO5025XZ = "700";
            HC2540XZ = "80";
            CO2540XZ = "0.4";
            NO2540XZ = "650";
            NOXZ = "1500";
            StandardType = "1";
        }
        private string HB_NOXZ = "1.3";
        private string HB_ZYJSXZ = "1.2";
        private string HB_COXZ = "8.0";
        private string HB_HCXZ = "1.6";
        private string HB_HC_NOXZ = "2.9";
        private string HB_GDSCOXZ = "0.3";
        private string HB_GDSHCXZ = "50";
        private string HB_GLKQXSSX = "1.05";
        private string HB_GLKQXSXX = "0.95";
        private string HB_DSHCXZ = "80";
        private string HB_DSCOXZ = "0.6";
        private string HB_GXSXSXZ = "1.2";
        private string HB_GLXZ = "0.4";
        private string HB_ZSXZ = "0.7";
        private string HB_LGMXZ = "1";
        private string HB_HSUXZ = "40";
        private string HB_HC5025XZ = "90";
        private string HB_CO5025XZ = "0.5";
        private string HB_NO5025XZ = "700";
        private string HB_HC2540XZ = "80";
        private string HB_CO2540XZ = "0.4";
        private string HB_NO2540XZ = "650";

        /// <summary>
        /// 获取或设置VEHICLEID
        /// </summary>
        public string VEHICLEID
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HPHM
        /// </summary>
        public string HPHM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HPZL
        /// </summary>
        public string HPZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HPZLDH
        /// </summary>
        public string HPZLDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLCHPHM
        /// </summary>
        public string GLCHPHM
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
        /// 获取或设置JYLB
        /// </summary>
        public string JYLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYLBDH
        /// </summary>
        public string JYLBDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJH
        /// </summary>
        public string FDJH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJXH
        /// </summary>
        public string FDJXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJZZCS
        /// </summary>
        public string FDJZZCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPXH
        /// </summary>
        public string DPXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PP
        /// </summary>
        public string PP
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLZZCS
        /// </summary>
        public string CLZZCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XH
        /// </summary>
        public string XH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PPXH
        /// </summary>
        public string PPXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QDXS
        /// </summary>
        public string QDXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QDXSDH
        /// </summary>
        public string QDXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QDZWZ
        /// </summary>
        public string QDZWZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCZWZ
        /// </summary>
        public string ZCZWZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QZDZ
        /// </summary>
        public string QZDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QZDZDH
        /// </summary>
        public string QZDZDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YGGSNFKT
        /// </summary>
        public string YGGSNFKT
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YGGSNFKTDH
        /// </summary>
        public string YGGSNFKTDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置RLLB
        /// </summary>
        public string RLLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置RLLBDH
        /// </summary>
        public string RLLBDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置RYBH
        /// </summary>
        public string RYBH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GYFS
        /// </summary>
        public string GYFS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GYFSDH
        /// </summary>
        public string GYFSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CCDJRQ
        /// </summary>
        public string CCDJRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CCRQ
        /// </summary>
        public string CCRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZBZL
        /// </summary>
        public string ZBZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZZL
        /// </summary>
        public string ZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CYS
        /// </summary>
        public string CYS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSYS
        /// </summary>
        public string CSYS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSYSDH
        /// </summary>
        public string CSYSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDFS
        /// </summary>
        public string ZDFS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDFSDH
        /// </summary>
        public string ZDFSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLZL
        /// </summary>
        public string CLZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLZLDH
        /// </summary>
        public string CLZLDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXZXJXS
        /// </summary>
        public string ZXZXJXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXZXJXSDH
        /// </summary>
        public string ZXZXJXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXZLX
        /// </summary>
        public string ZXZLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZXZLXDH
        /// </summary>
        public string ZXZLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZGSJCS
        /// </summary>
        public string ZGSJCS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDGL
        /// </summary>
        public string EDGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDZS
        /// </summary>
        public string EDZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJZS
        /// </summary>
        public string EDNJZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJ
        /// </summary>
        public string EDNJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDYH
        /// </summary>
        public string EDYH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JQFS
        /// </summary>
        public string JQFS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JQFSDH
        /// </summary>
        public string JQFSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJPL
        /// </summary>
        public string FDJPL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJGS
        /// </summary>
        public string FDJGS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FDJCC
        /// </summary>
        public string FDJCC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BSXLX
        /// </summary>
        public string BSXLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BSXLXDH
        /// </summary>
        public string BSXLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CXXL
        /// </summary>
        public string CXXL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CXXLDH
        /// </summary>
        public string CXXLDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LJXSLC
        /// </summary>
        public string LJXSLC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LTQY
        /// </summary>
        public string LTQY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LTGG
        /// </summary>
        public string LTGG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LTSL
        /// </summary>
        public string LTSL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYXZ
        /// </summary>
        public string SYXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYXZDH
        /// </summary>
        public string SYXZDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYZH
        /// </summary>
        public string YYZH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SJDW
        /// </summary>
        public string SJDW
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYR
        /// </summary>
        public string SYR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LXDH
        /// </summary>
        public string LXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LXDZ
        /// </summary>
        public string LXDZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZBH
        /// </summary>
        public string YZBH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DLRQ
        /// </summary>
        public string DLRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DLY
        /// </summary>
        public string DLY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YCY
        /// </summary>
        public string YCY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WGJYY
        /// </summary>
        public string WGJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPJYY
        /// </summary>
        public string DPJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DTDPJYY
        /// </summary>
        public string DTDPJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LSJYY
        /// </summary>
        public string LSJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SQQZR
        /// </summary>
        public string SQQZR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WQCZY
        /// </summary>
        public string WQCZY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSC
        /// </summary>
        public string CSC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSK
        /// </summary>
        public string CSK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CSG
        /// </summary>
        public string CSG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJ
        /// </summary>
        public string ZJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZLJ
        /// </summary>
        public string YZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZLJ
        /// </summary>
        public string EZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZLJ
        /// </summary>
        public string SZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZLJ
        /// </summary>
        public string SIZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZLJ
        /// </summary>
        public string WZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZLJ
        /// </summary>
        public string LZLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZLZ
        /// </summary>
        public string YZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZYLZ
        /// </summary>
        public string YZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YZZZ
        /// </summary>
        public string YZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZLZ
        /// </summary>
        public string EZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZYLZ
        /// </summary>
        public string EZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EZZZ
        /// </summary>
        public string EZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZLZ
        /// </summary>
        public string SZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZYLZ
        /// </summary>
        public string SZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZZZ
        /// </summary>
        public string SZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZLZ
        /// </summary>
        public string SIZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZYLZ
        /// </summary>
        public string SIZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SIZZZ
        /// </summary>
        public string SIZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZZLZ
        /// </summary>
        public string WZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZYLZ
        /// </summary>
        public string WZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WZZZ
        /// </summary>
        public string WZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZZLZ
        /// </summary>
        public string LZZLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZYLZ
        /// </summary>
        public string LZYLZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LZZZ
        /// </summary>
        public string LZZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHZHQQK
        /// </summary>
        public string CHZHQQK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHZHQQKDH
        /// </summary>
        public string CHZHQQKDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PQHCLZZ
        /// </summary>
        public string PQHCLZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PQHCLZZDH
        /// </summary>
        public string PQHCLZZDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JZZZWZ
        /// </summary>
        public string JZZZWZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZZS
        /// </summary>
        public string ZZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLCJCLSH
        /// </summary>
        public string GLCJCLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLCHPZL
        /// </summary>
        public string GLCHPZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLCHPZLDH
        /// </summary>
        public string GLCHPZLDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LWCXWZJL
        /// </summary>
        public string LWCXWZJL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFSQCLC
        /// </summary>
        public string SFSQCLC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GLCJYXM
        /// </summary>
        public string GLCJYXM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LWCXWZJLDH
        /// </summary>
        public string LWCXWZJLDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HDZH
        /// </summary>
        public string HDZH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EDNJGL
        /// </summary>
        public string EDNJGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYXM_EX
        /// </summary>
        public string JYXM_EX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置FWQ_ZYXZ
        /// </summary>
        public string FWQ_ZYXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DSBH
        /// </summary>
        public string DSBH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBSB
        /// </summary>
        public string JCBSB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBXH
        /// </summary>
        public string JCBXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBAZRQ
        /// </summary>
        public string JCBAZRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBDYJSB
        /// </summary>
        public string JCBDYJSB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBDYJXH
        /// </summary>
        public string JCBDYJXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JCBAZGS
        /// </summary>
        public string JCBAZGS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LWLRLSH
        /// </summary>
        public string LWLRLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LWLRHENF
        /// </summary>
        public string LWLRHENF
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LTGGLX
        /// </summary>
        public string LTGGLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置LTGGLXDH
        /// </summary>
        public string LTGGLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QDZKZZL
        /// </summary>
        public string QDZKZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCZS
        /// </summary>
        public string GCZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HCCSXS
        /// </summary>
        public string HCCSXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YWLX
        /// </summary>
        public string YWLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YWLXDH
        /// </summary>
        public string YWLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置KCLXDJ
        /// </summary>
        public string KCLXDJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YXSSZJ
        /// </summary>
        public string YXSSZJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCYYZH
        /// </summary>
        public string GCYYZH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCYXSSZJ
        /// </summary>
        public string GCYXSSZJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYXM
        /// </summary>
        public string JYXM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJXM
        /// </summary>
        public string ZJXM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AJXM
        /// </summary>
        public string AJXM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MTCSFDJSS
        /// </summary>
        public string MTCSFDJSS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MTCSFDJSSDH
        /// </summary>
        public string MTCSFDJSSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYWLB
        /// </summary>
        public string ZYWLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZYWLBDH
        /// </summary>
        public string ZYWLBDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLSSLB
        /// </summary>
        public string CLSSLB
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLSSLBDH
        /// </summary>
        public string CLSSLBDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYRSFZ
        /// </summary>
        public string SYRSFZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJJYRQ
        /// </summary>
        public string ZJJYRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BXZZRQ
        /// </summary>
        public string BXZZRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYYXQZ
        /// </summary>
        public string JYYXQZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLYTDH
        /// </summary>
        public string CLYTDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YTSXDH
        /// </summary>
        public string YTSXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BZZXS
        /// </summary>
        public string BZZXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BZZXSDH
        /// </summary>
        public string BZZXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置AJLSH
        /// </summary>
        public string AJLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJLSH
        /// </summary>
        public string ZJLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置WQLSH
        /// </summary>
        public string WQLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置MTLSH
        /// </summary>
        public string MTLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYXM_LW
        /// </summary>
        public string JYXM_LW
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCPZH
        /// </summary>
        public string GCPZH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCLX
        /// </summary>
        public string GCLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCLXDH
        /// </summary>
        public string GCLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QYCMZZZL
        /// </summary>
        public string QYCMZZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DCZS
        /// </summary>
        public string DCZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XZQY
        /// </summary>
        public string XZQY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCLBGD
        /// </summary>
        public string ZCLBGD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCLBGD
        /// </summary>
        public string GCLBGD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCCSC
        /// </summary>
        public string GCCSC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCCSK
        /// </summary>
        public string GCCSK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCCSG
        /// </summary>
        public string GCCSG
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCBZZXS
        /// </summary>
        public string GCBZZXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCBZZXSDH
        /// </summary>
        public string GCBZZXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJCLLX
        /// </summary>
        public string ZJCLLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZJCLLXDH
        /// </summary>
        public string ZJCLLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFSWPC
        /// </summary>
        public string SFSWPC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DLYSZH
        /// </summary>
        public string DLYSZH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFSGSQC
        /// </summary>
        public string SFSGSQC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLCCLX
        /// </summary>
        public string CLCCLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CLCCLXDH
        /// </summary>
        public string CLCCLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DWS
        /// </summary>
        public string DWS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置单车轴重
        /// </summary>
        public string DCZZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYQK
        /// </summary>
        public string SYQK
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SYQKDH
        /// </summary>
        public string SYQKDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CPMC
        /// </summary>
        public string CPMC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HPYS
        /// </summary>
        public string HPYS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HPYSDH
        /// </summary>
        public string HPYSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HCCSXSDH
        /// </summary>
        public string HCCSXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置KCLXDJDH
        /// </summary>
        public string KCLXDJDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置KCCC
        /// </summary>
        public string KCCC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCYXXSZJ
        /// </summary>
        public string GCYXXSZJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCVIN
        /// </summary>
        public string GCVIN
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCCCDJRQ
        /// </summary>
        public string GCCCDJRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCCCRQ
        /// </summary>
        public string GCCCRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GCPPXH
        /// </summary>
        public string GCPPXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YHXZ
        /// </summary>
        public string YHXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YHSD
        /// </summary>
        public string YHSD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YDXZ
        /// </summary>
        public string YDXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXNBCD
        /// </summary>
        public string HXNBCD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXNBKD
        /// </summary>
        public string HXNBKD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HXNBGD
        /// </summary>
        public string HXNBGD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFMJ
        /// </summary>
        public string SFMJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BMJYY
        /// </summary>
        public string BMJYY
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DGSFZXTS
        /// </summary>
        public string DGSFZXTS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DGSFZXTSDH
        /// </summary>
        public string DGSFZXTSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZDJGL
        /// </summary>
        public string ZDJGL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZDQLX
        /// </summary>
        public string SZDQLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SZDQLXDH
        /// </summary>
        public string SZDQLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置YYZHCLRQ
        /// </summary>
        public string YYZHCLRQ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置PFLSH
        /// </summary>
        public string PFLSH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QDZS
        /// </summary>
        public string QDZS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置JYZL
        /// </summary>
        public string JYZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置RYBHDH
        /// </summary>
        public string RYBHDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EJWHXLC
        /// </summary>
        public string EJWHXLC
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置EJWHHTH
        /// </summary>
        public string EJWHHTH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFSQZ
        /// </summary>
        public string SFSQZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFSWPCDH
        /// </summary>
        public string SFSWPCDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QYCMZZL
        /// </summary>
        public string QYCMZZL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BTGXZ
        /// </summary>
        public string BTGXZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置BZZWZ
        /// </summary>
        public string BZZWZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QLJ
        /// </summary>
        public string QLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置HLJ
        /// </summary>
        public string HLJ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXS
        /// </summary>
        public string XJXS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置XJXSDH
        /// </summary>
        public string XJXSDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFMJDH
        /// </summary>
        public string SFMJDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SFJMPZ
        /// </summary>
        public string SFJMPZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DDJXH
        /// </summary>
        public string DDJXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CNZZXH
        /// </summary>
        public string CNZZXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DCRL
        /// </summary>
        public string DCRL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsTrainMode
        /// </summary>
        public string IsTrainMode
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsOBD
        /// </summary>
        public string IsOBD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置OBDWZ
        /// </summary>
        public string OBDWZ
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsDPF
        /// </summary>
        public string IsDPF
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPFXH
        /// </summary>
        public string DPFXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsSCR
        /// </summary>
        public string IsSCR
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置SCRXH
        /// </summary>
        public string SCRXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsABS
        /// </summary>
        public string IsABS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsTurbo
        /// </summary>
        public string IsTurbo
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCLX
        /// </summary>
        public string ZCLX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ZCLXDH
        /// </summary>
        public string ZCLXDH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置DPHM
        /// </summary>
        public string DPHM
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置ABS
        /// </summary>
        public string ABS
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置TURBO
        /// </summary>
        public string TURBO
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置QZJCDGGP
        /// </summary>
        public string QZJCDGGP
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置CHZHQXH
        /// </summary>
        public string CHZHQXH
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置OBDCommCL
        /// </summary>
        public string OBDCommCL
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置OBDCommCX
        /// </summary>
        public string OBDCommCX
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置Standard
        /// </summary>
        public string Standard
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置VehicleKind
        /// </summary>
        public string VehicleKind
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsEFI
        /// </summary>
        public string IsEFI
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置IsAsm
        /// </summary>
        public string IsAsm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置OBDOutlookID
        /// </summary>
        public string OBDOutlookID
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置OutlookID
        /// </summary>
        public string OutlookID
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GGMINNMD
        /// </summary>
        public string GGMINNMD
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置GGMAXNMD
        /// </summary>
        public string GGMAXNMD
        {
            get;
            set;
        }

        #region 限值
        [IgField]
        public string ZYJSXZ { get; set; }

        [IgField]
        public string COXZ { get; set; }

        [IgField]
        public string HCXZ { get; set; }

        [IgField]
        public string NOXZ { get; set; }

        [IgField]
        public string HC_NOXZ { get; set; }

        [IgField]
        public string GDSCOXZ { get; set; }

        [IgField]
        public string GDSHCXZ { get; set; }
        [IgField]
        public string GLKQXSSX { get; set; }

        [IgField]
        public string GLKQXSXX { get; set; }
        [IgField]
        public string GXSXSXZ { get; set; }
        [IgField]
        public string GLXZ { get; set; }
        [IgField]
        public string ZSXZ { get; set; }
        [IgField]
        public string HC5025XZ { get; set; }
        [IgField]
        public string CO5025XZ { get; set; }
        [IgField]
        public string NO5025XZ { get; set; }
        [IgField]
        public string HC2540XZ { get; set; }
        [IgField]
        public string CO2540XZ { get; set; }
        [IgField]
        public string NO2540XZ { get; set; }
        [IgField]
        public string DSHCXZ { get; set; }
        [IgField]
        public string DSCOXZ { get; set; }
        [IgField]
        public string LGMXZ { get; set; }
        [IgField]
        public string HSUXZ { get; set; }
        [IgField]
        public string StandardType { get; set; }

        [IgnoreField]
        public string StandardText { get; set; }
        #endregion
    }
}
