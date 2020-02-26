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
using VehicleManagerSys.Common.Dtos;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ValChangeForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();

        public ValChangeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NetTypeDefine> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT  * FROM NetTypeDefine WHERE 1=1 ";

                    if (!string.IsNullOrEmpty(txtSeachPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("DefineType", "%" + txtSeachPlateNo.Text.Trim() + "%");
                        sql += " AND DefineType like @DefineType";
                    }
                    list = _mssqlHelper.QueryList<NetTypeDefine>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<NetTypeDefine>(dgv, list);
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
            //if (e.RowIndex < 0) return;
            //RESULT_VEHICLE_INFO info = CGridHelper.GetCurrentData<RESULT_VEHICLE_INFO>(dgv);
            //if(info != null)
            //{
            //    ((MainForm)AppHelper.MainForm).AddForm(new ComprehensiveUploadForm(info));
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValChangeOptForm valChangeOptForm = new ValChangeOptForm();
            DialogResult dialogResult = valChangeOptForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK && valChangeOptForm.IsUpdate)
            {
                btnSearch_Click(null,null);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "未选中任何行！", ContentAlignment.MiddleCenter, 1000);
                return;
            }
            NetTypeDefine netTypeDefine = CGridHelper.GetCurrentData<NetTypeDefine>(dgv);
            ValChangeOptForm valChangeOptForm = new ValChangeOptForm(netTypeDefine);
            DialogResult dialogResult = valChangeOptForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK && valChangeOptForm.IsUpdate)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "未选中任何行！", ContentAlignment.MiddleCenter, 1000);
                return;
            }
            NetTypeDefine netTypeDefine = CGridHelper.GetCurrentData<NetTypeDefine>(dgv);
            string sql = "DELETE NetTypeDefine WHERE ID = @ID";
            Hashtable hashtable = new Hashtable();
            hashtable.Add("ID",netTypeDefine.ID);
            if (_mssqlHelper.ExcuteNonQuery(sql, hashtable) > 0)
            {
                FrmTips.ShowTipsSuccess(AppHelper.MainForm, "删除成功！", ContentAlignment.MiddleCenter, 1000);
                CGridHelper.DeleteRow(dgv);
            }
            else
                FrmTips.ShowTipsError(AppHelper.MainForm, "删除失败！", ContentAlignment.MiddleCenter, 1000);
        }
    }
}
