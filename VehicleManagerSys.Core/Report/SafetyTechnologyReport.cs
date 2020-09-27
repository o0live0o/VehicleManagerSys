using iTextSharp.text;
using iTextSharp.text.pdf;
using Live0xUtils.DbUtils.SqlServer;
using O2S.Components.PDFRender4NET.Printing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Entity.IVS;

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

        private PdfHelper pdfHelper = new PdfHelper();

        private static BaseFont baseFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private iTextSharp.text.Font BoldFont = null;
        private iTextSharp.text.Font NormalFont = null;
        private static Document doc = null;

        public SafetyTechnologyReport(string testNo)
        {
            m_testNo = testNo;
            BoldFont = new iTextSharp.text.Font(baseFont, 15, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            NormalFont = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));

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


        public Bitmap CreateReport()
        {
            Document doc = pdfHelper.CreateDocumentA4(10, 10, 30, 100);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            doc.Open();
            doc.NewPage();
            doc.Add(pdfHelper.CreateTitleParagraph("机动车安全技术检验报告", BoldFont));
            PdfContentByte canvas = writer.DirectContent;

            PdfPCell pdfPCell = null;
            PdfPTable table = pdfHelper.CreateTable(new float[] { 1, 1, 1, 1, 1, 1 }, doc);

            table.AddCell(pdfHelper.CreateNoWidthCell("检验地址：", NormalFont));
            table.AddCell(pdfHelper.CreateNoWidthCell("", NormalFont));
            table.AddCell(pdfHelper.CreateNoWidthCell("", NormalFont));
            table.AddCell(pdfHelper.CreateNoWidthCell("", NormalFont));
            table.AddCell(pdfHelper.CreateNoWidthCell("联系电话：", NormalFont, Element.ALIGN_RIGHT));
            table.AddCell(pdfHelper.CreateNoWidthCell("", NormalFont));

            table.AddCell(pdfHelper.CreateCell("一、基本信息", NormalFont, Element.ALIGN_LEFT, 6, 1));
            table.AddCell(pdfHelper.CreateCell("检验报告编号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("检验机构名称", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));

            table.AddCell(pdfHelper.CreateCell("号牌号码", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("所有人", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));

            table.AddCell(pdfHelper.CreateCell("车 辆 类 型", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("品 牌/型 号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("使用性质", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("注册登记日期", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("出厂年月", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("检验日期", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            pdfPCell = pdfHelper.CreateCell("车辆识别代号" + Environment.NewLine + "（或出厂编号）", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.MinimumHeight = 40;
            table.AddCell(pdfPCell);
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("发动机号码" + Environment.NewLine + "（或电动机号码）", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("二、检验结论", NormalFont, Element.ALIGN_LEFT, 6, 1));
            pdfPCell = pdfHelper.CreateCell("检验结论", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.MinimumHeight = 40;
            table.AddCell(pdfPCell);
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("授权签字人", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));

            pdfPCell = pdfHelper.CreateCell("单位名称（盖章):", NormalFont, Element.ALIGN_LEFT, 6, 1);
            pdfPCell.MinimumHeight = 40;
            pdfPCell.PaddingLeft = doc.PageSize.Width - 300;
            table.AddCell(pdfPCell);
            table.AddCell(pdfHelper.CreateCell("三、人工检验结果", NormalFont, Element.ALIGN_LEFT, 6, 1));
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 1, 8, 3, 3, 3, 1 }, doc);
            table.AddCell(pdfHelper.CreateCell("序号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("检验项目", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("结果判定", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("具体不符合项目情况说明", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("备注", NormalFont, Element.ALIGN_CENTER));
            CreateReport_Manual(table);


            table.AddCell(pdfHelper.CreateCell("四、仪器设备检验结果", NormalFont, Element.ALIGN_LEFT, 6, 1));

            table.AddCell(pdfHelper.CreateCell("序号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("检验项目", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("检验结果", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("标准限值", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("结果判定", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("备注", NormalFont, Element.ALIGN_CENTER));
            CreateReport_Device(table);
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 1 }, doc);
            table.AddCell(pdfHelper.CreateCell("五、建议", NormalFont, Element.ALIGN_LEFT));
            pdfPCell = pdfHelper.CreateCell("", NormalFont, Element.ALIGN_LEFT);
            pdfPCell.MinimumHeight = 40;
            table.AddCell(pdfPCell);
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 1, 10 }, doc);
            pdfPCell = pdfHelper.CreateCell("备注", NormalFont, Element.ALIGN_LEFT);
            pdfPCell.Rowspan = 2;
            table.AddCell(pdfPCell);

            pdfPCell = pdfHelper.CreateCell("判定栏中“-”表示不适用送检车。", NormalFont, Element.ALIGN_LEFT);
            pdfPCell.BorderWidthBottom = 0;
            table.AddCell(pdfPCell);

            pdfPCell = pdfHelper.CreateCell("检验依据标准：", NormalFont, Element.ALIGN_LEFT);
            pdfPCell.BorderWidthTop = 0;
            table.AddCell(pdfPCell);
            doc.Add(table);

            doc.Close();

            MemoryStream memoryStream1 = new MemoryStream(memoryStream.ToArray());
            O2S.Components.PDFRender4NET.PDFFile pdfFile = O2S.Components.PDFRender4NET.PDFFile.Open(memoryStream1);
            System.Drawing.Bitmap pageImage = pdfFile.GetPageImage(0, 56 * (int)PdfHelper.Definition.Six);

            //打印
            //PrinterSettings settings = new PrinterSettings();
            //PrintDocument pd = new PrintDocument();
            //settings.PrinterName = "HP Color LaserJet Pro MFP M176 PCLmS";
            //settings.PrintToFile = false;

            //PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
            //pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional;
            //pdfPrintSettings.PrinterSettings.Copies = 1;
            //pdfFile.Print(pdfPrintSettings);
            return pageImage;
        }

        private void CreateReport_Manual(PdfPTable table)
        {
            for (int i = 0; i < 7; i++)
            {
                table.AddCell(pdfHelper.CreateCell((i + 1).ToString(), NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER, 2, 1));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
            }
        }

        private void CreateReport_Device(PdfPTable table)
        {
            for (int i = 0; i < 12; i++)
            {
                table.AddCell(pdfHelper.CreateCell((i + 1).ToString(), NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
                table.AddCell(pdfHelper.CreateCell("-", NormalFont, Element.ALIGN_CENTER));
            }
        }



        public Bitmap CreateDeviceReprot()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            doc = pdfHelper.CreateDocumentA4(10, 10, 10, 100);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            stopwatch.Stop();
            doc.Open();
            long j = stopwatch.ElapsedMilliseconds;
            doc.NewPage();
            doc.Add(pdfHelper.CreateTitleParagraph("机动车（三轮汽、摩托除外） 安全技术检验表仪器设备部分", BoldFont));

            PdfPTable table = pdfHelper.CreateTable(new float[] { 1, 1, 1, 1, 1, 1 }, doc);
            table.AddCell(pdfHelper.CreateCell("一、基本信息", NormalFont, Element.ALIGN_LEFT, 6, 1));

            table.AddCell(pdfHelper.CreateCell("检验流水号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("引车员", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("检验日期", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("检验类别", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("检验项目", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("登录员", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("号牌(自编)", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("所有人", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));

            table.AddCell(pdfHelper.CreateCell("号牌种类", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("车辆类型", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("品牌/型号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("车辆识别代号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));

            table.AddCell(pdfHelper.CreateCell("发动机号", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("初次登记日期", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("出厂年月", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("燃料类别", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("驱动型式", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("驻车轴", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("转向轴悬架形式", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            doc.Add(table);
            table = pdfHelper.CreateTable(new float[] { 1, 1, 1, 1, 1.5f, 0.5f }, doc);
            table.AddCell(pdfHelper.CreateCell("整备质量(kg)", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("前照灯制", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(pdfHelper.CreateCell("前照灯远光束能否单独调整", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));


            table.AddCell(pdfHelper.CreateCell("二、检验结果", NormalFont, Element.ALIGN_LEFT, 6, 1));
            doc.Add(table);
            table = pdfHelper.CreateTable(new float[] { 5, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 7, 7 }, doc);

            table.AddCell(pdfHelper.CreateCell("台 试" + Environment.NewLine + "检 测" + Environment.NewLine + "项 目", NormalFont, Element.ALIGN_CENTER, 2, 4));
            table.AddCell(pdfHelper.CreateCell("轮荷" + Environment.NewLine + "（kg）", NormalFont, Element.ALIGN_CENTER, 2, 2));
            table.AddCell(pdfHelper.CreateCell("最大行车制" + Environment.NewLine + "动力（10N）", NormalFont, Element.ALIGN_CENTER, 2, 2));
            table.AddCell(pdfHelper.CreateCell("过程差最大" + Environment.NewLine + "差值点（10N）", NormalFont, Element.ALIGN_CENTER, 2, 2));
            table.AddCell(pdfHelper.CreateCell("空 载 制 动", NormalFont, Element.ALIGN_CENTER, 4, 1));
            table.AddCell(pdfHelper.CreateCell("加 载 制 动", NormalFont, Element.ALIGN_CENTER, 3, 1));
            table.AddCell(pdfHelper.CreateCell("项目判定", NormalFont, Element.ALIGN_CENTER, 1, 4));
            table.AddCell(pdfHelper.CreateCell("单项次数", NormalFont, Element.ALIGN_CENTER, 1, 4));

            table.AddCell(pdfHelper.CreateCell("行车制动率", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("不平衡率", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("驻车制动力", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("驻车制动率", NormalFont, Element.ALIGN_CENTER, 1, 3));

            table.AddCell(pdfHelper.CreateCell("加载轴荷", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("轴制动率", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("不平衡率", NormalFont, Element.ALIGN_CENTER, 1, 3));

            table.AddCell(pdfHelper.CreateCell("左", NormalFont, Element.ALIGN_CENTER, 1, 2));
            table.AddCell(pdfHelper.CreateCell("右", NormalFont, Element.ALIGN_CENTER, 1, 2));
            table.AddCell(pdfHelper.CreateCell("左", NormalFont, Element.ALIGN_CENTER, 1, 2));
            table.AddCell(pdfHelper.CreateCell("右", NormalFont, Element.ALIGN_CENTER, 1, 2));
            table.AddCell(pdfHelper.CreateCell("左", NormalFont, Element.ALIGN_CENTER, 1, 2));
            table.AddCell(pdfHelper.CreateCell("右", NormalFont, Element.ALIGN_CENTER, 1, 2));


            table.AddCell(pdfHelper.CreateCell("制动B", NormalFont, Element.ALIGN_CENTER, 1, 8));
            table.AddCell(pdfHelper.CreateCell("一轴", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 6));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("二轴", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("三轴", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("四轴", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("五轴", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("整车", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("驻车", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 2, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 6, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 3, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("动态轮荷（左/右）（kg）", NormalFont, Element.ALIGN_CENTER, 4, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 5, 14, 14, 14, 14, 14, 14, 14, 14, 7, 7 }, doc);
            table.AddCell(pdfHelper.CreateCell("前照灯H", NormalFont, Element.ALIGN_CENTER, 1, 7));
            table.AddCell(pdfHelper.CreateCell("项目", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("远光发光强度", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("远光垂直偏移量(mm/10m)", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("近光垂直偏移量(mm/10m)", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("远光灯中心高(mm)", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("近光灯中心高(mm)", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("远光垂直偏移", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("近光垂直偏移", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("项目判定", NormalFont, Element.ALIGN_CENTER, 1, 3));
            table.AddCell(pdfHelper.CreateCell("单项次数", NormalFont, Element.ALIGN_CENTER, 1, 3));

            table.AddCell(pdfHelper.CreateCell("左外灯", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("左内灯", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("右内灯", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            table.AddCell(pdfHelper.CreateCell("右外灯", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 1, 1));

            doc.Add(table);
            table = pdfHelper.CreateTable(new float[] { 14, 89, 14, 7, 7 }, doc);
            table.AddCell(pdfHelper.CreateCell("车速表S", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("km/h", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("侧滑A", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("m/km", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 20, 57, 20, 20, 7, 7 }, doc);
            table.AddCell(pdfHelper.CreateCell("路试制动性能", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("路试检验员", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 40, 37, 20, 20, 3.5f, 3.5f, 3.5f, 3.5f }, doc);
            table.AddCell(pdfHelper.CreateCell("车辆外廓尺寸(mm×mm×mm)", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("整备质量(kg)：", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            doc.Add(table);

            table = pdfHelper.CreateTable(new float[] { 77, 20, 20, 14 }, doc);
            table.AddCell(pdfHelper.CreateCell("主车制动检验结果(对于主车和挂车一起检验，在打印挂车报告时)", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("总检次数", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(pdfHelper.CreateCell("备注", NormalFont, Element.ALIGN_LEFT, 4, 1)); ;

            doc.Add(table);
            doc.Close();
            
            MemoryStream memoryStream1 = new MemoryStream(memoryStream.ToArray());
            O2S.Components.PDFRender4NET.PDFFile pdfFile = O2S.Components.PDFRender4NET.PDFFile.Open(memoryStream1);
            PrinterSettings settings = new PrinterSettings();
            PDFPrintSettings printSettings = new PDFPrintSettings(settings);
            printSettings.PageScaling = O2S.Components.PDFRender4NET.Printing.PageScaling.FitToPrinterMarginsProportional;
            printSettings.PrinterSettings.Copies = 1;
            pdfFile.Print(printSettings);
            System.Drawing.Bitmap pageImage = pdfFile.GetPageImage(0, 56 * (int)PdfHelper.Definition.Six);


            memoryStream.Close();
            memoryStream.Dispose();
            memoryStream1.Close();
            memoryStream1.Dispose();
            return pageImage;
        }


    }
}

public class ReportEntity
{
    private int _serialNo;
    private string _checkItem;
    private string _checkResult;
    private string _standard;
    private string _judge;
    private string _illustrate;
    private string _remark;

    public ReportEntity()
    {
        SerialNo = 0;
        CheckItem = "-";
        CheckResult = "-";
        Standard = "-";
        Judge = "-";
        Illustrate = "-";
        Remark = "-";
    }

    public string CheckResult { get => _checkResult; set => _checkResult = value; }
    public int SerialNo { get => _serialNo; set => _serialNo = value; }
    public string CheckItem { get => _checkItem; set => _checkItem = value; }
    public string Standard { get => _standard; set => _standard = value; }
    public string Judge { get => _judge; set => _judge = value; }
    public string Illustrate { get => _illustrate; set => _illustrate = value; }
    public string Remark { get => _remark; set => _remark = value; }
}

