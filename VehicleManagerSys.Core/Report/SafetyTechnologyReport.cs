using Live0xUtils.DbUtils.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Dtos.IVS;

namespace VehicleManagerSys.Core.Report
{
    public class SafetyTechnologyReport
    {
        public RESULT_SPEAKER m_RESULT_SPEAKER = null;
        public RESULT_SIDESLIP_ZJ m_RESULT_SIDESLIP_ZJ = null;
        public RESULT_SIDESLIP m_RESULT_SIDESLIP = null;
        public RESULT_ROAD m_RESULT_ROAD = null;
        public RESULT_SUSPENSION m_RESULT_SUSPENSION = null;
        public RESULT_IMAGE m_RESULT_IMAGE = null;
        public LOGIN_VEHICLE_INFO m_LOGIN_VEHICLE_INFO = null;
        public RESULT_CHASISS_MANUAL_ZJ m_RESULT_CHASISS_MANUAL_ZJ = null;
        public RESULT_CHASISS_MANUAL m_RESULT_CHASISS_MANUAL = null;
        public RESULT_SPEED_ZJ m_RESULT_SPEED_ZJ = null;
        public RESULT_VEHICLE_INFO m_RESULT_VEHICLE_INFO = null;
        public RESULT_DPCG m_RESULT_DPCG = null;
        public RESULT_BRAKE_ZJ m_RESULT_BRAKE_ZJ = null;
        public RESULT_BRAKE m_RESULT_BRAKE = null;
        public RESULT_SDS m_RESULT_SDS = null;
        public RESULT_ASM m_RESULT_ASM = null;
        public RESULT_VMAS m_RESULT_VMAS = null;
        public RESULT_ZYJS m_RESULT_ZYJS = null;
        public RESULT_LD m_RESULT_LD = null;
        public RESULT_LAMP_ZJ m_RESULT_LAMP_ZJ = null;
        public RESULT_LAMP m_RESULT_LAMP = null;
        public RESULT_OVERALLSIZE m_RESULT_OVERALLSIZE = null;
        public RESULT_SPEED m_RESULT_SPEED = null;
        private string DetectItem = "";
        private List<string> DetectItemList = new List<string>();
        private string m_testNo { get; set; }

        private static MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        public SafetyTechnologyReport(string testNo)
        {
            m_testNo = testNo;
        }

        private void InitData()
        {
            List<string> testNos = GetAllTestNo();
            if (m_testNo.Contains("-") && m_testNo.Split('-').Length > 1 && testNos != null && testNos.Count > 0)
            {
                string strTestNo = m_testNo.Split('-')[0];

                TaskFactory taskFactory = Task.Factory;
                List<Task> taskList = new List<Task>();
                string sql = "SELECT * FROM {0} WHERE JCLSH IN ({1}) ORDER BY ID ASC";
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_VEHICLE_INFO", strTestNo);
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
                    DetectItem = string.Join(",", items.ToArray());
                }));

                //制动
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_BRAKE_ZJ", strTestNo);
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

                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_BRAKE", strTestNo);
                    List<RESULT_BRAKE> list = _mssqlHelper.QueryList<RESULT_BRAKE>(searchSql, null).ToList();
                    if (list != null && list.Count > 0)
                    {
                        m_RESULT_BRAKE = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            Tools.MergeEntity(m_RESULT_BRAKE, list[i]);
                        }
                    }
                }));

                //灯光
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_LAMP_ZJ", strTestNo);
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

                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_LAMP", strTestNo);
                    List<RESULT_LAMP> list = _mssqlHelper.QueryList<RESULT_LAMP>(searchSql, null).ToList();
                    if (list != null && list.Count > 0)
                    {
                        m_RESULT_LAMP = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            Tools.MergeEntity(m_RESULT_LAMP, list[i]);
                        }
                    }
                }));

                //侧滑
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_SIDESLIP_ZJ", strTestNo);
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

                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_SIDESLIP", strTestNo);
                    List<RESULT_SIDESLIP> list = _mssqlHelper.QueryList<RESULT_SIDESLIP>(searchSql, null).ToList();
                    if (list != null && list.Count > 0)
                    {
                        m_RESULT_SIDESLIP = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            Tools.MergeEntity(m_RESULT_SIDESLIP, list[i]);
                        }
                    }
                }));

                //悬架
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_SUSPENSION", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_SPEAKER", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_CHASISS_MANUAL_ZJ", strTestNo);
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

                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_CHASISS_MANUAL", strTestNo);
                    List<RESULT_CHASISS_MANUAL> list = _mssqlHelper.QueryList<RESULT_CHASISS_MANUAL>(searchSql, null).ToList();
                    if (list != null && list.Count > 0)
                    {
                        m_RESULT_CHASISS_MANUAL = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            Tools.MergeEntity(m_RESULT_CHASISS_MANUAL, list[i]);
                        }
                    }
                }));
                //动力性 油耗
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_DPCG", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_SPEED_ZJ", strTestNo);
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

                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_SPEED", strTestNo);
                    List<RESULT_SPEED> list = _mssqlHelper.QueryList<RESULT_SPEED>(searchSql, null).ToList();
                    if (list != null && list.Count > 0)
                    {
                        m_RESULT_SPEED = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            Tools.MergeEntity(m_RESULT_SPEED, list[i]);
                        }
                    }
                }));

                //LD
                taskList.Add(taskFactory.StartNew(() =>
                {
                    string searchSql = string.Format(sql, "RESULT_LD", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_ASM", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_VMAS", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_SDS", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_ZYJS", strTestNo);
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
                    string searchSql = string.Format(sql, "RESULT_IMAGE", strTestNo);
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
                throw new Exception("找不到对应的安检检测数据");
            }
        }

        private List<string> GetAllTestNo()
        {
            List<string> list = new List<string>();
            if (m_testNo.Contains("-") && m_testNo.Split('-').Length > 1)
            {
                string strTestNo = m_testNo.Split('-')[0];
                string strTimes = m_testNo.Split('-')[1];
                int iTimes = 1;
                int.TryParse(strTimes, out iTimes);
                for (int i = 1; i <= iTimes; i++)
                {
                    list.Add(strTestNo + '-' + i.ToString().PadLeft(2, '0'));
                }
            }
            return list;
        }


        public void CreateReport()
        {
            
        }
         

    }
}
