using CI.UIComponents.Helper;
using Live0xUtils.DbUtils.SqlServer;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleManagerSys.Common;
using VehicleManagerSys.Core.ExtendMethods;
using VehicleManagerSys.Dtos.ComprehensiveDtos;
using VehicleManagerSys.Entity.IVS;


namespace VehicleManagerSys.Core.Services
{
    public class ComprehensiveUploadService
    {
        public delegate void LogDelegate(string msg, Color color);

        public LOGIN_VEHICLE_INFO info = null;

        private static MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
       
        public RESULT_SPEAKER m_RESULT_SPEAKER = null;
        public RESULT_SIDESLIP_ZJ m_RESULT_SIDESLIP_ZJ = null;
        public RESULT_ROAD m_RESULT_ROAD = null;
        public RESULT_SUSPENSION m_RESULT_SUSPENSION = null;
        public RESULT_IMAGE m_RESULT_IMAGE = null;
        public LOGIN_VEHICLE_INFO m_LOGIN_VEHICLE_INFO = null;
        public RESULT_CHASISS_MANUAL_ZJ m_RESULT_CHASISS_MANUAL_ZJ = null;
        public RESULT_SPEED_ZJ m_RESULT_SPEED_ZJ = null;
        public RESULT_VEHICLE_INFO m_RESULT_VEHICLE_INFO = null;
        public RESULT_DPCG m_RESULT_DPCG = null;
        public RESULT_BRAKE_ZJ m_RESULT_BRAKE_ZJ = null;
        public RESULT_SDS m_RESULT_SDS = null;
        public RESULT_ASM m_RESULT_ASM = null;
        public RESULT_VMAS m_RESULT_VMAS = null;
        public RESULT_ZYJS m_RESULT_ZYJS = null;
        public RESULT_LD m_RESULT_LD = null;
        public RESULT_LAMP_ZJ m_RESULT_LAMP_ZJ = null;

        private string DetectItem = "";
        private List<string> DetectItemList = new List<string>();
        private List<string> KeyItemList = new List<string>();
        private List<string> NormalItemList = new List<string>();
        private List<string> LvItemList = new List<string>();
        private bool IsHC = false;
        private bool IsNew = false;
        private string egt = "≥";
        private string elt = "≤";
        private string L = "左";
        private string R = "右";

        private string m_Base64 = "";

        public ComprehensiveUploadService(RESULT_VEHICLE_INFO resultInfo)
        {
               m_RESULT_VEHICLE_INFO = CloneHelper.Clone(resultInfo) as RESULT_VEHICLE_INFO;
        }


        public void InitData(LogDelegate logDelegate)
        {
            if (m_RESULT_VEHICLE_INFO != null)
            {
                Hashtable hashtable = new Hashtable();
                string infoSql = "SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM = @HPHM AND HPZLDH = @HPZLDH AND VIN = @VIN";
                hashtable.Add("HPHM", m_RESULT_VEHICLE_INFO.HPHM);
                hashtable.Add("HPZLDH", m_RESULT_VEHICLE_INFO.HPZLDH);
                hashtable.Add("VIN", m_RESULT_VEHICLE_INFO.VIN);
                m_LOGIN_VEHICLE_INFO = _mssqlHelper.Query<LOGIN_VEHICLE_INFO>(infoSql, hashtable);
                if (m_LOGIN_VEHICLE_INFO == null)
                {
                    logDelegate.BeginInvoke("获取基本信息失败！",Color.Red,null,null);
                    return;
                }
                if (!m_LOGIN_VEHICLE_INFO.CLZLDH.Contains("K") || m_LOGIN_VEHICLE_INFO.CLZLDH == "B2K")
                {
                    IsHC = true;
                }

                if (m_RESULT_VEHICLE_INFO.JCLSH.Contains("-"))
                {
                    List<string> jclshs = GetAllTestNo();
                    string sql = "SELECT * FROM {0} WHERE JCLSH IN ({1}) ORDER BY ID ASC";

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < jclshs.Count; i++)
                    {
                        if (sb.Length.Equals(0))
                            sb.Append("'" + jclshs[i] + "'");
                        else
                            sb.Append(",'" + jclshs[i] + "'");
                    }
                    string jclsh = sb.ToString();
                    TaskFactory taskFactory = Task.Factory;
                    List<Task> taskList = new List<Task>();

                    taskList.Add(taskFactory.StartNew(()=> {
                        string searchSql = string.Format(sql, "RESULT_VEHICLE_INFO", jclsh);
                        List<RESULT_VEHICLE_INFO> list = _mssqlHelper.QueryList<RESULT_VEHICLE_INFO>(searchSql, null).ToList();
                        List<string> items = new List<string>();
                        if (list != null && list.Count > 0)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                string[] s = list[i].JYXM.Split(',');
                                if (s != null && s.Length > 0)
                                {
                                    for (int j = 0; j < s.Length; j++)
                                    {
                                        DetectItemList.Add(s[j]);
                                        if (!items.Contains(s[j]))
                                            items.Add(s[j]);
                                    }
                                }
                            }
                        }
                        DetectItem = string.Join(",",items.ToArray());
                        logDelegate.BeginInvoke("检验项目:" + DetectItem, Color.Red, null, null);
                    }));

