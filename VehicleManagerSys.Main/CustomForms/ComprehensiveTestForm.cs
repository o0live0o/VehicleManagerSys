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
using VehicleManagerSys.Dtos.IVS;
using System.Collections;
using CI.UIComponents.Helper;
using VehicleManagerSys.Common;
using HZH_Controls;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ComprehensiveTestForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();

        public ComprehensiveTestForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<RESULT_VEHICLE_INFO> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT TOP 20 * FROM RESULT_VEHICLE_INFO WHERE 1 =1  AND CHARINDEX('Z',JYZL) > 0  ";
                     sql = "SELECT TOP 20 * FROM RESULT_VEHICLE_INFO WHERE 1 =1  AND CHARINDEX('12',JYLBDH) > 0  ";
                    if (!string.IsNullOrEmpty(txtSeachPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("HPHM", "%"+txtSeachPlateNo.Text.Trim() + "%");
                        sql += " AND HPHM like @HPHM";
                    }
                    sql += " ORDER BY ID DESC";
                    list = _mssqlHelper.QueryList<RESULT_VEHICLE_INFO>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<RESULT_VEHICLE_INFO>(dgv, list);
                        }
                    });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(this, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }

            },null, AppHelper.MainForm,true,"正在查询……",200);       
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            RESULT_VEHICLE_INFO info = CGridHelper.GetCurrentData<RESULT_VEHICLE_INFO>(dgv);
            if(info != null)
            {
                ((MainForm)AppHelper.MainForm).AddForm(new ComprehensiveUploadForm(info));
            }
        }
    }
}
