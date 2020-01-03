using CI.UIComponents.Helper;
using CI.UIComponents.Selector;
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
using VehicleManagerSys.Common;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Dtos.Emuns;
using VehicleManagerSys.Dtos.IVS;
using VehicleManagerSys.Interface;
using VehicleManagerSys.Main.CustomCache;
using VehicleManagerSys.Main.Selectors;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class VehicleLoginForm : FrmWithTitle
    {
        private ConstSelector _clzlSelector;
        private ConstSelector _hpzlSelector;
        private ConstSelector _qdxsSelector;
        private ConstSelector _rllbSelector;
        private ConstSelector _gyfsSelector;


        private ConstSelector _hpysSelector;
        private ConstSelector _syxzSelector;
        private ConstSelector _bsqxsSelector;
        private ConstSelector _jqfsSelector;
        private ConstSelector _hasEgrSelector;
        private ConstSelector _jylbSelector;

        private DateTimeSelector _ccrqSelector;
        private DateTimeSelector _djrqSelector;

        private List<CheckItem> _checkItems = null;

        private ConstSelector hasDpfSelector = null;
        private ConstSelector hasObdSelector = null;
        private ConstSelector hasSrcSelector = null;

        public VehicleLoginForm()
        {
            InitializeComponent();
        }

        private void InitControl()
        {
            _clzlSelector = new ConstSelector(txtCLZL, false, false, "CLZL", txtCLZL.Width);
            _clzlSelector.EntityFiller = selectorFiller;

            _hpzlSelector = new ConstSelector(txtHPZL, false, false, "HPZL", txtHPZL.Width);
            _hpzlSelector.EntityFiller = selectorFiller;

            _gyfsSelector = new ConstSelector(txtGYFS, false, false, "GYFS", txtGYFS.Width);
            _gyfsSelector.EntityFiller = selectorFiller;

            _qdxsSelector = new ConstSelector(txtQDXS, false, false, "QDXS", txtQDXS.Width);
            _qdxsSelector.EntityFiller = selectorFiller;

            _rllbSelector = new ConstSelector(txtRLLB, false, false, "RLLB", txtRLLB.Width);
            _rllbSelector.EntityFiller = selectorFiller;
            //_rllbSelector.SubjectChanged += _rllbSelector_SubjectChanged;

            _hpysSelector = new ConstSelector(txtHPYS, false, false, "PQHPZL", txtGYFS.Width);
            _hpysSelector.EntityFiller = selectorFiller;

            _syxzSelector = new ConstSelector(txtSYXZ, false, false, "SYXZ", txtGYFS.Width);
            _syxzSelector.EntityFiller = selectorFiller;

            _bsqxsSelector = new ConstSelector(txtBSQXS, false, false, "BSXLX", txtGYFS.Width);
            _bsqxsSelector.EntityFiller = selectorFiller;

            _jqfsSelector = new ConstSelector(txtJQFS, false, false, "JQFS", txtGYFS.Width);
            _jqfsSelector.EntityFiller = selectorFiller;

    
            _ccrqSelector = new DateTimeSelector(txtCCRQ);

            _djrqSelector = new DateTimeSelector(txtCCDJRQ);

            _checkItems = CloneHelper.Clone(CheckItemCache.GetInsance().Get_HB_CheckItem());
            CGridHelper.FillGrid(dgvCheckItem, _checkItems);

            hasDpfSelector = new ConstSelector(txtHasDpf, false, false, "SysYesOrNo", txtHasScr.Width);
            hasDpfSelector.EntityFiller = selectorFiller;

            hasObdSelector = new ConstSelector(txtHasObd, false, false, "SysYesOrNo", txtHasScr.Width);
            hasObdSelector.EntityFiller = selectorFiller;

            hasSrcSelector = new ConstSelector(txtHasScr, false, false, "SysYesOrNo", txtHasScr.Width);
            hasSrcSelector.EntityFiller = selectorFiller;

            _jylbSelector = new ConstSelector(txtJylb, false, false, "JYLB", txtHasScr.Width);
            _jylbSelector.EntityFiller = selectorFiller;

            txtHPHM.Text = "晋";

            combQueryAera.SelectedItem = "晋";

        }

        private void VehicleLoginForm_Shown(object sender, EventArgs e)
        {
            InitControl();
        }

        private void dgvCheckItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (this.dgvCheckItem.Rows[e.RowIndex].Cells[1].GetType() == typeof(DataGridViewCheckBoxCell))
            {
                for (int i = 0; i < this.dgvCheckItem.RowCount; i++)
                {
                    this.dgvCheckItem.Rows[i].Cells[1].Value = false;
                }
                this.dgvCheckItem.Rows[e.RowIndex].Cells[1].Value = true;
            }
        }

        private void dgvCheckItem_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQueryPlateNo.Text.Trim()))
                {
                    FrmTips.ShowTipsError(AppHelper.MainForm, "号牌号码不能为空！", ContentAlignment.MiddleCenter,1000);
                    return;
                }

                IQueryVehicle queryVehicle = SimpleFactory.GetObjcet<IQueryVehicle>();
                Result<LOGIN_VEHICLE_INFO> result = queryVehicle.Query<LOGIN_VEHICLE_INFO>(combQueryAera.Text + txtQueryPlateNo.Text.Trim());
                if (result != null)
                {
                    if (result.Succ && result.Entity != null)
                    {
                        result.Entity.IsSCR = string.IsNullOrEmpty(result.Entity.IsSCR) ? "" : EnumHelper.GetDescription<YesOrNo>(GetYesOrNoEnum(result.Entity.IsSCR));
                        result.Entity.IsDPF = string.IsNullOrEmpty(result.Entity.IsDPF) ? "" : EnumHelper.GetDescription<YesOrNo>(GetYesOrNoEnum(result.Entity.IsDPF));
                        result.Entity.IsOBD = string.IsNullOrEmpty(result.Entity.IsOBD) ? "" : EnumHelper.GetDescription<YesOrNo>(GetYesOrNoEnum(result.Entity.IsOBD));
                        vehicleFiller.DisplayEntity(result.Entity);
                        CheckItem(result.Entity.JYXM);
                    }
                    else
                        FrmTips.ShowTipsError(AppHelper.MainForm, result.Msg, ContentAlignment.MiddleCenter);
                }
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, ex.Message, ContentAlignment.MiddleCenter);
            }
        }

        private void emi_Button_21_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;

                List<CheckItem> list = CGridHelper.GetFilledRowsData<CheckItem>(dgvCheckItem).ToList();
                CheckItem checkItem = list.Where(p => p.IsCheck).FirstOrDefault();
                if (checkItem == null)
                {
                    FrmTips.ShowTipsError(AppHelper.MainForm, "请选择检验项目！", ContentAlignment.MiddleCenter);
                    return;
                }


                LOGIN_VEHICLE_INFO info = new LOGIN_VEHICLE_INFO();
                vehicleFiller.FillEntity(info);
                info.IsSCR = Convert.ToInt32(EnumHelper.GetValue<YesOrNo>(info.IsSCR)).ToString();
                info.IsDPF = Convert.ToInt32(EnumHelper.GetValue<YesOrNo>(info.IsDPF)).ToString();
                info.IsOBD = Convert.ToInt32(EnumHelper.GetValue<YesOrNo>(info.IsOBD)).ToString();
                info.JYXM = checkItem.ItemCode;
                info.DLY = AppHelper.UserInfo.UserName;
                ILoginVehicle loginVehicle = SimpleFactory.GetObjcet<ILoginVehicle>();
                if (loginVehicle.Login<LOGIN_VEHICLE_INFO>(info).Succ)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    ResetLogin();
                }
                else
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存失败！", ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存失败！"+ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
        }

        private void ResetLogin()
        {
            vehicleFiller.DisplayEntity(null);
            txtHPHM.Text = "晋";
            ClearCheckItem();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetLogin();
        }

        //清空检验项目
        private void ClearCheckItem()
        {
            List<CheckItem> checkItems = CGridHelper.GetFilledRowsData<CheckItem>(dgvCheckItem).ToList();
            if (checkItems == null || checkItems.Count < 1)
                return;
            checkItems.ForEach(p => { if (p != null) p.IsCheck = false; });
            CGridHelper.ClearGrid(dgvCheckItem);
            CGridHelper.FillGrid(dgvCheckItem, checkItems);
        }

        private void CheckItem(string item)
        {
            List<CheckItem> checkItems = CGridHelper.GetFilledRowsData<CheckItem>(dgvCheckItem).ToList();
            if (checkItems == null || checkItems.Count < 1)
                return;
            checkItems.ForEach(p => { if (p != null && item.Contains(p.ItemCode)) { p.IsCheck = true; } else { p.IsCheck = false; } });
            CGridHelper.ClearGrid(dgvCheckItem);
            CGridHelper.FillGrid(dgvCheckItem, checkItems);
        }

        private YesOrNo GetYesOrNoEnum(string val)
        {
            YesOrNo yesOrNo = YesOrNo.No;
            try
            {
                yesOrNo = (YesOrNo)Enum.Parse(typeof(YesOrNo), val);
            }
            catch
            {

            }
            return yesOrNo;
        }
    }



}