                    //制动
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_BRAKE_ZJ", jclsh);
                        List<RESULT_BRAKE_ZJ> list = _mssqlHelper.QueryList<RESULT_BRAKE_ZJ>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_BRAKE_ZJ = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_BRAKE_ZJ, list[i]);
                            }
                        }
                    }));
                    //灯光
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_LAMP_ZJ", jclsh);
                        List<RESULT_LAMP_ZJ> list = _mssqlHelper.QueryList<RESULT_LAMP_ZJ>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_LAMP_ZJ = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_LAMP_ZJ, list[i]);
                            }
                        }
                    }));
                    //侧
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_SIDESLIP_ZJ", jclsh);
                        List<RESULT_SIDESLIP_ZJ> list = _mssqlHelper.QueryList<RESULT_SIDESLIP_ZJ>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_SIDESLIP_ZJ = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_SIDESLIP_ZJ, list[i]);
                            }
                        }
                    }));
                    //悬架
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_SUSPENSION", jclsh);
                        List<RESULT_SUSPENSION> list = _mssqlHelper.QueryList<RESULT_SUSPENSION>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_SUSPENSION = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_SUSPENSION, list[i]);
                            }
                        }
                    }));
                    //声级
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_SPEAKER", jclsh);
                        List<RESULT_SPEAKER> list = _mssqlHelper.QueryList<RESULT_SPEAKER>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_SPEAKER = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_SPEAKER, list[i]);
                            }
                        }
                    }));
                    //底盘
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_CHASISS_MANUAL_ZJ", jclsh);
                        List<RESULT_CHASISS_MANUAL_ZJ> list = _mssqlHelper.QueryList<RESULT_CHASISS_MANUAL_ZJ>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_CHASISS_MANUAL_ZJ = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_CHASISS_MANUAL_ZJ, list[i]);
                            }
                        }
                    }));
                    //动力性 油耗
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_DPCG", jclsh);
                        List<RESULT_DPCG> list = _mssqlHelper.QueryList<RESULT_DPCG>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_DPCG = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_DPCG, list[i]);
                            }
                        }
                    }));
                    //速度
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_SPEED_ZJ", jclsh);
                        List<RESULT_SPEED_ZJ> list = _mssqlHelper.QueryList<RESULT_SPEED_ZJ>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_SPEED_ZJ = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_SPEED_ZJ, list[i]);
                            }
                        }
                    }));
                    //LD
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_LD", jclsh);
                        List<RESULT_LD> list = _mssqlHelper.QueryList<RESULT_LD>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_LD = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_LD, list[i]);
                            }
                        }
                    }));
                    //ASM
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_ASM", jclsh);
                        List<RESULT_ASM> list = _mssqlHelper.QueryList<RESULT_ASM>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_ASM = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_ASM, list[i]);
                            }
                        }
                    }));
                    //VMAS
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_VMAS", jclsh);
                        List<RESULT_VMAS> list = _mssqlHelper.QueryList<RESULT_VMAS>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_VMAS = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_VMAS, list[i]);
                            }
                        }
                    }));
                    //SDS
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_SDS", jclsh);
                        List<RESULT_SDS> list = _mssqlHelper.QueryList<RESULT_SDS>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_SDS = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_SDS, list[i]);
                            }
                        }
                    }));
                    //ZYJS
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_ZYJS", jclsh);
                        List<RESULT_ZYJS> list = _mssqlHelper.QueryList<RESULT_ZYJS>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_ZYJS = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_ZYJS, list[i]);
                            }
                        }
                    }));
                    //工位照片
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        string searchSql = string.Format(sql, "RESULT_IMAGE", jclsh);
                        List<RESULT_IMAGE> list = _mssqlHelper.QueryList<RESULT_IMAGE>(searchSql, null).ToList();
                        if (list != null && list.Count > 0)
                        {
                            m_RESULT_IMAGE = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                Tools.MergeEntity(m_RESULT_IMAGE, list[i]);
                            }
                        }
                    }));
                    Task.WaitAll(taskList.ToArray());
                }
                else
                {
                    //TODO log 检测流水号格式不正确
                }
            }
        }

        //上传信息
        public void ShareDetectInfo(LogDelegate logDelegate, bool UseSafetyTechnologyResult)
        {
            try
            {
                if (m_RESULT_VEHICLE_INFO == null || string.IsNullOrEmpty(m_RESULT_VEHICLE_INFO.JCLSH))
                {
                    logDelegate.BeginInvoke("没有找到对应的信息!", Color.Red, null, null);
                    return;
                }

                ShareDetectInfo record = new ShareDetectInfo();
                Dictionary<object, object> dic = new Dictionary<object, object>();

                IsNew = GetIsNewVehicle(m_RESULT_VEHICLE_INFO.CCDJRQ, m_RESULT_VEHICLE_INFO.CLXXSJ);
                if(!IsNew)
                    logDelegate.BeginInvoke("在用车", Color.Blue, null, null);
                else
                    logDelegate.BeginInvoke("新车", Color.Blue, null, null);
                logDelegate.BeginInvoke($"出厂日期: {m_RESULT_VEHICLE_INFO.CCDJRQ}检测日期:{m_RESULT_VEHICLE_INFO.CLXXSJ}", Color.Blue, null, null);
                #region 基本信息
                record.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                record.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                record.dsName = AppHelper.ComprehensiveSetting.Company;
                record.detectType = "1"; //本地检验类别代号转换
                record.detectDate = m_RESULT_VEHICLE_INFO.CLXXSJ; //(YYYY-MM-DD  hh:mm:ss)
                record.client = m_LOGIN_VEHICLE_INFO.SYR;//委托人
                record.vehicleNo = m_LOGIN_VEHICLE_INFO.HPHM;
                record.plateColorCode = m_LOGIN_VEHICLE_INFO.HPYS.To_Net_HPYS();
                record.vinNo = m_LOGIN_VEHICLE_INFO.VIN;
                record.vehicleType = m_LOGIN_VEHICLE_INFO.CLZLDH;  //车辆类型
                record.engineNo = m_LOGIN_VEHICLE_INFO.FDJH;
                record.travelMileage = m_LOGIN_VEHICLE_INFO.LJXSLC;
                record.fuelType = m_LOGIN_VEHICLE_INFO.RLLBDH;
                record.steeringAxleAmount = m_LOGIN_VEHICLE_INFO.ZXZLXDH.To_ZXZSL().ToString();//转向轴数            
                record.detectLine = m_RESULT_VEHICLE_INFO.JCXH.ToString().To_Net_DetectLine();//m_RESULT_VEHICLE_INFO.JCXH.ToString();            
                record.busiType = m_LOGIN_VEHICLE_INFO.YWLX;
                record.transCertificateCode = m_LOGIN_VEHICLE_INFO.YYZH;
                record.trailerVehicleNo = m_LOGIN_VEHICLE_INFO.GLCHPHM;
                record.trailerVehicleType = "";  //全挂 半挂
                record.productionDate = m_LOGIN_VEHICLE_INFO.CCRQ.To_Net_Date();
                record.registDate = m_LOGIN_VEHICLE_INFO.CCDJRQ.To_Net_Date();
                record.vehicleBrandModel = m_LOGIN_VEHICLE_INFO.XH;
                record.vehicleBodyColor = m_LOGIN_VEHICLE_INFO.CSYS.To_Net_CSYS();
                record.driveType = m_LOGIN_VEHICLE_INFO.QDXS;
                record.vehicleSuspensionForm = m_LOGIN_VEHICLE_INFO.ZXZXJXS.Replace("悬架","");
                //record.trailerVehicleAxleAmount = m_LOGIN_VEHICLE_INFO.GCZS;

                if (!record.fuelType.Contains("B"))
                {
                    record.ratedTorque = m_LOGIN_VEHICLE_INFO.EDNJ;
                    record.ratedSpeedOfIgnit = m_LOGIN_VEHICLE_INFO.EDZS;
                    logDelegate.BeginInvoke("汽油", Color.Black, null, null);
                }
                else
                {
                    record.compressIgnitEnginePower = m_LOGIN_VEHICLE_INFO.EDGL;
                    logDelegate.BeginInvoke("柴油", Color.Black, null, null);
                }

                record.driveWheelModel = m_LOGIN_VEHICLE_INFO.LTGG;
                record.totalWeight = m_LOGIN_VEHICLE_INFO.ZZL;
                record.vehicleHeight = m_LOGIN_VEHICLE_INFO.CSG;
                record.frontTrack = m_RESULT_VEHICLE_INFO.YZLJ;

                if (record.vehicleType.Contains("K"))
                {
                    record.vehicleLength = m_LOGIN_VEHICLE_INFO.CSC;
                    record.busTypeLevel = m_LOGIN_VEHICLE_INFO.KCLXDJ.To_Net_KCLXDJ();
                }
                record.truckBodyType = m_LOGIN_VEHICLE_INFO.HCCSXS;
                record.driveAxleAmount = m_LOGIN_VEHICLE_INFO.QDZS;
                record.driveAxleLoadMass = m_LOGIN_VEHICLE_INFO.QDZKZZL; //驱动轴空载质量（kg)
                record.totalWeightOfTractor = "";// m_RESULT_VEHICLE_INFO.QYCMZZZL;
                record.shaftForm = m_LOGIN_VEHICLE_INFO.BZZXSDH.GetBZZ(m_RESULT_VEHICLE_INFO.CLZLDH);  //"无";// m_RESULT_VEHICLE_INFO.BZZXSDH == "0" ? "无" : ""; //特殊格式

                record.lampSystem = m_LOGIN_VEHICLE_INFO.QZDZ;
                record.seatCount = m_RESULT_VEHICLE_INFO.CYS;//座位数
                record.mainVehicleAxleAmount = m_LOGIN_VEHICLE_INFO.ZZS;//主车轴数
                record.overallSize = string.Format("{0}×{1}×{2}", m_LOGIN_VEHICLE_INFO.CSC, m_LOGIN_VEHICLE_INFO.CSK, m_LOGIN_VEHICLE_INFO.CSG);


                // record.overallSizeTrailer = string.Format("{0}×{1}×{2}", m_RESULT_VEHICLE_INFO.GCCSC, m_RESULT_VEHICLE_INFO.GCCSK, m_RESULT_VEHICLE_INFO.GCCSG);

                record.farLightCanAdjust = m_LOGIN_VEHICLE_INFO.YGGSNFKT;
                record.parkAxle = (!string.IsNullOrEmpty(m_LOGIN_VEHICLE_INFO.ZCZWZ) && m_LOGIN_VEHICLE_INFO.ZCZWZ.Substring(m_LOGIN_VEHICLE_INFO.ZCZWZ.Length - 1, 1).Equals(",")) ? m_LOGIN_VEHICLE_INFO.ZCZWZ.Substring(0, m_LOGIN_VEHICLE_INFO.ZCZWZ.Length - 1) : m_LOGIN_VEHICLE_INFO.ZCZWZ;
                record.carriageSsideboardHeight = m_LOGIN_VEHICLE_INFO.ZCLBGD;
                record.ssideboardHeightTrailer = m_LOGIN_VEHICLE_INFO.GCLBGD;
                record.detectTotalCount = m_RESULT_VEHICLE_INFO.JCCS.ToString();
                record.entryStaff = m_RESULT_VEHICLE_INFO.DLY;
                record.exhaustInspector = m_RESULT_VEHICLE_INFO.WQCZY;
                record.leadStaff = m_RESULT_VEHICLE_INFO.YCY;
                DetectLineEntity detectLineEntity = AppHelper.ComprehensiveSetting.Lines.Where(p => p.LocalLine.Equals(m_RESULT_VEHICLE_INFO.JCXH)).FirstOrDefault();
                if (detectLineEntity != null)
                {
                    record.brakeTestRigCoefficient = detectLineEntity.Coefficient;
                }
                #region 动力性 Power
                if (!IsNew && DetectItem.Contains("G0") && m_RESULT_DPCG != null)
                {

                    power powerEntity = new power();

                    if (string.IsNullOrEmpty(m_RESULT_DPCG.JCLSH) == false)
                    {
                        //从底盘测功获取温湿度大气压
                        record.atmoTemp = m_RESULT_DPCG.DPCGWD;
                        record.atmoPressure = m_RESULT_DPCG.DPCGDQY;
                        record.atmoHumidity = m_RESULT_DPCG.DPCGSD;

                        powerEntity.standardPower = m_RESULT_DPCG.GK_DBGL;
                        powerEntity.ratedSpeed = m_RESULT_DPCG.GK_EDCS;
                        powerEntity.loadingForce = m_RESULT_DPCG.GK_JZL;
                        powerEntity.steadySpeed = m_RESULT_DPCG.GK_WDCS;
                        powerEntity.evaluate = m_RESULT_DPCG.GK_PD.To_Net_ZJPD();

                        powerEntity.count = DetectItemList.Count(p => p.Equals("G0")).ToString();
                        if (powerEntity.evaluate == "0")
                        {
                            powerEntity.evaluate = "1";
                        }
                        record.power = powerEntity;
                    }
                }
                else
                {
                    if (DetectItem.Contains("G0"))
                    {
                        power powerEntity = new power();
                        powerEntity.evaluate = "1";
                        record.power = powerEntity;
                    }
                }
                #endregion

                #region 燃料经济性
                if (!IsNew && DetectItem.Contains("G5") && m_RESULT_DPCG != null)
                {
                    fuelEconomy fuelEntity = new fuelEconomy();
                    if (string.IsNullOrEmpty(m_RESULT_DPCG.JCLSH) == false)
                    {
                        fuelEntity.speedFuelPerHundredKm = m_RESULT_DPCG.YH_BZ;
                        fuelEntity.measuredValue = m_RESULT_DPCG.YH_SCZ;
                        fuelEntity.evaluate = m_RESULT_DPCG.YH_PD.To_Net_ZJPD();
                        fuelEntity.count = DetectItemList.Count(p => p.Equals("G5")).ToString();
                    }
                    record.fuelEconomy = fuelEntity;
                }
                else
                {
                    if (DetectItem.Contains("G5"))
                    {
                        fuelEconomy fuelEntity = new fuelEconomy();
                        fuelEntity.evaluate = "0";
                        record.fuelEconomy = fuelEntity;
                    }
                }
                #endregion

                if (!IsHC || !UseSafetyTechnologyResult)
                {
                    #region 制动

                    Dictionary<string, object> dicBrake = new Dictionary<string, object>();
                    List<object> listBrake = new List<object>();

                    #region 制动性 initData  单位 daN

                    record.brake = new brake();
                    List<object> list2 = new List<object>();
                    List<initData> listInitData = new List<initData>();

                    if (m_RESULT_BRAKE_ZJ != null)
                    {
                        if (DetectItem.Contains("B1"))
                        {
                            initData oneInitData = new initData();
                            oneInitData.axleSerialNo = "1";
                            oneInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.YZZLZ;
                            oneInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.YZYLZ;
                            oneInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTYZZZ;
                            oneInitData.leftDynamicWheelLoad = m_RESULT_BRAKE_ZJ.YZZDTLH;
                            oneInitData.rightDynamicWheelLoad = m_RESULT_BRAKE_ZJ.YZYDTLH;
                            oneInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.YZZZDZDL;
                            oneInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.YZYZDZDL;
                            oneInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.YZZSZDL;
                            oneInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.YZYSZDL;
                            oneInitData.count = m_RESULT_BRAKE_ZJ.ZDYZJCCS;
                            listInitData.Add(oneInitData);
                        }
                        if (DetectItem.Contains("B2"))
                        {
                            initData twoInitData = new initData();
                            twoInitData.axleSerialNo = "2";
                            twoInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.EZZLZ;
                            twoInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.EZYLZ;
                            twoInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTEZZZ;
                            twoInitData.leftDynamicWheelLoad = m_RESULT_BRAKE_ZJ.EZZDTLH;
                            twoInitData.rightDynamicWheelLoad = m_RESULT_BRAKE_ZJ.EZYDTLH;
                            twoInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.EZZZDZDL;
                            twoInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.EZYZDZDL;
                            twoInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.EZZSZDL;
                            twoInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.EZYSZDL;
                            twoInitData.count = m_RESULT_BRAKE_ZJ.ZDEZJCCS;
                            listInitData.Add(twoInitData);
                        }
                        if (DetectItem.Contains("B3"))
                        {
                            initData threeInitData = new initData();
                            threeInitData.axleSerialNo = "3";
                            threeInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.SZZLZ;
                            threeInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.SZYLZ;
                            threeInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTSZZZ;
                            threeInitData.leftDynamicWheelLoad = "";
                            threeInitData.rightDynamicWheelLoad = "";
                            threeInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.SZZZDZDL;
                            threeInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.SZYZDZDL;
                            threeInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.SZZSZDL;
                            threeInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.SZYSZDL;
                            threeInitData.count = m_RESULT_BRAKE_ZJ.ZDSZJCCS;
                            listInitData.Add(threeInitData);
                        }
                        if (DetectItem.Contains("B4"))
                        {
                            initData fourInitData = new initData();
                            fourInitData.axleSerialNo = "4";
                            fourInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.SIZZLZ;
                            fourInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.SIZYLZ;
                            fourInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTSIZZZ;
                            fourInitData.leftDynamicWheelLoad = "";
                            fourInitData.rightDynamicWheelLoad = "";
                            fourInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.SIZZZDZDL;
                            fourInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.SIZYZDZDL;
                            fourInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.SIZZSZDL;
                            fourInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.SIZYSZDL;
                            fourInitData.count = m_RESULT_BRAKE_ZJ.ZDSIZJCCS;
                            listInitData.Add(fourInitData);
                        }
                        if (DetectItem.Contains("B5"))
                        {
                            initData fiveInitData = new initData();
                            fiveInitData.axleSerialNo = "5";
                            fiveInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.WZZLZ;
                            fiveInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.WZYLZ;
                            fiveInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTWZZZ;
                            fiveInitData.leftDynamicWheelLoad = "";
                            fiveInitData.rightDynamicWheelLoad = "";
                            fiveInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.WZZZDZDL;
                            fiveInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.WZYZDZDL;
                            fiveInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.WZZSZDL;
                            fiveInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.WZYSZDL;
                            fiveInitData.count = m_RESULT_BRAKE_ZJ.ZDWZJCCS;
                            listInitData.Add(fiveInitData);
                        }
                        if (DetectItem.Contains("B6"))
                        {
                            initData sixInitData = new initData();
                            sixInitData.axleSerialNo = "6";
                            sixInitData.leftHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.LZZLZ;
                            sixInitData.rightHorizontalLoadWheel = m_RESULT_BRAKE_ZJ.LZYLZ;
                            sixInitData.axleLoadOfCompoundTable = m_RESULT_BRAKE_ZJ.FHTLZZZ;
                            sixInitData.leftDynamicWheelLoad = "";
                            sixInitData.rightDynamicWheelLoad = "";
                            sixInitData.leftDriveBrakeForce = m_RESULT_BRAKE_ZJ.LZZZDZDL;
                            sixInitData.rightDriveBrakeForce = m_RESULT_BRAKE_ZJ.LZYZDZDL;
                            sixInitData.leftParkBrakeForce = m_RESULT_BRAKE_ZJ.LZZSZDL;
                            sixInitData.rightParkBrakeForce = m_RESULT_BRAKE_ZJ.LZYSZDL;
                            sixInitData.count = m_RESULT_BRAKE_ZJ.ZDLZJCCS;
                            listInitData.Add(sixInitData);
                        }

                        record.brake.initData = listInitData;
                    }


                    #endregion

                    #region 整车 wholeVehicle
                    record.brake.wholeVehicle = new wholeVehicle();
                    if (string.IsNullOrEmpty(m_RESULT_BRAKE_ZJ.JCLSH) == false)
                    {

                        Dictionary<string, object> dic3 = new Dictionary<string, object>();
                        #region 单车(singleVehicle)
                        singleVehicle singleCar = new singleVehicle();
                        singleCar.horizontalWeight = m_RESULT_BRAKE_ZJ.ZCZZ;
                        singleCar.wholeVehicleBrakeRate = m_RESULT_BRAKE_ZJ.ZCZDLV;
                        singleCar.parkBrakeRate = m_RESULT_BRAKE_ZJ.ZCSZDLV;
                        singleCar.count = m_RESULT_BRAKE_ZJ.ZDSZDJCCS;
                        string szdl_pd = m_RESULT_BRAKE_ZJ.SZDLV_PD.To_Net_ZJPD();
                        string zczdl_pd = m_RESULT_BRAKE_ZJ.ZCZDLV_PD.To_Net_ZJPD();
                        singleCar.evaluate = (szdl_pd == "-1" || zczdl_pd == "-1") ? "-1" : "0";
                        record.brake.wholeVehicle.singleVehicle = singleCar;
                        #endregion

                        if (false)
                        {
                            #region 汽车列车1(vehicleSerial1)
                            vehicleSerial1 oneSerial = new vehicleSerial1();
                            oneSerial.horizontalWeight = "";
                            oneSerial.vehicleBrakeRateTractor = m_RESULT_BRAKE_ZJ.ZCZDLV;
                            oneSerial.vehicleBrakeRateTrailer = "";
                            oneSerial.parkBrakeRate = "";
                            oneSerial.brakeCoordinateTime = "";
                            oneSerial.evaluate = m_RESULT_BRAKE_ZJ.QCLCZC_PD.To_Net_ZJPD();
                            record.brake.wholeVehicle.vehicleSerial1 = oneSerial;
                            #endregion
                        }

                        #region 制动时序(时间) (brakeSeqTime)
                        brakeSeqTime seqTime = new brakeSeqTime();
                        seqTime.axle1 = "";
                        seqTime.axle2 = "";
                        seqTime.axle3 = "";
                        seqTime.axle4 = "";
                        seqTime.axle5 = "";
                        seqTime.axle6 = "";
                        seqTime.evaluate = "";
                        record.brake.wholeVehicle.brakeSeqTime = seqTime; ;
                        #endregion

                        #region 制动时序(时序) (brakeSeq)
                        brakeSeq seq = new brakeSeq();
                        seq.axle1 = "";
                        seq.axle2 = "";
                        seq.axle3 = "";
                        seq.axle4 = "";
                        seq.axle5 = "";
                        seq.axle6 = "";
                        seq.evaluate = "";
                        record.brake.wholeVehicle.brakeSeq = seq;
                        #endregion

                        if (false)
                        {
                            #region 汽车列车2(vehicleSerial2)
                            vehicleSerial2 twoSerial = new vehicleSerial2();
                            twoSerial.brakeRateTractorTrain = "";
                            twoSerial.brakeRateTrailerTrain = "";
                            twoSerial.evaluate = "";
                            record.brake.wholeVehicle.vehicleSerial2 = twoSerial;
                            #endregion
                        }
                    }
                    #endregion

                    #region 单轴
                    List<singleAxle> listSingleAxle = new List<singleAxle>();
                    if (m_RESULT_BRAKE_ZJ != null)
                    {
                        if (DetectItem.Contains("B1"))
                        {
                            singleAxle oneSingleAxle = new singleAxle();
                            oneSingleAxle.axleSerialNo = "1";
                            oneSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.YZZDLV;
                            oneSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.YZBPHLV;
                            oneSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.YZZZDCZD;
                            oneSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.YZYZDCZD;
                            oneSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.YZZZZLV;
                            oneSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.YZYZZLV;
                            oneSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.YZBPHLV_PD.To_Net_ZJPD();
                            oneSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDYZJCCS;
                            listSingleAxle.Add(oneSingleAxle);
                        }
                        if (DetectItem.Contains("B2"))
                        {
                            singleAxle twoSingleAxle = new singleAxle();
                            twoSingleAxle.axleSerialNo = "2";
                            twoSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.EZZDLV;
                            twoSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.EZBPHLV;
                            twoSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.EZZZDCZD;
                            twoSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.EZYZDCZD;
                            twoSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.EZZZZLV;
                            twoSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.EZYZZLV;
                            twoSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.EZBPHLV_PD.To_Net_ZJPD();
                            twoSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDEZJCCS;
                            listSingleAxle.Add(twoSingleAxle);
                        }
                        if (DetectItem.Contains("B3"))
                        {
                            singleAxle threeSingleAxle = new singleAxle();
                            threeSingleAxle.axleSerialNo = "3";
                            threeSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.SZZDLV;
                            threeSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.SZBPHLV;
                            threeSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.SZZZDCZD;
                            threeSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.SZYZDCZD;
                            threeSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.SZZZZLV;
                            threeSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.SZYZZLV;
                            threeSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.SZZDZ_PD.To_Net_ZJPD();
                            threeSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDSZJCCS;
                            listSingleAxle.Add(threeSingleAxle);
                        }
                        if (DetectItem.Contains("B4"))
                        {
                            singleAxle fourSingleAxle = new singleAxle();
                            fourSingleAxle.axleSerialNo = "4";
                            fourSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.SIZZDLV;
                            fourSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.SIZBPHLV;
                            fourSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.SIZZZDCZD;
                            fourSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.SIZYZDCZD;
                            fourSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.SIZZZZLV;
                            fourSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.SIZYZZLV;
                            fourSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.SIZZDZ_PD.To_Net_ZJPD();
                            fourSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDSIZJCCS;
                            listSingleAxle.Add(fourSingleAxle);
                        }
                        if (DetectItem.Contains("B5"))
                        {
                            singleAxle fiveSingleAxle = new singleAxle();
                            fiveSingleAxle.axleSerialNo = "5";
                            fiveSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.WZZDLV;
                            fiveSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.WZBPHLV;
                            fiveSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.WZZZDCZD;
                            fiveSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.WZYZDCZD;
                            fiveSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.WZZZZLV;
                            fiveSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.WZYZZLV;
                            fiveSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.WZZDZ_PD.To_Net_ZJPD();
                            fiveSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDWZJCCS;
                            listSingleAxle.Add(fiveSingleAxle);
                        }
                        if (DetectItem.Contains("B6"))
                        {
                            singleAxle sixSingleAxle = new singleAxle();
                            sixSingleAxle.axleSerialNo = "6";
                            sixSingleAxle.axleBrakeRate = m_RESULT_BRAKE_ZJ.LZZDLV;
                            sixSingleAxle.brakeUnbalanceRate = m_RESULT_BRAKE_ZJ.LZBPHLV;
                            sixSingleAxle.leftMaxProcessDiff = m_RESULT_BRAKE_ZJ.LZZZDCZD;
                            sixSingleAxle.rightMaxProcessDiff = m_RESULT_BRAKE_ZJ.LZYZDCZD;
                            sixSingleAxle.leftRetardingForce = m_RESULT_BRAKE_ZJ.LZZZZLV;
                            sixSingleAxle.rightRetardingForce = m_RESULT_BRAKE_ZJ.LZYZZLV;
                            sixSingleAxle.evaluate = m_RESULT_BRAKE_ZJ.LZZDZ_PD.To_Net_ZJPD();
                            sixSingleAxle.count = m_RESULT_BRAKE_ZJ.ZDLZJCCS;
                            listSingleAxle.Add(sixSingleAxle);
                        }
                        record.brake.singleAxle = listSingleAxle;
                    }
                    #endregion

                    #region 路试
                    if (DetectItem.Contains("R"))
                    {
                        #region 行车制动
                        driveBrake roadDriveBrake = new driveBrake();
                        roadDriveBrake.initialVelocity = m_RESULT_ROAD.LSZDCSD;
                        roadDriveBrake.laneWidth = m_RESULT_ROAD.LSZDSCDK;
                        roadDriveBrake.brakeDistance = m_RESULT_ROAD.LSZDJL;
                        roadDriveBrake.mfdd = m_RESULT_ROAD.MFDD;
                        roadDriveBrake.brakeStability = m_RESULT_ROAD.LSZDPPQK;
                        roadDriveBrake.brakeCoordinateTime = m_RESULT_ROAD.LSZDXTSJ;
                        roadDriveBrake.evaluate = "";
                        if (roadDriveBrake.evaluate != "")
                        {
                            record.brake.roadTest = new roadTest();
                            record.brake.roadTest.driveBrake = roadDriveBrake;
                        }
                        #endregion

                        #region 驻车制动
                        parkBrake roadParkBrake = new parkBrake();
                        roadParkBrake.parkSlope = m_RESULT_ROAD.LSZCPD;
                        roadParkBrake.parkResult = m_RESULT_ROAD.LSZC_PD;
                        roadParkBrake.evaluate = "";
                        if (roadParkBrake.evaluate != "")
                        {
                            if (record.brake.roadTest == null)
                            {
                                record.brake.roadTest = new roadTest();
                            }
                            record.brake.roadTest.parkBrake = roadParkBrake;
                        }
                        #endregion
                    }
                    #endregion
                    #endregion

                    #region 排放性(emission)
                    if (!IsHC || !UseSafetyTechnologyResult)
                    {
                        #region 汽油车(gasolineVehicle)
                        gasolineVehicle gasVegicle = null;
                        if (DetectItem.Contains("X1"))
                        {

                            if (m_RESULT_SDS != null)
                            {
                                gasVegicle = new gasolineVehicle();
                                gasVegicle.highCo = m_RESULT_SDS.GDSCO;
                                gasVegicle.highHc = m_RESULT_SDS.GDSHC;
                                gasVegicle.highL = m_RESULT_SDS.GLKQXS;
                                gasVegicle.lowCo = m_RESULT_SDS.DSCO;
                                gasVegicle.lowHc = m_RESULT_SDS.DSHC;
                                gasVegicle.evaluate = m_RESULT_SDS.SDS_PD.To_Net_ZJPD();
                                gasVegicle.count = DetectItemList.Count(p=>p.Equals("X1")).ToString();
                            }

                        }
                        else if (DetectItem.Contains("X2"))
                        {
                            if (m_RESULT_ASM != null)
                            {
                                gasVegicle = new gasolineVehicle();
                                //if (!string.IsNullOrEmpty(m_RESULT_ASM.ASM_5025_PD) && m_RESULT_ASM.ASM_5025_PD != "0")
                                //{
                                gasVegicle.co5025 = m_RESULT_ASM.CO5025JG;
                                gasVegicle.hc5025 = m_RESULT_ASM.HC5025JG;
                                gasVegicle.no5025 = m_RESULT_ASM.NO5025JG;
                                if (!string.IsNullOrEmpty(m_RESULT_ASM.ASM_2540_PD) && m_RESULT_ASM.ASM_2540_PD != "0")
                                {
                                    gasVegicle.co2540 = m_RESULT_ASM.CO2540JG;
                                    gasVegicle.hc2540 = m_RESULT_ASM.HC2540JG;
                                    gasVegicle.no2540 = m_RESULT_ASM.NO2540JG;
                                }
                                gasVegicle.evaluate = m_RESULT_ASM.ASM_PD.To_Net_ZJPD();
                                gasVegicle.count = DetectItemList.Count(p => p.Equals("X2")).ToString();
                                //}
                            }

                        }
                        else if (DetectItem.Contains("X3"))
                        {
                            if (m_RESULT_VMAS != null)
                            {
                                gasVegicle = new gasolineVehicle();
                                gasVegicle.vmasCo = m_RESULT_VMAS.COJG;
                                gasVegicle.vmasHc = m_RESULT_VMAS.HCJG;
                                gasVegicle.vmasNo = m_RESULT_VMAS.NOJG;
                                gasVegicle.vmasHcNo = m_RESULT_VMAS.HC_NOJG;
                                gasVegicle.evaluate = m_RESULT_VMAS.VMAS_PD.To_Net_ZJPD();
                                gasVegicle.count = DetectItemList.Count(p => p.Equals("X3")).ToString();
                            }

                        }
                        if (gasVegicle != null)
                        {
                            record.emission = new emission();
                            record.emission.gasolineVehicle = gasVegicle;
                            KeyItemList.Add(gasVegicle.evaluate);
                        }
                        #endregion

                        #region 柴油车(dieselVehicle)
                        dieselVehicle dieVehicle = null;
                        if (DetectItem.Contains("X4"))
                        {
                            dieVehicle = new dieselVehicle();
                            if (m_RESULT_ZYJS != null)
                            {
                                dieVehicle.ratio1 = m_RESULT_ZYJS.ZYJSJG1;
                                dieVehicle.ratio2 = m_RESULT_ZYJS.ZYJSJG2;
                                dieVehicle.ratio3 = m_RESULT_ZYJS.ZYJSJG3;
                                dieVehicle.ratioBalance = m_RESULT_ZYJS.ZYJSPJZ;
                                dieVehicle.evaluate = m_RESULT_ZYJS.ZYJS_PD.To_Net_ZJPD();
                                dieVehicle.count = DetectItemList.Count(p => p.Equals("X4")).ToString();
                            }
                        }
                        else if (DetectItem.Contains("X6"))
                        {
                            dieVehicle = new dieselVehicle();
                            if (m_RESULT_ZYJS != null)
                            {
                                dieVehicle.smoke1 = m_RESULT_ZYJS.ZYJSJG2;
                                dieVehicle.smoke2 = m_RESULT_ZYJS.ZYJSJG3;
                                dieVehicle.smoke3 = m_RESULT_ZYJS.ZYJSJG4;
                                dieVehicle.smokeBalance = m_RESULT_ZYJS.ZYJSPJZ;
                                dieVehicle.evaluate = m_RESULT_ZYJS.ZYJS_PD.To_Net_ZJPD();
                                dieVehicle.count = DetectItemList.Count(p => p.Equals("X6")).ToString();
                            }
                        }
                        else if (DetectItem.Contains("X5"))
                        {
                            dieVehicle = new dieselVehicle();
                            if (m_RESULT_LD != null)
                            {
                                dieVehicle.ratio100 = m_RESULT_LD.GXSXS100;
                                dieVehicle.ratio90 = m_RESULT_LD.GXSXS90;
                                dieVehicle.ratio80 = m_RESULT_LD.GXSXS80;
                                dieVehicle.nox80 = m_RESULT_LD.NO80;
                                dieVehicle.maxWheelSidePower = m_RESULT_LD.GLJG;
                                dieVehicle.evaluate = m_RESULT_LD.LD_PD.To_Net_ZJPD();
                                dieVehicle.count = DetectItemList.Count(p => p.Equals("X5")).ToString();
                            }
                        }
                        if (dieVehicle != null)
                        {
                            record.emission = new emission();
                            record.emission.dieselVehicle = dieVehicle;
                            KeyItemList.Add(dieVehicle.evaluate);
                        }
                        #endregion
                    }
                    #endregion
                }
                if (!IsHC || !UseSafetyTechnologyResult)
                {
                    #region 悬架(suspension)
                    if (m_RESULT_SUSPENSION != null)
                    {
                        if (m_RESULT_SUSPENSION != null)
                        {
                            List<suspension> listSpen = new List<suspension>();
                            suspension spen1 = new suspension();
                            spen1.axleType = "FRONT";
                            spen1.efficiencyOfLeftAxle = m_RESULT_SUSPENSION.QZZLXSLV;
                            spen1.efficiencyOfRightAxle = m_RESULT_SUSPENSION.QZYLXSLV;
                            spen1.absorbRateDifOfAxle = m_RESULT_SUSPENSION.QZXSLVC;
                            spen1.evaluate = m_RESULT_SUSPENSION.QZXSLVC_PD.To_Net_ZJPD();
                            spen1.count = DetectItemList.Count(p => p.Equals("U0")).ToString();
                            listSpen.Add(spen1);
                            KeyItemList.Add(spen1.evaluate);

                            suspension spen2 = new suspension();
                            spen2.axleType = "BEHIND";
                            spen2.efficiencyOfLeftAxle = m_RESULT_SUSPENSION.HZZLXSLV;
                            spen2.efficiencyOfRightAxle = m_RESULT_SUSPENSION.HZYLXSLV;
                            spen2.absorbRateDifOfAxle = m_RESULT_SUSPENSION.HZXSLVC;
                            spen2.evaluate = m_RESULT_SUSPENSION.HZXSLVC_PD.To_Net_ZJPD();
                            spen2.count = DetectItemList.Count(p => p.Equals("U1")).ToString();
                            listSpen.Add(spen2);
                            record.suspension = listSpen;
                            KeyItemList.Add(spen2.evaluate);

                        }
                    }
                    #endregion

                    #region 前照灯(mainLamp)
                    if (DetectItem.Contains("H"))
                    {
                        if (m_RESULT_LAMP_ZJ != null)
                        {
                            List<mainLamp> listLamp = new List<mainLamp>();
                            mainLamp lamp1 = new mainLamp();
                            lamp1.lampType = "1";
                            lamp1.nearLightLampHight = m_RESULT_LAMP_ZJ.ZWDJGDG;
                            lamp1.farLightLampHight = m_RESULT_LAMP_ZJ.ZWDYGDG;
                            lamp1.farLightStrong = m_RESULT_LAMP_ZJ.ZWDYGGQ;
                            lamp1.farLightVOffset = m_RESULT_LAMP_ZJ.ZWDYGCZPY;
                            lamp1.farLightHOffset = m_RESULT_LAMP_ZJ.ZWDYGSPPYL;
                            lamp1.nearLightVOffset = m_RESULT_LAMP_ZJ.ZWDJGCZPY;
                            lamp1.nearLightHOffset = m_RESULT_LAMP_ZJ.ZWDJGSPPYL;
                            lamp1.evaluate = m_RESULT_LAMP_ZJ.ZWDZ_PD.To_Net_ZJPD();
                            lamp1.count = DetectItemList.Count(p => p.Equals("H1")).ToString();
                            listLamp.Add(lamp1);

                            mainLamp lamp2 = new mainLamp();
                            lamp2.lampType = "2";
                            lamp2.nearLightLampHight = m_RESULT_LAMP_ZJ.ZNDJGDG;
                            lamp2.farLightLampHight = m_RESULT_LAMP_ZJ.ZNDYGDG;
                            lamp2.farLightStrong = m_RESULT_LAMP_ZJ.ZNDYGGQ;
                            lamp2.farLightVOffset = m_RESULT_LAMP_ZJ.ZNDYGCZPY;
                            lamp2.farLightHOffset = m_RESULT_LAMP_ZJ.ZNDYGSPPYL;
                            lamp2.nearLightVOffset = m_RESULT_LAMP_ZJ.ZNDJGCZPY;
                            lamp2.nearLightHOffset = m_RESULT_LAMP_ZJ.ZNDJGSPPYL;
                            lamp2.evaluate = m_RESULT_LAMP_ZJ.ZNDZ_PD.To_Net_ZJPD();
                            lamp2.count = DetectItemList.Count(p => p.Equals("H2")).ToString();
                            listLamp.Add(lamp2);

                            mainLamp lamp3 = new mainLamp();
                            lamp3.lampType = "3";
                            lamp3.nearLightLampHight = m_RESULT_LAMP_ZJ.YWDJGDG;
                            lamp3.farLightLampHight = m_RESULT_LAMP_ZJ.YWDYGDG;
                            lamp3.farLightStrong = m_RESULT_LAMP_ZJ.YWDYGGQ;
                            lamp3.farLightVOffset = m_RESULT_LAMP_ZJ.YWDYGCZPY;
                            lamp3.farLightHOffset = m_RESULT_LAMP_ZJ.YWDYGSPPYL;
                            lamp3.nearLightVOffset = m_RESULT_LAMP_ZJ.YWDJGCZPY;
                            lamp3.nearLightHOffset = m_RESULT_LAMP_ZJ.YWDJGSPPYL;
                            lamp3.evaluate = m_RESULT_LAMP_ZJ.YWDZ_PD.To_Net_ZJPD();
                            lamp3.count = DetectItemList.Count(p => p.Equals("H4")).ToString();
                            listLamp.Add(lamp3);

                            mainLamp lamp4 = new mainLamp();
                            lamp4.lampType = "4";
                            lamp4.nearLightLampHight = m_RESULT_LAMP_ZJ.YNDJGDG;
                            lamp4.farLightLampHight = m_RESULT_LAMP_ZJ.YNDYGDG;
                            lamp4.farLightStrong = m_RESULT_LAMP_ZJ.YNDYGGQ;
                            lamp4.farLightVOffset = m_RESULT_LAMP_ZJ.YNDYGCZPY;
                            lamp4.farLightHOffset = m_RESULT_LAMP_ZJ.YNDYGSPPYL;
                            lamp4.nearLightVOffset = m_RESULT_LAMP_ZJ.YNDJGCZPY;
                            lamp4.nearLightHOffset = m_RESULT_LAMP_ZJ.YNDJGSPPYL;
                            lamp4.evaluate = m_RESULT_LAMP_ZJ.YNDZ_PD.To_Net_ZJPD();
                            lamp4.count = DetectItemList.Count(p => p.Equals("H3")).ToString();
                            listLamp.Add(lamp4);

                            foreach (var item in listLamp)
                            {
                                PropertyInfo[] pInfos = item.GetType().GetProperties();
                                foreach (var p in pInfos)
                                {
                                    if (p.GetValue(item, null) != null && Convert.ToString(p.GetValue(item, null)) == "-")
                                    {
                                        p.SetValue(item, "", null);
                                    }
                                }
                            }
                            record.mainLamp = listLamp;
                        }
                    }

                    #endregion
                }

                #region 单项检测(singleItem)
                List<singleItem> listSingleItem = new List<singleItem>();
                ////发动机无负荷功率
                //singleItem singleItem1 = new singleItem();
                //singleItem1.itemCode = "no_load_engine_power";
                //singleItem1.detectResult = "";
                //singleItem1.evaluate = "";
                //listSingleItem.Add(singleItem1);


                ////转向盘自由转动量
                //singleItem singleItem2 = new singleItem();
                //singleItem2.itemCode = "free_rotation_of_steer_wheel";
                //singleItem2.detectResult = "";
                //singleItem2.evaluate = "";
                //listSingleItem.Add(singleItem2);


                ////转向盘操纵力
                //singleItem singleItem3 = new singleItem();
                //singleItem3.itemCode = "steer_force_of_steer_wheel";
                //singleItem3.detectResult = "";
                //singleItem3.evaluate = "";
                //listSingleItem.Add(singleItem3);


                ////柴油机烟度
                //singleItem singleItem4 = new singleItem();
                //singleItem4.itemCode = "diesel_smoke";
                //singleItem4.detectResult = "";
                //singleItem4.evaluate = "";
                //listSingleItem.Add(singleItem4);


                ////客车车内噪声
                //singleItem singleItem5 = new singleItem();
                //singleItem5.itemCode = "internal_noise_of_verhicle";
                //singleItem5.detectResult = "";
                //singleItem5.evaluate = "";
                //listSingleItem.Add(singleItem5);


                ////制动踏板自由行程
                //singleItem singleItem6 = new singleItem();
                //singleItem6.itemCode = "brake_pedal_free_stroke";
                //singleItem6.detectResult = "";
                //singleItem6.evaluate = "";
                //listSingleItem.Add(singleItem6);


                ////制动踏板力
                //singleItem singleItem7 = new singleItem();
                //singleItem7.itemCode = "brake_pedal_force";
                //singleItem7.detectResult = "";
                //singleItem7.evaluate = "";
                //listSingleItem.Add(singleItem7);


                ////实测车速
                //singleItem singleItem8 = new singleItem();
                //singleItem8.itemCode = "measured_speed";
                //singleItem8.detectResult = "";
                //singleItem8.evaluate = "";
                //listSingleItem.Add(singleItem8);


                ////车速表示值误差
                //singleItem singleItem9 = new singleItem();
                //singleItem9.itemCode = "speed_meter_deviation";
                //singleItem9.detectResult = "";
                //singleItem9.evaluate = "";
                //listSingleItem.Add(singleItem9);


                ////滑行距离
                //singleItem singleItem10 = new singleItem();
                //singleItem10.itemCode = "slid_distance";
                //singleItem10.detectResult = "";
                //singleItem10.evaluate = "";
                //listSingleItem.Add(singleItem10);


                ////滑行阻力
                //singleItem singleItem11 = new singleItem();
                //singleItem11.itemCode = "slid_resistance";
                //singleItem11.detectResult = "";
                //singleItem11.evaluate = "";
                //listSingleItem.Add(singleItem11);


                ////轮胎气压
                //singleItem singleItem12 = new singleItem();
                //singleItem12.itemCode = "tire_pressure";
                //singleItem12.detectResult = "";
                //singleItem12.evaluate = "";
                //listSingleItem.Add(singleItem12);


                ////传动轴游隙
                //singleItem singleItem13 = new singleItem();
                //singleItem13.itemCode = "shaft_clearance";
                //singleItem13.detectResult = "";
                //singleItem13.evaluate = "";
                //listSingleItem.Add(singleItem13);


                ////离合器踏板自由行程
                //singleItem singleItem14 = new singleItem();
                //singleItem14.itemCode = "clutch_pedal_pos";
                //singleItem14.detectResult = "";
                //singleItem14.evaluate = "";
                //listSingleItem.Add(singleItem14);


                ////离合器踏板力
                //singleItem singleItem15 = new singleItem();
                //singleItem15.itemCode = "clutch_pedal_force";
                //singleItem15.detectResult = "";
                //singleItem15.evaluate = "";
                //listSingleItem.Add(singleItem15);


                ////传动系异响
                //singleItem singleItem16 = new singleItem();
                //singleItem16.itemCode = "trans_sys_abnormal_sound";
                //singleItem16.detectResult = "";
                //singleItem16.evaluate = "";
                //listSingleItem.Add(singleItem16);


                ////驻车装置操纵力
                //singleItem singleItem17 = new singleItem();
                //singleItem17.itemCode = "park_equip_operate_force";
                //singleItem17.detectResult = "";
                //singleItem17.evaluate = "";
                //listSingleItem.Add(singleItem17);


                ////发动机异响
                //singleItem singleItem18 = new singleItem();
                //singleItem18.itemCode = "engine_abnormal_sound";
                //singleItem18.detectResult = "";
                //singleItem18.evaluate = "";
                //listSingleItem.Add(singleItem18);


                ////发动机机油压力
                //singleItem singleItem19 = new singleItem();
                //singleItem19.itemCode = "oil_pressure";
                //singleItem19.detectResult = "";
                //singleItem19.evaluate = "";
                //listSingleItem.Add(singleItem19);


                ////发动机最低稳定转速
                //singleItem singleItem20 = new singleItem();
                //singleItem20.itemCode = "min_stable_speed";
                //singleItem20.detectResult = "";
                //singleItem20.evaluate = "";
                //listSingleItem.Add(singleItem20);


                //等速百公里油耗 3.5吨以上
                if (!IsNew && DetectItem.Contains("G5") && m_RESULT_DPCG != null)
                {
                    singleItem singleItem21 = new singleItem();
                    singleItem21.itemCode = "constant_speed_fuel_consumption_per_hundred_kilometers";
                    singleItem21.detectResult = m_RESULT_DPCG.YH_SCZ;
                    singleItem21.evaluate = m_RESULT_DPCG.YH_PD.To_Net_ZJPD();
                    singleItem21.count = DetectItemList.Count(p => p.Equals("G0")).ToString();
                    listSingleItem.Add(singleItem21);
                }


                ////客车防雨密封性
                //singleItem singleItem22 = new singleItem();
                //singleItem22.itemCode = "rainproof";
                //singleItem22.detectResult = "";
                //singleItem22.evaluate = "";
                //listSingleItem.Add(singleItem22);


                //喇叭声级
                //singleItem singleItem23 = new singleItem();
                //singleItem23.itemCode = "horn_sound";
                //singleItem23.detectResult = "";
                //singleItem23.evaluate = "";
                //listSingleItem.Add(singleItem23);


                ////蓄电池稳定电压
                //singleItem singleItem24 = new singleItem();
                //singleItem24.itemCode = "battery_voltage";
                //singleItem24.detectResult = "";
                //singleItem24.evaluate = "";
                //listSingleItem.Add(singleItem24);


                ////起动电流
                //singleItem singleItem25 = new singleItem();
                //singleItem25.itemCode = "starting_current";
                //singleItem25.detectResult = "";
                //singleItem25.evaluate = "";
                //listSingleItem.Add(singleItem25);


                ////起动前电压
                //singleItem singleItem26 = new singleItem();
                //singleItem26.itemCode = "pre_starting_voltage";
                //singleItem26.detectResult = "";
                //singleItem26.evaluate = "";
                //listSingleItem.Add(singleItem26);


                ////蓄电池内阻
                //singleItem singleItem27 = new singleItem();
                //singleItem27.itemCode = "attery_inter_resistance";
                //singleItem27.detectResult = "";
                //singleItem27.evaluate = "";
                //listSingleItem.Add(singleItem27);


                ////最小缸压/标准缸压
                //singleItem singleItem28 = new singleItem();
                //singleItem28.itemCode = "standard_cylinder_pressure";
                //singleItem28.detectResult = "";
                //singleItem28.evaluate = "";
                //listSingleItem.Add(singleItem28);


                ////缸压与平均缸压最大反差
                //singleItem singleItem29 = new singleItem();
                //singleItem29.itemCode = "max_contrast_of_cylinder_pressure_and_average_cylinder_pressure";
                //singleItem29.detectResult = "";
                //singleItem29.evaluate = "";
                //listSingleItem.Add(singleItem29);


                ////制动力和（整车）
                //singleItem singleItem30 = new singleItem();
                //singleItem30.itemCode = "brake_force_of_whole_vehicle";
                //singleItem30.detectResult = "";
                //singleItem30.evaluate = "";
                //listSingleItem.Add(singleItem30);


                ////制动力和（一轴）
                //singleItem singleItem31 = new singleItem();
                //singleItem31.itemCode = "brake_force_of_first_axle";
                //singleItem31.detectResult = "";
                //singleItem31.evaluate = "";
                //listSingleItem.Add(singleItem31);



                //车速表（km/h）
                if (m_RESULT_SPEED_ZJ != null)
                {
                    singleItem singleItem32 = new singleItem();
                    singleItem32.itemCode = "speed_meter";
                    singleItem32.detectResult = m_RESULT_SPEED_ZJ.SCSD;
                    singleItem32.evaluate = m_RESULT_SPEED_ZJ.SD_PD.To_Net_ZJPD();
                    singleItem32.count = DetectItemList.Count(p => p.Equals("S1")).ToString();
                    listSingleItem.Add(singleItem32);
                }

                //喇叭声压级（dB(A)）
                if (m_RESULT_SPEAKER != null)
                {
                    singleItem singleItem33 = new singleItem();
                    singleItem33.itemCode = "horn_sound_pressure_level";
                    singleItem33.detectResult = m_RESULT_SPEAKER.SCSJZ;
                    singleItem33.evaluate = m_RESULT_SPEAKER.SJZ_PD.To_Net_ZJPD();
                    singleItem33.count = DetectItemList.Count(p => p.Equals("L1")).ToString();
                    listSingleItem.Add(singleItem33);
                }

                //if (!IsHC || !UseSafetyTechnologyResult)
                //{
                    if (m_RESULT_SIDESLIP_ZJ != null && DetectItem.Contains("A") /*&& (m_LOGIN_VEHICLE_INFO.ZXZLXDH.To_ZXZSL().Equals(2))*/)
                    {
                        //侧滑量：第一转向轮
                        singleItem singleItem34 = new singleItem();
                        singleItem34.itemCode = "slip_first_wheel";
                        singleItem34.detectResult = m_RESULT_SIDESLIP_ZJ.QQCHSCZ;
                        singleItem34.evaluate = m_RESULT_SIDESLIP_ZJ.QQCH_PD.To_Net_ZJPD();
                        singleItem34.count = DetectItemList.Count(p => p.Equals("A1")).ToString();
                        listSingleItem.Add(singleItem34);


                        //侧滑量：第二转向轮
                        if (!string.IsNullOrEmpty(m_RESULT_SIDESLIP_ZJ.HQCHSCZ))
                        {
                            singleItem singleItem35 = new singleItem();
                            singleItem35.itemCode = "slip_second_wheel";
                            singleItem35.detectResult = m_RESULT_SIDESLIP_ZJ.HQCHSCZ ?? "-";// ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "HQCHSCZ").Replace("-", "").Replace("+", "");
                            singleItem35.evaluate = m_RESULT_SIDESLIP_ZJ.HQCH_PD ?? "4";// ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "HQCH_PD");
                            singleItem35.count = string.IsNullOrEmpty(m_RESULT_SIDESLIP_ZJ.HQCHSCZ) ? "0" : DetectItemList.Count(p => p.Equals("A1")).ToString();
                            listSingleItem.Add(singleItem35);
                        }
                    }
                //}

                //不合格项汇总
                //singleItem singleItem36 = new singleItem();
                //singleItem36.itemCode = "unqualified_items";
                //singleItem36.detectResult = "";
                //singleItem36.evaluate = "";
                //listSingleItem.Add(singleItem36);


                ////驻车制动率
                //singleItem singleItem37 = new singleItem();
                //singleItem37.itemCode = "park_rake_rate";
                //singleItem37.detectResult = "";
                //singleItem37.evaluate = "";
                //listSingleItem.Add(singleItem37);


                ////前束

                //singleItem singleItem38 = new singleItem();
                //singleItem38.itemCode = "toe_in";
                //singleItem38.detectResult = "";
                //singleItem38.evaluate = "";
                //listSingleItem.Add(singleItem38);
                #endregion
                listSingleItem.RemoveAll(x => x.detectResult.Equals(""));
                listSingleItem.ForEach(x =>
                {
                    if (x.evaluate.Equals("-"))
                    {
                        x.evaluate = "";
                    }
                    if (x.detectResult.Equals("-"))
                    {
                        x.detectResult = "";
                    }
                });
                record.singleItem = listSingleItem;

                #region 打印图片资料(printImage)
                //record.printImage = new List<printImage>();

                //if (string.IsNullOrEmpty(m_RESULT_IMAGE.JCLSH) == false)
                //{
                //    byte[] bLampImage = ChageImage(m_RESULT_IMAGE.Lamp_Image);
                //    byte[] bBrakeImage = ChageImage(m_RESULT_IMAGE.Brake_Image);
                //    byte[] bPower_Image = ChageImage(m_RESULT_IMAGE.Power_Image);


                //    List<printImage> listPrintImg = new List<printImage>();

                //    if (!IsHC && bBrakeImage != null)
                //    {
                //        printImage printImgBrake = new printImage();
                //        printImgBrake.imageType = "1";
                //        printImgBrake.base64Image = Convert.ToBase64String(bBrakeImage);
                //        listPrintImg.Add(printImgBrake);
                //    }
                //    if (bPower_Image == null)
                //    {
                //        WriteLog("缺少动力性照片！");
                //    }
                //    if (bPower_Image != null)
                //    {
                //        printImage printImgPower = new printImage();
                //        printImgPower.imageType = "3";
                //        printImgPower.base64Image = Convert.ToBase64String(bPower_Image);
                //        listPrintImg.Add(printImgPower);
                //    }
                //    if (!IsHC && bLampImage != null)
                //    {
                //        printImage printImgLamp = new printImage();
                //        printImgLamp.imageType = "2";
                //        printImgLamp.base64Image = Convert.ToBase64String(bLampImage);
                //        listPrintImg.Add(printImgLamp);
                //    }



                //    printImage printImgLampVin = new printImage();
                //    printImgLampVin.imageType = "4";
                //    printImgLampVin.base64Image = "";
                //    listPrintImg.Add(printImgLampVin);
                //    record.printImage = listPrintImg;
                //}

                #endregion

                #endregion

                dic.Add("detectRecord", record);


                #region 图片资料
                List<image> listImg = new List<image>();
                if (!IsHC)
                {
                    image image1 = new image();
                    image1.imageType = "1";
                    image1.imageUrl = string.Format("http://192.168.2.200:4200/image/{0}/1.html", m_RESULT_VEHICLE_INFO.HPHM);
                    listImg.Add(image1);
                    image image2 = new image();
                    image2.imageType = "2";
                    image2.imageUrl = string.Format("http://192.168.2.200:4200/image/{0}/2.html", m_RESULT_VEHICLE_INFO.HPHM);
                    listImg.Add(image2);
                }

                image image3 = new image();
                image3.imageType = "3";
                image3.imageUrl = string.Format("http://192.168.2.200:4200/image/{0}/3.html", m_RESULT_VEHICLE_INFO.HPHM);
                listImg.Add(image3);
                #endregion
                dic.Add("image", listImg);

                #region 视频资料
                List<video> listVideo = new List<video>();
                if ((!IsHC))
                {
                    video video1 = new video();
                    video1.videoType = "1";
                    video1.videoUrl = string.Format("http://192.168.2.200:4200/video/{0}/1.html", m_RESULT_VEHICLE_INFO.HPHM);
                    listVideo.Add(video1);
                    video video2 = new video();
                    video2.videoType = "2";
                    video2.videoUrl = string.Format("http://192.168.2.200:4200/video/{0}/2.html", m_RESULT_VEHICLE_INFO.HPHM);
                    listVideo.Add(video2);
                }

                video video3 = new video();
                video3.videoType = "3";
                video3.videoUrl = string.Format("http://192.168.2.200:4200/video/{0}/3.html", m_RESULT_VEHICLE_INFO.HPHM);
                listVideo.Add(video3);

                #endregion
                dic.Add("video", listVideo);

                #region 检验报告单
                detectReport detectRpt = new detectReport();
                detectRpt.note = "";

                detectRpt.detectResult = "";


                //1合格 2不合格  

                #region 单车（牵引车）基本信息(tractorInfo)
                tractorInfo tractInfo = new tractorInfo();
                tractInfo.vehicleNo = m_LOGIN_VEHICLE_INFO.HPHM;
                tractInfo.client = m_LOGIN_VEHICLE_INFO.SYR;
                tractInfo.vehicleType = m_LOGIN_VEHICLE_INFO.CLZLDH;
                tractInfo.vehicleBrandModel = m_LOGIN_VEHICLE_INFO.PPXH;
                tractInfo.transCertificateCode = m_LOGIN_VEHICLE_INFO.YYZH;
                tractInfo.registDate = m_LOGIN_VEHICLE_INFO.CCDJRQ.To_Net_Date();
                tractInfo.productionDate = m_LOGIN_VEHICLE_INFO.CCRQ.To_Net_Date();
                tractInfo.vehicleBodyColor = m_LOGIN_VEHICLE_INFO.CSYS.To_Net_CSYS();
                tractInfo.vinNo = m_LOGIN_VEHICLE_INFO.VIN;
                tractInfo.engineNo = m_LOGIN_VEHICLE_INFO.FDJH;
                tractInfo.administrativeAera = AppHelper.ComprehensiveSetting.AdministrativeAera;
                #endregion
                detectRpt.tractorInfo = tractInfo;
                if (false)
                {
                    #region 挂车基本信息(trailerInfo)
                    trailerInfo trailInfo = new trailerInfo();
                    trailInfo.vehicleNo = m_LOGIN_VEHICLE_INFO.GLCHPHM;
                    trailInfo.client = "";
                    trailInfo.vehicleType = "";
                    trailInfo.vehicleBrandModel = "";
                    trailInfo.transCertificateCode = "";
                    trailInfo.registDate = "";
                    trailInfo.productionDate = "";
                    trailInfo.vinNo = "";
                    trailInfo.driveLicense = "";

                    #endregion
                    detectRpt.trailerInfo = trailInfo;
                }

                #region 人工检验结果(manualTestResult)
                if (!AppHelper.ComprehensiveSetting.RG_Right)
                {
                    if (m_RESULT_CHASISS_MANUAL_ZJ != null && !string.IsNullOrEmpty(m_RESULT_CHASISS_MANUAL_ZJ.JCLSH))
                    {
                        List<manualTestResult> listManualTest = new List<manualTestResult>();
                        //1	唯一性认定
                        manualTestResult manualTest1 = new manualTestResult();
                        manualTest1.detectCls = "1";
                        manualTest1.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.WYXRD_PD.To_Net_ZJPD();
                        manualTest1.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.WYXRD_MS.ManualMsg();
                        listManualTest.Add(manualTest1);

                        //2	故障信息诊断
                        manualTestResult manualTest2 = new manualTestResult();
                        manualTest2.detectCls = "2";
                        manualTest2.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.ZCGZZD_PD.To_Net_ZJPD();
                        manualTest2.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.ZCGZZD_MS.ManualMsg();
                        listManualTest.Add(manualTest2);

                        //3	外观检查
                        manualTestResult manualTest3 = new manualTestResult();
                        manualTest3.detectCls = "3";
                        manualTest3.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.WGJC_PD.To_Net_ZJPD();
                        if (manualTest3.evaluate.Equals("0")) manualTest3.evaluate = "1"; 
                        manualTest3.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.WGJC_MS.ManualMsg();
                        listManualTest.Add(manualTest3);

                        //4	运行检查
                        manualTestResult manualTest4 = new manualTestResult();
                        manualTest4.detectCls = "4";
                        manualTest4.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.YXJC_PD.To_Net_ZJPD();
                        if (manualTest4.evaluate.Equals("0")) manualTest4.evaluate = "1";
                        manualTest4.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.YXJC_MS.ManualMsg();
                        listManualTest.Add(manualTest4);

                        //5	底盘检查
                        manualTestResult manualTest5 = new manualTestResult();
                        manualTest5.detectCls = "5";
                        manualTest5.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.DPBJ_PD.To_Net_ZJPD();
                        manualTest5.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.DPBJ_MS.ManualMsg();
                        listManualTest.Add(manualTest5);

                        //6	核查评定
                        manualTestResult manualTest6 = new manualTestResult();
                        manualTest6.detectCls = "6";
                        manualTest6.evaluate = m_RESULT_CHASISS_MANUAL_ZJ.HCPD_PD.To_Net_ZJPD();
                        manualTest6.unqualifiedItem = m_RESULT_CHASISS_MANUAL_ZJ.HCPD_MS.ManualMsg();
                        listManualTest.Add(manualTest6);

                        //istManualTest.RemoveAll(x => x.evaluate.Equals("N") || x.evaluate.Equals("4"));

                        detectRpt.manualTestResult = listManualTest;
                    }

                    //if (detectRpt.manualTestResult == null || detectRpt.manualTestResult.Count == 0)
                    //{
                    //    List<manualTestResult> listManualTest = new List<manualTestResult>();
                    //    manualTestResult manualTest6 = new manualTestResult();
                    //    manualTest6.detectCls = "1";
                    //    manualTest6.evaluate = "0";
                    //    manualTest6.unqualifiedItem = "无";
                    //    listManualTest.Add(manualTest6);
                    //    detectRpt.manualTestResult = listManualTest;
                    //}

                    if (detectRpt.manualTestResult == null || detectRpt.manualTestResult.Count == 0)
                    {
                        //WriteLog("缺少人工项目信息", Color.Red);
                    }

                }
                else
                {
                    List<manualTestResult> listManualTest = new List<manualTestResult>();
                    //1	唯一性认定
                    manualTestResult manualTest1 = new manualTestResult();
                    manualTest1.detectCls = "1";
                    manualTest1.evaluate = "0";
                    manualTest1.unqualifiedItem = "无";
                    listManualTest.Add(manualTest1);

                    //2	故障信息诊断
                    manualTestResult manualTest2 = new manualTestResult();
                    manualTest2.detectCls = "2";
                    manualTest2.evaluate = "0";
                    manualTest2.unqualifiedItem = "无";
                    listManualTest.Add(manualTest2);

                    //3	外观检查
                    manualTestResult manualTest3 = new manualTestResult();
                    manualTest3.detectCls = "3";
                    manualTest3.evaluate = "0";
                    manualTest3.unqualifiedItem = "无";
                    listManualTest.Add(manualTest3);

                    //4	运行检查
                    manualTestResult manualTest4 = new manualTestResult();
                    manualTest4.detectCls = "4";
                    manualTest4.evaluate = "0";
                    manualTest4.unqualifiedItem = "无";
                    listManualTest.Add(manualTest4);

                    //5	底盘检查
                    manualTestResult manualTest5 = new manualTestResult();
                    manualTest5.detectCls = "5";
                    manualTest5.evaluate = "0";
                    manualTest5.unqualifiedItem = "无";
                    listManualTest.Add(manualTest5);

                    //6	核查评定
                    manualTestResult manualTest6 = new manualTestResult();
                    manualTest6.detectCls = "6";
                    manualTest6.evaluate = "0";
                    manualTest6.unqualifiedItem = "无";
                    listManualTest.Add(manualTest6);


                    detectRpt.manualTestResult = listManualTest;
                }
                #endregion

                #region 性能检测(performanceItem)
                List<performanceItem> listPerforItem = new List<performanceItem>();

                if (IsNew)
                {
                    LvItemList.Add("1");
                }
                //动力性(km/h)
                if (!IsNew && m_RESULT_DPCG != null)
                {
                    if (DetectItem.Contains("G0"))
                    {
                        performanceItem perforItem1 = new performanceItem();
                        perforItem1.itemCode = "power";
                        perforItem1.detectData = m_RESULT_DPCG.GK_WDCS;
                        perforItem1.standardValue = egt + m_RESULT_DPCG.GK_EDCS;
                        perforItem1.evaluate = m_RESULT_DPCG.GK_PD.To_Net_ZJPD();// ExtendMethod.GetDsYQMsg(dsYQ, "dtDPCG", "GK_PD");// vDPCG.GK_PD.To_Net_ZJPD();
                        if (perforItem1.evaluate == "0")
                        {
                            perforItem1.evaluate = "1";
                        }

                        if (perforItem1.evaluate.Equals("-1"))
                        {
                            logDelegate.BeginInvoke("动力性不合格", Color.Blue, null, null);
                        }

                        LvItemList.Add(perforItem1.evaluate);
                        listPerforItem.Add(perforItem1);
                    }
                }
                else
                {
                    if (DetectItem.Contains("G0"))
                    {
                        performanceItem perforItem1 = new performanceItem();
                        perforItem1.itemCode = "power";
                        perforItem1.evaluate = "1";
                        listPerforItem.Add(perforItem1);
                    }
                }

                if (!IsNew && DetectItem.Contains("G5"))
                {
                    //经济性(L/100km)
                    performanceItem perforItem2 = new performanceItem();
                    perforItem2.itemCode = "economy";

                    perforItem2.detectData = m_RESULT_DPCG.YH_SCZ;
                    perforItem2.standardValue = elt + m_RESULT_DPCG.YH_BZ;
                    perforItem2.evaluate = m_RESULT_DPCG.YH_PD.To_Net_ZJPD();// ExtendMethod.GetDsYQMsg(dsYQ, "dtDPCG", "YH_PD");//vDPCG.YH_PD.To_Net_ZJPD();

                    listPerforItem.Add(perforItem2);
                    KeyItemList.Add(perforItem2.evaluate);

                }
                else
                {
                    if (DetectItem.Contains("G5"))
                    {
                        performanceItem perforItem2 = new performanceItem();
                        perforItem2.itemCode = "economy";
                        perforItem2.evaluate = "0";
                        listPerforItem.Add(perforItem2);
                    }
                }
            

                if (!IsHC)
                {
                    if (m_RESULT_BRAKE_ZJ != null)
                    {
                        //一轴制动率(%)
                        performanceItem perforItem3 = new performanceItem();
                        perforItem3.itemCode = "brake_rate_1";
                        perforItem3.detectData = m_RESULT_BRAKE_ZJ.YZZDLV;
                        perforItem3.standardValue = egt + m_RESULT_BRAKE_ZJ.YZZDLVBZ;
                        perforItem3.evaluate = m_RESULT_BRAKE_ZJ.YZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem3);
                        KeyItemList.Add(perforItem3.evaluate);

                        //一轴不平衡率(%)
                        performanceItem perforItem4 = new performanceItem();
                        perforItem4.itemCode = "unbalance_rate_1";
                        perforItem4.detectData = m_RESULT_BRAKE_ZJ.YZBPHLV;
                        perforItem4.standardValue = elt + m_RESULT_BRAKE_ZJ.YZBPHLVBZ;
                        perforItem4.evaluate = m_RESULT_BRAKE_ZJ.YZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.YZBPHLV, true);
                        listPerforItem.Add(perforItem4);
                        LvItemList.Add(perforItem4.evaluate);
                        //if (perforItem4.evaluate == "-1")
                        //{
                        //    WriteLog("一轴不平衡率不合格!");
                        //}


                        //一轴左轮阻滞率(%)
                        performanceItem perforItem5 = new performanceItem();
                        perforItem5.itemCode = "retarding_force_left_1";
                        perforItem5.detectData = m_RESULT_BRAKE_ZJ.YZZZZLV;
                        perforItem5.standardValue = elt + m_RESULT_BRAKE_ZJ.YZZZLVXZBZ;
                        perforItem5.evaluate = m_RESULT_BRAKE_ZJ.YZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem5);
                        KeyItemList.Add(perforItem5.evaluate);

                        //一轴右轮阻滞率(%)
                        performanceItem perforItem6 = new performanceItem();
                        perforItem6.itemCode = "retarding_force_right_1";
                        perforItem6.detectData = m_RESULT_BRAKE_ZJ.YZYZZLV;
                        perforItem6.standardValue = elt + m_RESULT_BRAKE_ZJ.YZZZLVXZBZ;
                        perforItem6.evaluate = m_RESULT_BRAKE_ZJ.YZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem6);


                        //二轴制动率(%)
                        performanceItem perforItem7 = new performanceItem();
                        perforItem7.itemCode = "brake_rate_2";
                        perforItem7.detectData = m_RESULT_BRAKE_ZJ.EZZDLV;
                        perforItem7.standardValue = egt + m_RESULT_BRAKE_ZJ.EZZDLVBZ;
                        perforItem7.evaluate = m_RESULT_BRAKE_ZJ.EZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem7);
                        KeyItemList.Add(perforItem7.evaluate);

                        //二轴不平衡率(%)
                        bool bQZ = (m_LOGIN_VEHICLE_INFO.ZXZLXDH.To_ZXZSL() == 2 ? true : false);
                        performanceItem perforItem8 = new performanceItem();
                        perforItem8.itemCode = "unbalance_rate_2";
                        perforItem8.detectData = m_RESULT_BRAKE_ZJ.EZBPHLV;
                        perforItem8.standardValue = elt + m_RESULT_BRAKE_ZJ.EZBPHLVBZ;
                        perforItem8.evaluate = m_RESULT_BRAKE_ZJ.EZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.EZBPHLV, bQZ);
                        listPerforItem.Add(perforItem8);
                        LvItemList.Add(perforItem8.evaluate);
                        //if (perforItem8.evaluate == "-1")
                        //{
                        //    WriteLog("二轴不平衡率不合格!");
                        //}


                        //二轴左轮阻滞率(%)
                        performanceItem perforItem9 = new performanceItem();
                        perforItem9.itemCode = "retarding_force_left_2";
                        perforItem9.detectData = m_RESULT_BRAKE_ZJ.EZZZZLV;
                        perforItem9.standardValue = elt + m_RESULT_BRAKE_ZJ.EZZZLVXZBZ;
                        perforItem9.evaluate = m_RESULT_BRAKE_ZJ.EZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem9);
                        KeyItemList.Add(perforItem9.evaluate);

                        //二轴右轮阻滞率(%)
                        performanceItem perforItem10 = new performanceItem();
                        perforItem10.itemCode = "retarding_force_right_2";
                        perforItem10.detectData = m_RESULT_BRAKE_ZJ.EZYZZLV;
                        perforItem10.standardValue = elt + m_RESULT_BRAKE_ZJ.EZZZLVXZBZ;
                        perforItem10.evaluate = m_RESULT_BRAKE_ZJ.EZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem10);
                        KeyItemList.Add(perforItem10.evaluate);

                        //三轴制动率(%)
                        performanceItem perforItem11 = new performanceItem();
                        perforItem11.itemCode = "brake_rate_3";
                        perforItem11.detectData = m_RESULT_BRAKE_ZJ.SZZDLV;
                        perforItem11.standardValue = egt + m_RESULT_BRAKE_ZJ.SZZDLVBZ;
                        perforItem11.evaluate = m_RESULT_BRAKE_ZJ.SZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem11);
                        KeyItemList.Add(perforItem11.evaluate);

                        //三轴不平衡率(%)
                        performanceItem perforItem12 = new performanceItem();
                        perforItem12.itemCode = "unbalance_rate_3";
                        perforItem12.detectData = m_RESULT_BRAKE_ZJ.SZBPHLV;
                        perforItem12.standardValue = elt + m_RESULT_BRAKE_ZJ.SZBPHLVBZ;
                        perforItem12.evaluate = m_RESULT_BRAKE_ZJ.SZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.SZBPHLV, false);
                        listPerforItem.Add(perforItem12);
                        LvItemList.Add(perforItem12.evaluate);

                        //三轴左轮阻滞率(%)
                        performanceItem perforItem13 = new performanceItem();
                        perforItem13.itemCode = "retarding_force_left_3";
                        perforItem13.detectData = m_RESULT_BRAKE_ZJ.SZZZZLV;
                        perforItem13.standardValue = elt + m_RESULT_BRAKE_ZJ.SZZZLVXZBZ;
                        perforItem13.evaluate = m_RESULT_BRAKE_ZJ.SZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem13);
                        KeyItemList.Add(perforItem13.evaluate);

                        //三轴右轮阻滞率(%)
                        performanceItem perforItem14 = new performanceItem();
                        perforItem14.itemCode = "retarding_force_right_3";
                        perforItem14.detectData = m_RESULT_BRAKE_ZJ.SZYZZLV;
                        perforItem14.standardValue = elt + m_RESULT_BRAKE_ZJ.SZZZLVXZBZ;
                        perforItem14.evaluate = m_RESULT_BRAKE_ZJ.SZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem14);
                        KeyItemList.Add(perforItem14.evaluate);

                        //四轴制动率(%)
                        performanceItem perforItem15 = new performanceItem();
                        perforItem15.itemCode = "brake_rate_4";
                        perforItem15.detectData = m_RESULT_BRAKE_ZJ.SIZZDLV;
                        perforItem15.standardValue = egt + m_RESULT_BRAKE_ZJ.SIZZDLVBZ;
                        perforItem15.evaluate = m_RESULT_BRAKE_ZJ.SIZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem15);
                        KeyItemList.Add(perforItem15.evaluate);

                        //四轴不平衡率(%)
                        performanceItem perforItem16 = new performanceItem();
                        perforItem16.itemCode = "unbalance_rate_4";
                        perforItem16.detectData = m_RESULT_BRAKE_ZJ.SIZBPHLV;
                        perforItem16.standardValue = elt + m_RESULT_BRAKE_ZJ.SIZBPHLVBZ;
                        perforItem16.evaluate = m_RESULT_BRAKE_ZJ.SIZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.SIZBPHLV, false);
                        listPerforItem.Add(perforItem16);
                        LvItemList.Add(perforItem16.evaluate);


                        //四轴左轮阻滞率(%)
                        performanceItem perforItem17 = new performanceItem();
                        perforItem17.itemCode = "retarding_force_left_4";
                        perforItem17.detectData = m_RESULT_BRAKE_ZJ.SIZZZZLV;
                        perforItem17.standardValue = elt + m_RESULT_BRAKE_ZJ.SIZZZLVXZBZ;
                        perforItem17.evaluate = m_RESULT_BRAKE_ZJ.SIZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem17);
                        KeyItemList.Add(perforItem17.evaluate);

                        //四轴右轮阻滞率(%)
                        performanceItem perforItem18 = new performanceItem();
                        perforItem18.itemCode = "retarding_force_right_4";
                        perforItem18.detectData = m_RESULT_BRAKE_ZJ.SIZYZZLV;
                        perforItem18.standardValue = elt + m_RESULT_BRAKE_ZJ.SIZZZLVXZBZ;
                        perforItem18.evaluate = m_RESULT_BRAKE_ZJ.SIZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem18);
                        KeyItemList.Add(perforItem18.evaluate);

                        //五轴制动率(%)
                        performanceItem perforItem19 = new performanceItem();
                        perforItem19.itemCode = "brake_rate_5";
                        perforItem19.detectData = m_RESULT_BRAKE_ZJ.WZZDLV;
                        perforItem19.standardValue = egt + m_RESULT_BRAKE_ZJ.WZZDLVBZ;
                        perforItem19.evaluate = m_RESULT_BRAKE_ZJ.WZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem19);
                        KeyItemList.Add(perforItem19.evaluate);

                        //五轴不平衡率(%)
                        performanceItem perforItem20 = new performanceItem();
                        perforItem20.itemCode = "unbalance_rate_5";
                        perforItem20.detectData = m_RESULT_BRAKE_ZJ.WZBPHLV;
                        perforItem20.standardValue = elt + m_RESULT_BRAKE_ZJ.WZBPHLVBZ;
                        perforItem20.evaluate = m_RESULT_BRAKE_ZJ.WZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.WZBPHLV, false);
                        listPerforItem.Add(perforItem20);
                        LvItemList.Add(perforItem20.evaluate);


                        //五轴左轮阻滞率(%)
                        performanceItem perforItem21 = new performanceItem();
                        perforItem21.itemCode = "retarding_force_left_5";
                        perforItem21.detectData = m_RESULT_BRAKE_ZJ.WZZZZLV;
                        perforItem21.standardValue = elt + m_RESULT_BRAKE_ZJ.WZZZLVXZBZ;
                        perforItem21.evaluate = m_RESULT_BRAKE_ZJ.WZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem21);
                        KeyItemList.Add(perforItem21.evaluate);

                        //五轴右轮阻滞率(%)
                        performanceItem perforItem22 = new performanceItem();
                        perforItem22.itemCode = "retarding_force_right_5";
                        perforItem22.detectData = m_RESULT_BRAKE_ZJ.WZYZZLV;
                        perforItem22.standardValue = elt + m_RESULT_BRAKE_ZJ.WZZZLVXZBZ;
                        perforItem22.evaluate = m_RESULT_BRAKE_ZJ.WZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem22);
                        KeyItemList.Add(perforItem22.evaluate);

                        //六轴制动率(%)
                        performanceItem perforItem23 = new performanceItem();
                        perforItem23.itemCode = "brake_rate_6";
                        perforItem23.detectData = m_RESULT_BRAKE_ZJ.LZZDLV;
                        perforItem23.standardValue = egt + m_RESULT_BRAKE_ZJ.LZZDLVBZ;
                        perforItem23.evaluate = m_RESULT_BRAKE_ZJ.LZZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem23);
                        KeyItemList.Add(perforItem23.evaluate);

                        //六轴不平衡率(%)
                        performanceItem perforItem24 = new performanceItem();
                        perforItem24.itemCode = "unbalance_rate_6";
                        perforItem24.detectData = m_RESULT_BRAKE_ZJ.LZBPHLV;
                        perforItem24.standardValue = elt + m_RESULT_BRAKE_ZJ.LZBPHLVBZ;
                        perforItem24.evaluate = m_RESULT_BRAKE_ZJ.LZBPHLV_PD.To_Unbalance_Result(m_RESULT_BRAKE_ZJ.LZBPHLV, false);
                        listPerforItem.Add(perforItem24);
                        LvItemList.Add(perforItem24.evaluate);


                        //六轴左轮阻滞率(%)
                        performanceItem perforItem25 = new performanceItem();
                        perforItem25.itemCode = "retarding_force_left_6";
                        perforItem25.detectData = m_RESULT_BRAKE_ZJ.LZZZZLV;
                        perforItem25.standardValue = elt + m_RESULT_BRAKE_ZJ.LZZZLVXZBZ;
                        perforItem25.evaluate = m_RESULT_BRAKE_ZJ.LZZZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem25);
                        KeyItemList.Add(perforItem25.evaluate);

                        //六轴右轮阻滞率(%)
                        performanceItem perforItem26 = new performanceItem();
                        perforItem26.itemCode = "retarding_force_right_6";
                        perforItem26.detectData = m_RESULT_BRAKE_ZJ.LZYZZLV;
                        perforItem26.standardValue = elt + m_RESULT_BRAKE_ZJ.LZZZLVXZBZ;
                        perforItem26.evaluate = m_RESULT_BRAKE_ZJ.LZYZZL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem26);
                        KeyItemList.Add(perforItem25.evaluate);

                        //单车（牵引车）整车制动率(%)
                        performanceItem perforItem27 = new performanceItem();
                        perforItem27.itemCode = "tractor_whole_vehicle_brake_rate";
                        perforItem27.detectData = m_RESULT_BRAKE_ZJ.ZCZDLV;
                        perforItem27.standardValue = egt + m_RESULT_BRAKE_ZJ.ZCZDLVBZ.To_Int_Str("60");
                        perforItem27.evaluate = m_RESULT_BRAKE_ZJ.ZCZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem27);
                        KeyItemList.Add(perforItem27.evaluate);

                        //单车（牵引车）驻车制动率(%)
                        performanceItem perforItem29 = new performanceItem();
                        perforItem29.itemCode = "tractor_whole_vehicle_park_brake_rate";
                        perforItem29.detectData = m_RESULT_BRAKE_ZJ.ZCSZDLV;
                        perforItem29.standardValue = egt + m_RESULT_BRAKE_ZJ.SZDLVBZ;
                        perforItem29.evaluate = m_RESULT_BRAKE_ZJ.SZDLV_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem29);
                        KeyItemList.Add(perforItem29.evaluate);

                        if (false)
                        {
                            //挂车整车制动率(%)
                            performanceItem perforItem28 = new performanceItem();
                            perforItem28.itemCode = "trailer_whole_vehicle_brake_rate";
                            perforItem28.detectData = "";
                            perforItem28.standardValue = egt + "";
                            perforItem28.evaluate = "";
                            listPerforItem.Add(perforItem28);
                            KeyItemList.Add(perforItem28.evaluate);


                            //列车整车驻车制动率(%)
                            performanceItem perforItem30 = new performanceItem();
                            perforItem30.itemCode = "trailer_whole_vehicle_park_brake_rate";
                            perforItem30.detectData = "";
                            perforItem30.standardValue = egt + "";
                            perforItem30.evaluate = "";
                            listPerforItem.Add(perforItem30);
                            KeyItemList.Add(perforItem30.evaluate);

                            //列车制动时序
                            performanceItem perforItem31 = new performanceItem();
                            perforItem31.itemCode = "brake_seq";
                            perforItem31.detectData = "";
                            perforItem31.standardValue = egt + "";
                            perforItem31.evaluate = "";
                            listPerforItem.Add(perforItem31);

                            //列车制动协调时间（s）
                            performanceItem perforItem32 = new performanceItem();
                            perforItem32.itemCode = "brake_coordinate_time";
                            perforItem32.detectData = "";
                            perforItem32.standardValue = egt + "";
                            perforItem32.evaluate = "";
                            listPerforItem.Add(perforItem32);


                            //牵引车/列车整车制动率比(%)
                            performanceItem perforItem33 = new performanceItem();
                            perforItem33.itemCode = "vehicle_brake_rate_tractor_train";
                            perforItem33.detectData = "";
                            perforItem33.standardValue = egt + "";
                            perforItem33.evaluate = "";
                            listPerforItem.Add(perforItem33);


                            //挂车/列车整车制动率比(%)
                            performanceItem perforItem34 = new performanceItem();
                            perforItem34.itemCode = "vehicle_brake_rate_trailer_train";
                            perforItem34.detectData = "";
                            perforItem34.standardValue = egt + "";
                            perforItem34.evaluate = "";
                            listPerforItem.Add(perforItem34);
                        }


                        if (DetectItem.Contains("R"))
                        {
                            if (m_RESULT_ROAD != null)
                            {
                                //路试MFDD（m/s²）
                                performanceItem perforItem35 = new performanceItem();
                                perforItem35.itemCode = "mfdd";
                                perforItem35.detectData = m_RESULT_ROAD.MFDD;
                                perforItem35.standardValue = egt + "";
                                perforItem35.evaluate = "";
                                listPerforItem.Add(perforItem35);


                                //路试制动稳定性
                                performanceItem perforItem36 = new performanceItem();
                                perforItem36.itemCode = "road_test_brake_stability";
                                perforItem36.detectData = "";
                                perforItem36.standardValue = "稳定";
                                perforItem36.evaluate = "";
                                listPerforItem.Add(perforItem36);


                                //路试坡道驻车情况
                                performanceItem perforItem37 = new performanceItem();
                                perforItem37.itemCode = "road_test_park_result";
                                perforItem37.detectData = "";
                                perforItem37.standardValue = "不溜坡";
                                perforItem37.evaluate = "";
                                listPerforItem.Add(perforItem37);


                                //路试制动距离(m)
                                performanceItem perforItem38 = new performanceItem();
                                perforItem38.itemCode = "road_test_brake_distance";
                                perforItem38.detectData = "";
                                perforItem38.standardValue = elt + "";
                                perforItem38.evaluate = "";
                                listPerforItem.Add(perforItem38);
                            }
                        }
                    }
                    if (DetectItem.Contains("X1") && m_RESULT_SDS != null)
                    {
                        //高怠速HC（10-6）
                        performanceItem perforItem39 = new performanceItem();
                        perforItem39.itemCode = "high_hc";
                        perforItem39.detectData = m_RESULT_SDS.GDSHC;
                        perforItem39.standardValue = elt + m_RESULT_SDS.GDSHCXZ;
                        perforItem39.evaluate = m_RESULT_SDS.GDSHC_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem39);


                        //高怠速CO（%）
                        performanceItem perforItem40 = new performanceItem();
                        perforItem40.itemCode = "high_co";
                        perforItem40.detectData = m_RESULT_SDS.GDSCO;
                        perforItem40.standardValue = elt + m_RESULT_SDS.GDSCOXZ.To_Double(1);
                        perforItem40.evaluate = m_RESULT_SDS.GDSCO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem40);


                        //高怠速λ
                        performanceItem perforItem41 = new performanceItem();
                        perforItem41.itemCode = "high_l";
                        perforItem41.detectData = m_RESULT_SDS.GLKQXS;
                        perforItem41.standardValue = string.Format("{0}~{1}", m_RESULT_SDS.GLKQXSXX.To_Double(2), m_RESULT_SDS.GLKQXSSX.To_Double(2));
                        perforItem41.evaluate = m_RESULT_SDS.GLKQXS_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem41);


                        //怠速HC（10-6）
                        performanceItem perforItem42 = new performanceItem();
                        perforItem42.itemCode = "low_hc";
                        perforItem42.detectData = m_RESULT_SDS.DSHC;
                        perforItem42.standardValue = elt + m_RESULT_SDS.DSHCXZ.To_Double(0);
                        perforItem42.evaluate = m_RESULT_SDS.DSHC_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem42);


                        //怠速CO（%）
                        performanceItem perforItem43 = new performanceItem();
                        perforItem43.itemCode = "low_co";
                        perforItem43.detectData = m_RESULT_SDS.DSCO;
                        perforItem43.standardValue = elt + m_RESULT_SDS.DSCOXZ.To_Double(1);
                        perforItem43.evaluate = m_RESULT_SDS.DSCO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem43);

                    }
                    if (DetectItem.Contains("X2") && m_RESULT_ASM != null)
                    {
                        //稳态5025工况CO（%）
                        performanceItem perforItem44 = new performanceItem();
                        perforItem44.itemCode = "co_5025";
                        perforItem44.detectData = m_RESULT_ASM.CO5025JG;
                        perforItem44.standardValue = elt + m_RESULT_ASM.CO5025XZ.To_Double(1);
                        perforItem44.evaluate = m_RESULT_ASM.CO5025_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem44);


                        //稳态5025工况HC（10-6）
                        performanceItem perforItem45 = new performanceItem();
                        perforItem45.itemCode = "hc_5025";
                        perforItem45.detectData = m_RESULT_ASM.HC5025JG;
                        perforItem45.standardValue = elt + m_RESULT_ASM.HC5025XZ.To_Double(0);
                        perforItem45.evaluate = m_RESULT_ASM.HC5025_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem45);


                        //稳态5025工况NO（10-6）
                        performanceItem perforItem46 = new performanceItem();
                        perforItem46.itemCode = "no_5025";
                        perforItem46.detectData = m_RESULT_ASM.NO5025JG;
                        perforItem46.standardValue = elt + m_RESULT_ASM.NO5025XZ.To_Double(0);
                        perforItem46.evaluate = m_RESULT_ASM.NO5025_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem46);

                        if (string.IsNullOrEmpty(m_RESULT_ASM.ASM_2540_PD) && m_RESULT_ASM.ASM_2540_PD != "0")
                        {
                            //稳态2540工况CO（%）
                            performanceItem perforItem47 = new performanceItem();
                            perforItem47.itemCode = "co_2540";
                            perforItem47.detectData = m_RESULT_ASM.CO2540JG;
                            perforItem47.standardValue = elt + m_RESULT_ASM.CO2540XZ.To_Double(1);
                            perforItem47.evaluate = m_RESULT_ASM.CO2540_PD.To_Net_ZJPD();
                            listPerforItem.Add(perforItem47);


                            //稳态2540工况HC（10-6）
                            performanceItem perforItem48 = new performanceItem();
                            perforItem48.itemCode = "hc_2540";
                            perforItem48.detectData = m_RESULT_ASM.HC2540JG;
                            perforItem48.standardValue = elt + m_RESULT_ASM.HC2540XZ.To_Double(0);
                            perforItem48.evaluate = m_RESULT_ASM.HC2540_PD.To_Net_ZJPD();
                            listPerforItem.Add(perforItem48);


                            //稳态2540工况NO（10-6）
                            performanceItem perforItem49 = new performanceItem();
                            perforItem49.itemCode = "no_2540";
                            perforItem49.detectData = m_RESULT_ASM.NO2540JG;
                            perforItem49.standardValue = elt + m_RESULT_ASM.NO2540XZ.To_Double(0);
                            perforItem49.evaluate = m_RESULT_ASM.NO2540_PD;
                            listPerforItem.Add(perforItem49);
                        }
                    }


                    if (DetectItem.Contains("X3") && m_RESULT_VMAS != null)
                    {
                        //简易瞬态工况CO（g/km）
                        performanceItem perforItem50 = new performanceItem();
                        perforItem50.itemCode = "vmas_co";
                        perforItem50.detectData = m_RESULT_VMAS.COJG;
                        perforItem50.standardValue = elt + m_RESULT_VMAS.COXZ.To_Double(1);
                        perforItem50.evaluate = m_RESULT_VMAS.CO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem50);


                        //简易瞬态工况HC（g/km）
                        performanceItem perforItem51 = new performanceItem();
                        perforItem51.itemCode = "vmas_hc";
                        perforItem51.detectData = m_RESULT_VMAS.HCJG;
                        perforItem51.standardValue = elt + m_RESULT_VMAS.HCXZ.To_Double(1);
                        perforItem51.evaluate = m_RESULT_VMAS.HC_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem51);


                        //简易瞬态工况NO（g/km）
                        performanceItem perforItem52 = new performanceItem();
                        perforItem52.itemCode = "vmas_no";
                        perforItem52.detectData = m_RESULT_VMAS.NOJG;
                        perforItem52.standardValue = elt + m_RESULT_VMAS.NOXZ.To_Double(1);
                        perforItem52.evaluate = m_RESULT_VMAS.NO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem52);


                        //简易瞬态工况HC+NO（g/km）
                        performanceItem perforItem53 = new performanceItem();
                        perforItem53.itemCode = "vmas_hc_no";
                        perforItem53.detectData = m_RESULT_VMAS.HC_NOJG;
                        perforItem53.standardValue = elt + m_RESULT_VMAS.HC_NOXZ.To_Double(1);
                        perforItem53.evaluate = m_RESULT_VMAS.HC_NO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem53);

                    }

                    if (DetectItem.Contains("X4") && m_RESULT_ZYJS != null)
                    {
                        //光吸收系数（m-1）
                        performanceItem perforItem54 = new performanceItem();
                        perforItem54.itemCode = "ratio";
                        perforItem54.detectData = m_RESULT_ZYJS.ZYJSPJZ;
                        perforItem54.standardValue = elt + m_RESULT_ZYJS.ZYJSXZ.To_Double(1);
                        perforItem54.evaluate = m_RESULT_ZYJS.ZYJS_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem54);
                    }

                    if (DetectItem.Contains("X6") && m_RESULT_ZYJS != null)
                    {
                        //滤纸烟度（BSU）
                        performanceItem perforItem55 = new performanceItem();
                        perforItem55.itemCode = "smoke";
                        perforItem55.detectData = m_RESULT_ZYJS.ZYJSPJZ;
                        perforItem55.standardValue = elt + m_RESULT_ZYJS.ZYJSXZ.To_Double(1);
                        perforItem55.evaluate = m_RESULT_ZYJS.ZYJS_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem55);
                    }

                    if (DetectItem.Contains("X5") && m_RESULT_LD != null)
                    {
                        //加载减速工况100%（m-1）
                        performanceItem perforItem56 = new performanceItem();
                        perforItem56.itemCode = "load_deceleration_condition_100";
                        perforItem56.detectData = m_RESULT_LD.GXSXS100;
                        perforItem56.standardValue = elt + m_RESULT_LD.GXSXSXZ.To_Double(2);
                        perforItem56.evaluate = m_RESULT_LD.LD_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem56);


                        //加载减速工况90%（m-1）
                        performanceItem perforItem57 = new performanceItem();
                        perforItem57.itemCode = "load_deceleration_condition_90";
                        perforItem57.detectData = m_RESULT_LD.GXSXS90;
                        perforItem57.standardValue = elt + m_RESULT_LD.GXSXSXZ.To_Double(2);
                        perforItem57.evaluate = m_RESULT_LD.LD_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem57);


                        //加载减速工况80%（m-1）
                        performanceItem perforItem58 = new performanceItem();
                        perforItem58.itemCode = "load_deceleration_condition_80";
                        perforItem58.detectData = m_RESULT_LD.GXSXS80;
                        perforItem58.standardValue = elt + m_RESULT_LD.GXSXSXZ.To_Double(2);
                        perforItem58.evaluate = m_RESULT_LD.LD_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem58);


                        //实测最大轮边功率（kw）
                        performanceItem perforItem59 = new performanceItem();
                        perforItem59.itemCode = "max_wheel_side_power";
                        perforItem59.detectData = m_RESULT_LD.GLJG;
                        perforItem59.standardValue = egt + m_RESULT_LD.GLXZ.To_Double(1);
                        perforItem59.evaluate = m_RESULT_LD.GL_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem59);

                        performanceItem perforItem80 = new performanceItem();
                        perforItem80.itemCode = "nox_80";
                        perforItem80.detectData = m_RESULT_LD.NO80;
                        perforItem80.standardValue = elt + m_RESULT_LD.NOXZ.To_Double(0);
                        perforItem80.evaluate = m_RESULT_LD.NO_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem80);
                    }


                    if (DetectItem.Contains("H") && m_RESULT_LAMP_ZJ != null)
                    {
                        //左外灯远光光强(cd)
                        performanceItem perforItem60 = new performanceItem();
                        perforItem60.itemCode = "left_out_far_light_intensity";
                        perforItem60.detectData = m_RESULT_LAMP_ZJ.ZWDYGGQ;
                        perforItem60.standardValue = egt + m_RESULT_LAMP_ZJ.DGGQXZ;
                        perforItem60.evaluate = m_RESULT_LAMP_ZJ.ZWDYGGQ_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem60);
                        KeyItemList.Add(perforItem60.evaluate);


                        //左外灯远光垂直偏移量(H)
                        performanceItem perforItem61 = new performanceItem();
                        perforItem61.itemCode = "left_out_far_light_vertical_offset";
                        perforItem61.detectData = m_RESULT_LAMP_ZJ.ZWDYGCZPY;
                        perforItem61.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.YGCZPYXZXX, m_RESULT_LAMP_ZJ.YGCZPYXZSX);
                        perforItem61.evaluate = m_RESULT_LAMP_ZJ.ZWDYGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem61);
                        NormalItemList.Add(perforItem61.evaluate);


                        //左外灯远光水平偏移量(mm/10m)
                        performanceItem perforItem62 = new performanceItem();
                        perforItem62.itemCode = "left_out_far_light_horizontal_offset";
                        perforItem62.detectData = m_RESULT_LAMP_ZJ.ZWDYGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.ZWDYGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.ZWDYGSPPYL;
                        perforItem62.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.YGZDZPXZ, R + m_RESULT_LAMP_ZJ.YGZDYPXZ);
                        perforItem62.evaluate = m_RESULT_LAMP_ZJ.ZWDYGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem62);


                        //左外灯近光垂直偏移量(H)
                        performanceItem perforItem63 = new performanceItem();
                        perforItem63.itemCode = "left_in_near_light_vertical_offset";
                        perforItem63.detectData = m_RESULT_LAMP_ZJ.ZWDJGCZPY;
                        perforItem63.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.JGCZPYXZXX, m_RESULT_LAMP_ZJ.JGCZPYXZSX);
                        perforItem63.evaluate = m_RESULT_LAMP_ZJ.ZWDJGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem63);
                        NormalItemList.Add(perforItem63.evaluate);


                        //左外灯近光水平偏移量(mm/10m)
                        performanceItem perforItem64 = new performanceItem();
                        perforItem64.itemCode = "left_out_near_light_horizontal_offset";
                        perforItem64.detectData = m_RESULT_LAMP_ZJ.ZWDJGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.ZWDJGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.ZWDJGSPPYL;
                        perforItem64.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.JGZDZPXZ, R + m_RESULT_LAMP_ZJ.JGZDYPXZ);
                        perforItem64.evaluate = m_RESULT_LAMP_ZJ.ZWDJGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem64);


                        //左内灯远光光强(cd)
                        performanceItem perforItem65 = new performanceItem();
                        perforItem65.itemCode = "left_in_far_light_intensity";
                        perforItem65.detectData = m_RESULT_LAMP_ZJ.ZNDYGGQ;
                        perforItem65.standardValue = egt + m_RESULT_LAMP_ZJ.DGGQXZ;
                        perforItem65.evaluate = m_RESULT_LAMP_ZJ.ZNDYGGQ_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem65);
                        KeyItemList.Add(perforItem65.evaluate);

                        //左内灯远光垂直偏移量(H)
                        performanceItem perforItem66 = new performanceItem();
                        perforItem66.itemCode = "left_in_far_light_vertical_offset";
                        perforItem66.detectData = m_RESULT_LAMP_ZJ.ZNDYGCZPY;
                        perforItem66.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.YGCZPYXZXX, m_RESULT_LAMP_ZJ.YGCZPYXZSX); ;
                        perforItem66.evaluate = m_RESULT_LAMP_ZJ.ZNDYGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem66);
                        NormalItemList.Add(perforItem66.evaluate);


                        //左内灯远光水平偏移量(mm/10m)
                        performanceItem perforItem67 = new performanceItem();
                        perforItem67.itemCode = "left_in_far_light_horizontal_offset";
                        perforItem67.detectData = m_RESULT_LAMP_ZJ.ZNDYGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.ZNDYGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.ZNDYGSPPYL;
                        perforItem67.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.YGZDZPXZ, R + m_RESULT_LAMP_ZJ.YGZDYPXZ);
                        perforItem67.evaluate = m_RESULT_LAMP_ZJ.ZNDYGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem67);


                        //右外灯远光光强(cd)
                        performanceItem perforItem68 = new performanceItem();
                        perforItem68.itemCode = "right_out_far_light_intensity";
                        perforItem68.detectData = m_RESULT_LAMP_ZJ.YWDYGGQ;
                        perforItem68.standardValue = egt + m_RESULT_LAMP_ZJ.DGGQXZ;
                        perforItem68.evaluate = m_RESULT_LAMP_ZJ.YWDYGGQ_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem68);
                        KeyItemList.Add(perforItem68.evaluate);

                        //右外灯远光垂直偏移量(H)
                        performanceItem perforItem69 = new performanceItem();
                        perforItem69.itemCode = "right_out_far_light_vertical_offset";
                        perforItem69.detectData = m_RESULT_LAMP_ZJ.YWDYGCZPY;
                        perforItem69.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.YGCZPYXZXX, m_RESULT_LAMP_ZJ.YGCZPYXZSX);
                        perforItem69.evaluate = m_RESULT_LAMP_ZJ.YWDYGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem69);
                        NormalItemList.Add(perforItem69.evaluate);


                        //右外灯远光水平偏移量(mm/10m)
                        performanceItem perforItem70 = new performanceItem();
                        perforItem70.itemCode = "right_out_far_light_horizontal_offset";
                        perforItem70.detectData = m_RESULT_LAMP_ZJ.YWDYGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.YWDYGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.YWDYGSPPYL;
                        perforItem70.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.YGYDZPXZ, R + m_RESULT_LAMP_ZJ.YGYDYPXZ);
                        perforItem70.evaluate = m_RESULT_LAMP_ZJ.YWDYGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem70);


                        //右外灯近光垂直偏移量(H)
                        performanceItem perforItem71 = new performanceItem();
                        perforItem71.itemCode = "right_out_near_light_vertical_offset";
                        perforItem71.detectData = m_RESULT_LAMP_ZJ.YWDJGCZPY;
                        perforItem71.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.JGCZPYXZXX, m_RESULT_LAMP_ZJ.JGCZPYXZSX);
                        perforItem71.evaluate = m_RESULT_LAMP_ZJ.YWDJGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem71);
                        NormalItemList.Add(perforItem71.evaluate);


                        //右外灯近光水平偏移量(mm/10m)
                        performanceItem perforItem72 = new performanceItem();
                        perforItem72.itemCode = "right_out_near_light_horizontal_offset";
                        perforItem72.detectData = m_RESULT_LAMP_ZJ.YWDJGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.YWDJGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.YWDJGSPPYL;
                        perforItem72.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.JGYDZPXZ, R + m_RESULT_LAMP_ZJ.JGYDYPXZ);
                        perforItem72.evaluate = m_RESULT_LAMP_ZJ.YWDJGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem72);


                        //右内灯远光光强(cd)
                        performanceItem perforItem73 = new performanceItem();
                        perforItem73.itemCode = "right_in_far_light_intensity";
                        perforItem73.detectData = m_RESULT_LAMP_ZJ.YNDYGGQ;
                        perforItem73.standardValue = egt + m_RESULT_LAMP_ZJ.DGGQXZ;
                        perforItem73.evaluate = m_RESULT_LAMP_ZJ.YNDYGGQ_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem73);
                        KeyItemList.Add(perforItem73.evaluate);

                        //右内灯远光垂直偏移量(H)
                        performanceItem perforItem74 = new performanceItem();
                        perforItem74.itemCode = "light_beam_vertical_offset";
                        perforItem74.detectData = m_RESULT_LAMP_ZJ.YNDYGCZPY;
                        perforItem74.standardValue = string.Format("{0}~{1}", m_RESULT_LAMP_ZJ.YGCZPYXZXX, m_RESULT_LAMP_ZJ.YGCZPYXZSX);
                        perforItem74.evaluate = m_RESULT_LAMP_ZJ.YNDYGCZPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem74);
                        NormalItemList.Add(perforItem74.evaluate);

                        //右内灯远光水平偏移量(mm/10m)
                        performanceItem perforItem75 = new performanceItem();
                        perforItem75.itemCode = "light_beam_horizontal_offset";
                        perforItem75.detectData = m_RESULT_LAMP_ZJ.YNDYGSPPYL.Contains("-") ? L + m_RESULT_LAMP_ZJ.YNDYGSPPYL.Replace("-", "") : R + m_RESULT_LAMP_ZJ.YNDYGSPPYL;
                        perforItem75.standardValue = string.Format("{0}~{1}", L + m_RESULT_LAMP_ZJ.YGYDZPXZ, R + m_RESULT_LAMP_ZJ.YGYDYPXZ);
                        perforItem75.evaluate = m_RESULT_LAMP_ZJ.YNDYGSPPY_PD.To_Net_ZJPD();
                        listPerforItem.Add(perforItem75);

                    }
                }

                if (DetectItem.Contains("S1") && m_RESULT_SPEED_ZJ != null)
                {
                    //车速表（km/h）
                    performanceItem perforItem76 = new performanceItem();
                    perforItem76.itemCode = "speed_meter";
                    perforItem76.detectData = m_RESULT_SPEED_ZJ.SCSD;
                    perforItem76.standardValue = string.Format("{0}~{1}", "32.8", "40" /*m_RESULT_SPEED_ZJ.SDBZXX, m_RESULT_SPEED_ZJ.SDBZSX*/);
                    perforItem76.evaluate = m_RESULT_SPEED_ZJ.SD_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem76);
                    NormalItemList.Add(perforItem76.evaluate);
                }

                if (m_RESULT_SPEAKER != null)
                {
                    //喇叭声压级（dB(A)）
                    performanceItem perforItem77 = new performanceItem();
                    perforItem77.itemCode = "horn_sound_pressure_level";
                    perforItem77.detectData = m_RESULT_SPEAKER.SCSJZ;
                    perforItem77.standardValue = "90~115";
                    perforItem77.evaluate = m_RESULT_SPEAKER.SJZ_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem77);
                    KeyItemList.Add(perforItem77.evaluate);
                }
                //if (!IsHC || !chkTrustAJ.Checked)
                //{
                if (DetectItem.Contains("A") && m_RESULT_SIDESLIP_ZJ != null /*&& (m_LOGIN_VEHICLE_INFO.ZXZLXDH.To_ZXZSL().Equals(2))*/)  //非独立悬架
                {
                    //侧滑量：第一转向轮(m/km)
                    performanceItem perforItem78 = new performanceItem();
                    perforItem78.itemCode = "slip_first_wheel";
                    perforItem78.detectData = m_RESULT_SIDESLIP_ZJ.QQCHSCZ; //ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "QQCHSCZ").Replace("-", "").Replace("+", "");
                    perforItem78.standardValue = "-5~+5";
                    perforItem78.evaluate = m_RESULT_SIDESLIP_ZJ.QQCH_PD.To_Net_ZJPD();//  ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "QQCH_PD");
                    listPerforItem.Add(perforItem78);


                    //侧滑量：第二转向轮(m/km)
                    if (!string.IsNullOrEmpty(m_RESULT_SIDESLIP_ZJ.HQCHSCZ))
                    {
                        performanceItem perforItem79 = new performanceItem();
                        perforItem79.itemCode = "slip_second_wheel";
                        perforItem79.detectData = m_RESULT_SIDESLIP_ZJ.HQCHSCZ;// ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "HQCHSCZ").Replace("-", "").Replace("+", "");
                        perforItem79.standardValue = "-5~+5";
                        perforItem79.evaluate = m_RESULT_SIDESLIP_ZJ.HQCH_PD.To_Net_ZJPD();// ExtendMethod.GetDsYQMsg(dsYQ, "dtOthers", "HQCH_PD");
                        listPerforItem.Add(perforItem79);
                    }
                }
                //陕西增加悬架
                if (DetectItem.Contains("U") && m_RESULT_SUSPENSION != null)
                {
                    performanceItem perforItem80 = new performanceItem();
                    perforItem80.itemCode = "front_axlelr_suspension_absorptivity";
                    perforItem80.detectData = (m_RESULT_SUSPENSION.QZZLXSLV ?? "-").To_Double(1) +"/"+ (m_RESULT_SUSPENSION.QZYLXSLV ?? "-").To_Double(1);
                    perforItem80.standardValue = "≥40";
                    perforItem80.evaluate = m_RESULT_SUSPENSION.QZXSLVC_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem80);

                    performanceItem perforItem81 = new performanceItem();
                    perforItem81.itemCode = "front_axlelr_suspension_absorptivity_difference";
                    perforItem81.detectData = m_RESULT_SUSPENSION.QZXSLVC.To_Double(1);
                    perforItem81.standardValue = "≤15";
                    perforItem81.evaluate = m_RESULT_SUSPENSION.QZXSLVC_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem81);

                    performanceItem perforItem82 = new performanceItem();
                    perforItem82.itemCode = "back_axlelr_suspension_absorptivity";
                    perforItem82.detectData = (m_RESULT_SUSPENSION.HZZLXSLV?? "-").To_Double(1) + "/" + (m_RESULT_SUSPENSION.HZYLXSLV ??"-").To_Double(1);
                    perforItem82.standardValue = "≥40";
                    perforItem82.evaluate = m_RESULT_SUSPENSION.HZXSLVC_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem82);

                    performanceItem perforItem83 = new performanceItem();
                    perforItem83.itemCode = "back_axlelr_suspension_absorptivity_difference";
                    perforItem83.detectData = m_RESULT_SUSPENSION.HZXSLVC.To_Double(1);
                    perforItem83.standardValue = "≤15";
                    perforItem83.evaluate = m_RESULT_SUSPENSION.HZXSLVC_PD.To_Net_ZJPD();
                    listPerforItem.Add(perforItem83);
                }
                //}
                if(!IsNew)
                    listPerforItem.RemoveAll(x =>x.detectData == null || x.standardValue == null || x.standardValue.Replace("左", "").Replace("~右", "").Replace(egt, "").Replace(elt, "").Equals("") || x.evaluate.Equals("") || x.detectData.Replace("左", "").Replace("右", "").Equals("-") || x.detectData.Replace("左", "").Replace("右", "").Equals(""));
                else
                    listPerforItem.RemoveAll(x => (!x.itemCode.Equals("economy") && !x.itemCode.Equals("power")) &&  (x.detectData == null || x.standardValue == null || x.standardValue.Replace("左", "").Replace("~右", "").Replace(egt, "").Replace(elt, "").Equals("") || x.evaluate.Equals("") || x.detectData.Replace("左", "").Replace("右", "").Equals("-") || x.detectData.Replace("左", "").Replace("右", "").Equals("")));
                #endregion
                detectRpt.performanceItem = listPerforItem;
                #endregion

                string str = "";

                if (KeyItemList.Contains("-1") || NormalItemList.Count(x => x.Equals("-1")) > 6)
                {
                    str = "不合格";
                }
                else if ((NormalItemList.Count(x => x.Equals("-1")) > 3 && NormalItemList.Count(x => x.Equals("-1")) <= 6) || LvItemList.Contains("2"))
                {
                    str = "二级";
                }
                else
                {
                    str = "一级";
                }
                KeyItemList.Clear();
                NormalItemList.Clear();
                LvItemList.Clear();
                logDelegate.BeginInvoke(str, Color.Red, null, null);

                detectRpt.detectResult = str;

                dic.Add("detectReport", detectRpt);
                string content = CombineJson(dic, "shareDetectInfo");
                File.WriteAllText("shareDetectInfo.txt", JsonConvert.SerializeObject(dic,Formatting.Indented));
                string result = SendInfo($"put_data;token={AppHelper.ComprehensiveSetting.Token}", content);
                logDelegate.BeginInvoke(result, Color.Blue, null, null);
                //string strResult = zjNet.SendInfo(string.Format("put_data;token={0}", AppHelper.ComprehensiveSetting.Token), dic, "shareDetectInfo");
            }
            catch (Exception ex)
            {
                logDelegate.BeginInvoke($"[上传异常]:{ex.Message}", Color.Blue, null, null);
            }

        }

        //获取Token
        public void GetToken(LogDelegate logDelegate)
        {
            string result = "";
            AccessTokenEntity entity = null;
            try
            {
                var obj = new
                {
                    username = AppHelper.ComprehensiveSetting.UserCode,
                    password = AppHelper.ComprehensiveSetting.Key
                };
                string content =  CombineJson(obj, "getAccessToken");
                result = SendInfo("get_access_token", content);
                entity = JsonConvert.DeserializeObject<AccessTokenEntity>(result);
                AppHelper.ComprehensiveSetting.Token = entity.access_token;
                logDelegate.BeginInvoke("获取Token:"+AppHelper.ComprehensiveSetting.Token, Color.Blue, null, null);
            }
            catch 
            {
                throw new Exception(result);
            }
        }
        
        //获取所有检测流水号
        private List<string> GetAllTestNo()
        {
            List<string> list = new List<string>();
            if (m_RESULT_VEHICLE_INFO.JCLSH.Contains("-"))
            {
                string jclsh = m_RESULT_VEHICLE_INFO.JCLSH.Split('-')[0];
                int jccs = 1;
                int.TryParse(m_RESULT_VEHICLE_INFO.JCCS, out jccs);
                for (int i = 1; i <= jccs; i++)
                {
                    list.Add(jclsh + '-' + i.ToString().PadLeft(2, '0'));
                }
            }
            return list;
        }

        private string CombineJson(object obj, string type)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("CompanyId", AppHelper.ComprehensiveSetting.CompanyId);
            dic.Add("Source", AppHelper.ComprehensiveSetting.AdministrativeAera);
            dic.Add("IPCType", type);
            JsonSerializerSettings setting = new JsonSerializerSettings(); 
            setting.NullValueHandling = NullValueHandling.Ignore;
            string s = JsonConvert.SerializeObject(obj, Formatting.Indented, setting);
            if (AppHelper.ComprehensiveSetting.WriteJson)
            {
                File.WriteAllText(Path.Combine(AppHelper.ComprehensiveSetting.ResultPath, type + ".json"), s);
            }
            if (AppHelper.ComprehensiveSetting.ReadJson)
            {
                s = File.ReadAllText(Path.Combine(AppHelper.ComprehensiveSetting.ResultPath, type + ".json"));
            }
            dic.Add("IPCType.value", s);
            return JsonConvert.SerializeObject(dic);
        }

        private string SendInfo(string method, string content)
        {
            try
            {
                Uri uri = new Uri(AppHelper.ComprehensiveSetting.url);
                Uri.TryCreate(uri, method, out uri);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "POST";
                byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(content);
                string strReqResult = "";
                using (Stream stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(buf, 0, buf.Length);
                    stream.Close();
                  
                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
                    strReqResult = reader.ReadToEnd();
                    reader.Close();
                    httpWebResponse.Close();
                }
                return strReqResult;
            }
            catch
            {
                throw;
            }
        }

        public  void ShareVehicleInfo(LogDelegate logDelegate)
        {
            ShareVehicleInfo para = new ShareVehicleInfo();
            para.dsId = AppHelper.ComprehensiveSetting.CompanyId;
            para.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
            para.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
            para.vinNo = m_RESULT_VEHICLE_INFO.VIN;
            para.ownerName = m_RESULT_VEHICLE_INFO.SYR;
            para.vehicleBodyColor = m_RESULT_VEHICLE_INFO.CSYS.To_Net_CSYS();
            para.trailerVehicleNo = "";   //挂车牌照号
            para.vehicleBrandModel = m_RESULT_VEHICLE_INFO.PPXH;
            para.transCertificateCode = m_RESULT_VEHICLE_INFO.YYZH;
            para.engineNo = m_RESULT_VEHICLE_INFO.FDJH;
            para.engineModel = m_RESULT_VEHICLE_INFO.FDJXH;
            para.chassisNo = m_RESULT_VEHICLE_INFO.DPXH;
            para.productionDate = m_RESULT_VEHICLE_INFO.CCRQ.To_Net_Date();
            para.registDate = m_RESULT_VEHICLE_INFO.CCDJRQ.To_Net_Date();
            para.vehicleType = m_RESULT_VEHICLE_INFO.CLZLDH;
            if (para.vehicleType.Contains("K"))
            {
                para.busTypeLevel = m_RESULT_VEHICLE_INFO.KCLXDJ.To_Net_KCLXDJ();
            }
            para.brakeModel = m_RESULT_VEHICLE_INFO.ZDFSDH;
            para.parkType = "";
            para.driveType = m_RESULT_VEHICLE_INFO.QDXS;
            para.overallSize = string.Format("{0}×{1}×{2}", m_RESULT_VEHICLE_INFO.CSC, m_RESULT_VEHICLE_INFO.CSK, m_RESULT_VEHICLE_INFO.CSG);
            para.axleAmount = m_RESULT_VEHICLE_INFO.ZZS;
            para.steeringAxleAmount = m_RESULT_VEHICLE_INFO.ZXZLXDH;
            para.driveAxleAmount = m_LOGIN_VEHICLE_INFO.QDZS;
            para.fuelType = m_RESULT_VEHICLE_INFO.RLLBDH;
            para.lampSystem = m_RESULT_VEHICLE_INFO.QZDZ;
            para.vehicleSuspensionForm = m_RESULT_VEHICLE_INFO.ZXZXJXSDH;
            para.vehicleWeight = m_RESULT_VEHICLE_INFO.ZBZL;
            para.approveWeight = string.IsNullOrEmpty(m_RESULT_VEHICLE_INFO.HDZH) ? "0" : m_RESULT_VEHICLE_INFO.HDZH;
            para.totalWeight = m_RESULT_VEHICLE_INFO.ZZL;
            para.ratifiedLoadCapacity = m_RESULT_VEHICLE_INFO.CYS;
            para.seatCount = m_RESULT_VEHICLE_INFO.CYS;
            para.travelMileage = m_RESULT_VEHICLE_INFO.LJXSLC;
            para.farLightCanAdjust = m_RESULT_VEHICLE_INFO.YGGSNFKT;
            para.parkAxle = m_RESULT_VEHICLE_INFO.ZCZWZ;
            para.maxDesignSpeed = "";
            para.isTurbo = "";
            para.isAbs = "";

            string content = "";
            string result = "";

            content = CombineJson(para, "shareVehicleInfo");
            result = SendInfo($"put_data;token={AppHelper.ComprehensiveSetting.Token}", content);

            logDelegate.BeginInvoke($"[上传信息]:{result}", Color.Black, null, null);

            GetVehicleInfoAndSn snEntity = new GetVehicleInfoAndSn();
            snEntity.dsId = AppHelper.ComprehensiveSetting.CompanyId;
            snEntity.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
            snEntity.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
            snEntity.vinNo = m_RESULT_VEHICLE_INFO.VIN;
            content = CombineJson(snEntity, "getVehicleInfoAndDetectSn");
            result = SendInfo($"get_data;token={AppHelper.ComprehensiveSetting.Token}", content);
            try
            {
                ResultEntity resultEntity = JsonConvert.DeserializeObject<ResultEntity>(result);
                if (resultEntity != null && resultEntity.code.Equals("1"))
                {
                    GetVehicleInfoAndSnResult shareVehiclInfoResult = JsonConvert.DeserializeObject<GetVehicleInfoAndSnResult>(resultEntity.data);
                    if (!string.IsNullOrEmpty(shareVehiclInfoResult.detectSn))
                    {
                        m_RESULT_VEHICLE_INFO.ZJLSH = shareVehiclInfoResult.detectSn;
                        Task.Factory.StartNew(() =>
                        {
                            Hashtable hashtable = new Hashtable();
                            string sql = "UPDATE RESULT_VEHICLE_INFO SET ZJLSH = @ZJLSH WHERE JCLSH = @JCLSH";
                            hashtable.Add("ZJLSH", shareVehiclInfoResult.detectSn);
                            hashtable.Add("JCLSH", m_RESULT_VEHICLE_INFO.JCLSH);
                            MssqlHelper.GetInstance().ExcuteNonQuery(sql, hashtable);
                        });
                        logDelegate.BeginInvoke($"{m_RESULT_VEHICLE_INFO.HPHM}登录成功,流水号：{shareVehiclInfoResult.detectSn}", Color.Black, null, null);
                    }
                    else
                    {
                        logDelegate.BeginInvoke($"{m_RESULT_VEHICLE_INFO.HPHM}登录失败", Color.Black, null, null);
                    }
                }
                else
                {
                    logDelegate.BeginInvoke($"{m_RESULT_VEHICLE_INFO.HPHM}登录失败：{resultEntity.status}", Color.Black, null, null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"[{ex.Message}]:{result}");
            }

        }

        public void SharePrintImage(LogDelegate logDelegate, bool UseSafetyTechnologyResult)
        {
            try
            {
                if (m_RESULT_IMAGE != null && !string.IsNullOrEmpty(m_RESULT_IMAGE.JCLSH))
                {
                    byte[] bLampImage = null;
                    byte[] bBrakeImage = null;
                    byte[] bPower_Image = null;
                    if (AppHelper.ComprehensiveSetting.UseImgChange_Station)
                    {
                        bLampImage = Tools.ChageImage(m_RESULT_IMAGE.Lamp_Image, AppHelper.ComprehensiveSetting.X_Station, AppHelper.ComprehensiveSetting.Y_Station);
                        bBrakeImage = Tools.ChageImage(m_RESULT_IMAGE.Brake_Image, AppHelper.ComprehensiveSetting.X_Station, AppHelper.ComprehensiveSetting.Y_Station);
                        bPower_Image = Tools.ChageImage(m_RESULT_IMAGE.Power_Image, AppHelper.ComprehensiveSetting.X_Station, AppHelper.ComprehensiveSetting.Y_Station);
                    }
                    else
                    {
                        bLampImage = m_RESULT_IMAGE.Lamp_Image;
                        bBrakeImage = m_RESULT_IMAGE.Brake_Image;
                        bPower_Image = m_RESULT_IMAGE.Power_Image;
                    }


                    List<printImage> listPrintImg = new List<printImage>();

                    if ((!IsHC || !UseSafetyTechnologyResult) && bBrakeImage != null)
                    {
                        printImage printImgBrake = new printImage();
                        printImgBrake.imageType = "1";
                        printImgBrake.base64Image = m_Base64 + Convert.ToBase64String(bBrakeImage);
                        printImgBrake.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                        printImgBrake.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                        printImgBrake.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                        printImgBrake.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                        printImgBrake.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                        listPrintImg.Add(printImgBrake);
                    }
                    if (bPower_Image != null)
                    { 
                        printImage printImgPower = new printImage();
                        printImgPower.imageType = "3";
                        printImgPower.base64Image = m_Base64 + Convert.ToBase64String(bPower_Image);
                        printImgPower.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                        printImgPower.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                        printImgPower.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                        printImgPower.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                        printImgPower.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                        listPrintImg.Add(printImgPower);
                    }
                    if ((!IsHC || !UseSafetyTechnologyResult) && bLampImage != null)
                    {
                        printImage printImgLamp = new printImage();
                        printImgLamp.imageType = "2";
                        printImgLamp.base64Image = m_Base64 + Convert.ToBase64String(bLampImage);
                        printImgLamp.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                        printImgLamp.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                        printImgLamp.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                        printImgLamp.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                        printImgLamp.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                        listPrintImg.Add(printImgLamp);
                    }

                    if (listPrintImg.Count > 0)
                    {
                        Dictionary<string, object> dic = new Dictionary<string, object>() { { "printImage", listPrintImg } };
                        string content = CombineJson(dic, "sharePrintImage");
                        string result = SendInfo($"put_data;token={AppHelper.ComprehensiveSetting.Token}", content);
                        try
                        {
                            ResultEntity resultEntity = JsonConvert.DeserializeObject<ResultEntity>(result);
                            logDelegate.BeginInvoke($"[上传工位照片]:{result}", Color.Black, null, null);
                        }
                        catch
                        {
                            throw new Exception(result);
                        }
                    }
                    else
                    {
                        logDelegate.BeginInvoke("图片信息为空!", Color.Black, null, null);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public void ShareReportImage(LogDelegate logDelegate)
        {
            try
            {
                Dictionary<string, List<printImage>> dic = new Dictionary<string, List<printImage>>() { { "reportImage", GetImgByType("2", AppHelper.ComprehensiveSetting.X_AJ, AppHelper.ComprehensiveSetting.Y_AJ, AppHelper.ComprehensiveSetting.UseImgChange_AJ) } };
                if (dic["reportImage"] == null || dic["reportImage"].Count == 0)
                {
                    logDelegate.BeginInvoke("没有找到安检结论照片", Color.Red, null, null);
                }
                else
                {
                    string content = CombineJson(dic, "shareReportImage");
                    string result = SendInfo($"put_data;token={AppHelper.ComprehensiveSetting.Token}", content);
                    try
                    {
                        ResultEntity resultEntity = JsonConvert.DeserializeObject<ResultEntity>(result);
                        if (resultEntity.code == "1")
                        {
                            logDelegate.BeginInvoke("上传安检结论照片成功", Color.Black, null, null);
                        }
                        else
                        {
                            logDelegate.BeginInvoke($"上传安检结论照片失败，{result}", Color.Black, null, null);
                        }
                    }
                    catch
                    {
                        throw new Exception(result);
                    }
                }
            }
            catch 
            {
                throw;
            }
        }

        public void ShareSignatureImage(LogDelegate logDelegate,string author)
        {
            try
            {
                List<SignatureImage> signatureImages = new List<SignatureImage>();
                string authorSignatureImgPath = Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, author + ".jpg");
                string maImgPath = Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, "MA.jpg");
                string officialSealPath = Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, "OfficialSeal.jpg");
                if (File.Exists(authorSignatureImgPath))
                {
                    SignatureImage signature = new SignatureImage();
                    signature.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                    signature.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                    signature.imageType = "1";
                    signature.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                    signature.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                    signature.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                    signature.base64Image = m_Base64 + Convert.ToBase64String(Tools.GetImageByPath(authorSignatureImgPath, 0, 0, false));
                    signatureImages.Add(signature);
                }
                else
                {
                    logDelegate.BeginInvoke("缺少授权签字人签字图片", Color.Red, null, null);
                }

                if (File.Exists(maImgPath))
                {
                    SignatureImage signature = new SignatureImage();
                    signature.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                    signature.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                    signature.imageType = "2";
                    signature.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                    signature.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                    signature.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                    signature.base64Image = m_Base64 + Convert.ToBase64String(Tools.GetImageByPath(maImgPath, 0, 0, false));
                    signatureImages.Add(signature);
                }
                else
                {
                    logDelegate.BeginInvoke("缺少MA印章图片", Color.Red, null, null);
                }


                if (File.Exists(officialSealPath))
                {
                    SignatureImage signature = new SignatureImage();
                    signature.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                    signature.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                    signature.imageType = "3";
                    signature.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                    signature.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                    signature.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                    signature.base64Image = m_Base64 + Convert.ToBase64String(Tools.GetImageByPath(officialSealPath, 0, 0, false));
                    signatureImages.Add(signature);
                }
                else
                {
                    logDelegate.BeginInvoke("缺少检测站公章图片", Color.Red, null, null);
                }


                if (signatureImages.Count > 0)
                {
                    Dictionary<string, List<SignatureImage>> dic = new Dictionary<string, List<SignatureImage>>();
                    dic.Add("signatureImage",signatureImages);
                    string content = CombineJson(dic, "shareSignatureImage");
                    string result = SendInfo($"put_data;token={AppHelper.ComprehensiveSetting.Token}", content);
                    try
                    {
                        ResultEntity resultEntity = JsonConvert.DeserializeObject<ResultEntity>(result);
                        if (resultEntity.code == "1")
                        {
                            logDelegate.BeginInvoke("上传签字人图片，MA印章图片，检测站公章成功", Color.Black, null, null);
                        }
                        else
                        {
                            logDelegate.BeginInvoke($"上传签字人图片，MA印章图片，检测站公章失败，{result}", Color.Black, null, null);
                        }
                    }
                    catch
                    {
                        throw new Exception(result);
                    }
                }
                else
                {
                    logDelegate.BeginInvoke("签字人图片，MA印章图片，检测站公章缺失", Color.Black, null, null);
                }
            }
            catch
            {
                throw;
            }
        }

        private List<printImage> GetImgByType(string strType, int x, int y, bool bChange)
        {
            List<printImage> list = new List<printImage>();
            if (Directory.Exists(Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, m_RESULT_VEHICLE_INFO.HPHM)))
            {
                string[] files = Directory.GetFiles(Path.Combine(AppHelper.ComprehensiveSetting.ImagePath, m_RESULT_VEHICLE_INFO.HPHM), "*.jpg");

                for (int i = 0; i < files.Length; i++)
                {
                    printImage info = new printImage();
                    ImgTypeEntity entity = AppHelper.ComprehensiveSetting.ImgList.FirstOrDefault(t => files[i].Contains(t.ImgName) && t.ImgType.Equals(strType));
                    if (entity != null)
                    {
                        info.imageType = entity.ImgKey;
                        info.detectSn = m_RESULT_VEHICLE_INFO.ZJLSH;
                        info.dsId = AppHelper.ComprehensiveSetting.CompanyId;
                        info.plateColorCode = m_RESULT_VEHICLE_INFO.HPYS.To_Net_HPYS();
                        info.vehicleNo = m_RESULT_VEHICLE_INFO.HPHM;
                        info.vinNo = m_RESULT_VEHICLE_INFO.VIN;
                        info.base64Image = m_Base64 + Convert.ToBase64String(Tools.GetImageByPath(files[i], x, y, bChange));
                        list.Add(info);
                    }
                }
            }
            return list;
        }

         private bool GetIsNewVehicle(string strCCDJRQ, string strGXRQ)
        {
            if (!string.IsNullOrEmpty(strCCDJRQ) && !string.IsNullOrEmpty(strGXRQ))
            {
                return Convert.ToDateTime(strCCDJRQ).AddMonths(3) > Convert.ToDateTime(strGXRQ) ? true : false;
            }

            return false;
        }

    }
}
