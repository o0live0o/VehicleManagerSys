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
using Newtonsoft.Json;
using VehicleManagerSys.Dtos;
using System.Net;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class DispatchForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();

        public DispatchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<VEHICLE_DISPATCH> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT TOP 20 * FROM VEHICLE_DISPATCH WHERE 1 =1  ";

                    if (!string.IsNullOrEmpty(txtSeachPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("HPHM", "%" + txtSeachPlateNo.Text.Trim() + "%");
                        sql += " AND HPHM like @HPHM";
                    }
                    sql += " ORDER BY ID DESC";
                    list = _mssqlHelper.QueryList<VEHICLE_DISPATCH>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<VEHICLE_DISPATCH>(dgv, list);
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
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Index < 0) return;
            VEHICLE_DISPATCH info = CGridHelper.GetCurrentData<VEHICLE_DISPATCH>(dgv);
            if (info != null)
            {
                DialogResult dialogResult = MessageBox.Show("确定要删除选择的车辆吗?","",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "DELETE VEHICLE_DISPATCH WHERE ID = @ID";
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("ID", info.ID);
                        bool succ = _mssqlHelper.ExcuteNonQuery(sql, hashtable) > 0;
                        if (succ)
                            FrmTips.ShowTipsSuccess(AppHelper.MainForm, "删除成功!", ContentAlignment.MiddleCenter, 3000);


                    }
                    catch (Exception ex)
                    {
                        FrmTips.ShowTipsError(AppHelper.MainForm, "删除异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
                    }
                }
            }
        }
    }
}
