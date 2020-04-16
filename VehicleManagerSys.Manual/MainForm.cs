using CI.UIComponents.Helper;
using EASkins.Controls;
using HZH_Controls;
using HZH_Controls.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;
using VehicleManagerSys.Entity.IVS;

namespace VehicleManagerSys.Manual
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<VEHICLE_DISPATCH> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT TOP 20 * FROM VEHICLE_DISPATCH WHERE 1 =1  AND CHARINDEX('DC',JYXM) > 0 AND CHARINDEX('DC',YJXM) = 0";
                    if (!string.IsNullOrEmpty(txtPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("HPHM", "%" + txtPlateNo.Text.Trim() + "%");
                        sql += " AND HPHM like @HPHM";
                    }
                    sql += " ORDER BY ID DESC";
                    list = AppHelper.Db.QueryList<VEHICLE_DISPATCH>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(this, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid(dgv, list);
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

            }, null, AppHelper.MainForm, true, "正在查询……", 200);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            VEHICLE_DISPATCH info = CGridHelper.GetCurrentData<VEHICLE_DISPATCH>(dgv);
            if (info != null)
            {
                ManualTestForm manualTestForm = new ManualTestForm(info);
                manualTestForm.ShowDialog(this);
            }
        }
    }
}
