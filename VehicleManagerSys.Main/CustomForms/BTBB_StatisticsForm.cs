using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live0xUtils.DbUtils.SqlServer;
using System.Collections;
using CI.UIComponents.Helper;
using VehicleManagerSys.Common;
using HZH_Controls;
using VehicleManagerSys.Entity.IVS;
using VehicleManagerSys.Dtos.BB;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class BTBB_StatisticsForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private List<ENV_TESTINFO> list = null;
        public BTBB_StatisticsForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string status = combStatus.Text;
            string vin = txtVin.Text.Trim();
            if(list != null)
                list.Clear();
            CGridHelper.ClearGrid(dgv);
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable= new Hashtable();
                    string sql = "SELECT  VIN,TESTNO,CREATEDATE,XXGKBH, OTESTDATE,(CASE STATUS WHEN 0 THEN '未上传' WHEN 1 THEN '上传成功' WHEN 2 THEN '上传失败' ELSE '' END) AS STATUS FROM ENV_TESTINFO WHERE 1 =1   ";

                    if (!string.IsNullOrEmpty(vin))
                    {
                        hashtable.Add("VIN", "%"+ vin + "%");
                        sql += " AND VIN like @VIN";
                    }

                    sql += " AND  CONVERT(VARCHAR(10),CREATEDATE,120) BETWEEN @STARTDATE AND @ENDDATE";
                    hashtable.Add("STARTDATE", dtStart.CurrentTime.ToString("yyyy-MM-dd"));
                    hashtable.Add("ENDDATE", dtEnd.CurrentTime.ToString("yyyy-MM-dd"));


                    if (status != "全部")
                    {
                        if ("未上传".Equals(status))
                            sql += " AND STATUS = 0";
                        else if ("上传成功".Equals(status))
                            sql += " AND STATUS = 1";
                        else if ("上传失败".Equals(status))
                            sql += " AND STATUS = 2";
                    }
                    sql += " ORDER BY CREATEDATE DESC";
                    list = _mssqlHelper.QueryList<ENV_TESTINFO>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<ENV_TESTINFO>(dgv, list);
                            labCount.Text = $"共查询到 {list.Count} 条信息!";
                        }
                    });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }

            },null, AppHelper.MainForm,true,"正在查询……",200);       
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (list != null && list.Count > 0)
            {
                string path = @"D:\";
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = fd.SelectedPath;

                    string fileName = Path.Combine(path, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xlsx");
                    ControlHelper.ThreadRunExt(this, () =>
                    {
                        try
                        {
                            TableToExcel(list, fileName);
                        }
                        catch (Exception ex)
                        {
                            ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                            {
                                FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                            });
                        }
                    }, null, AppHelper.MainForm, true, "正在导出……", 200);
                }
            }
            else
                FrmTips.ShowTips(AppHelper.MainForm, "没有需要导出的信息！", 3000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
        }

        public static void TableToExcel(List<ENV_TESTINFO> fileList, string file)
        {
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(); } else { workbook = null; }
            if (workbook == null) { return; }
            ISheet sheet = workbook.CreateSheet("Sheet1");
            {
                //表头  
                IRow row = sheet.CreateRow(0);
                ICell cell0 = row.CreateCell(0);
                cell0.SetCellValue("VIN");
                sheet.SetColumnWidth(0, 20 * 256);

                ICell cell1 = row.CreateCell(1);
                cell1.SetCellValue("报告单编号");
                sheet.SetColumnWidth(1, 30 * 256);

                ICell cell2 = row.CreateCell(2);
                cell2.SetCellValue("环保公开号");
                sheet.SetColumnWidth(2, 30 * 256);

                ICell cell3 = row.CreateCell(3);
                cell3.SetCellValue("检测日期");
                sheet.SetColumnWidth(3, 30 * 256);

                ICell cell4 = row.CreateCell(4);
                cell4.SetCellValue("状态");

                ICell cell5 = row.CreateCell(5);
                cell5.SetCellValue("上传日期");
                sheet.SetColumnWidth(5, 30 * 256);
            }
            //数据  
            int i = 0;
            foreach (var item in fileList)
            {
                IRow row1 = sheet.CreateRow(i + 1);
                ICell cell = row1.CreateCell(0);
                cell.SetCellValue(item.VIN);

                ICell cell1 = row1.CreateCell(1);
                cell1.SetCellValue(item.TESTNO);

                ICell cell2 = row1.CreateCell(2);
                cell2.SetCellValue(item.XXGKBH);

                ICell cell3 = row1.CreateCell(3);
                cell3.SetCellValue(item.OTESTDATE);

                ICell cell4 = row1.CreateCell(4);
                cell4.SetCellValue(item.STATUS);


                ICell cell5 = row1.CreateCell(5);
                cell5.SetCellValue(item.CREATEDATE);
                i++;
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }
        }
    }
}
