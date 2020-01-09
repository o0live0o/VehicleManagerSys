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

        private ConstSelector _stanadrdTypeSelector = null;

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

            _hpysSelector = new ConstSelector(txtHPYS, false, false, "HPYS", txtGYFS.Width);
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

            _stanadrdTypeSelector = new ConstSelector(txtStandardType, false, false, "StandardType", txtHasScr.Width);
            _stanadrdTypeSelector.EntityFiller = selectorFiller;

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
                        result.Entity.StandardText = AppHelper.GetDefineName("StandardType", result.Entity.StandardType);
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
                string lambad_up = "1.05";
                string lambad_down = "0.95";

                if (!validator1.Validate()) return;

                List<CheckItem> list = CGridHelper.GetFilledRowsData<CheckItem>(dgvCheckItem).ToList();
                CheckItem checkItem = list.Where(p => p.IsCheck).FirstOrDefault();
                if (checkItem == null)
                {
                    FrmTips.ShowTipsError(AppHelper.MainForm, "请选择检验项目！", ContentAlignment.MiddleCenter);
                    return;
                }

                if (checkItem.ItemCode.Equals("X1"))
                {
                    InputLambdaForm inputLambdaForm = new InputLambdaForm();
                    inputLambdaForm.ShowDialog(this);
                    lambad_up = inputLambdaForm.GetLambad_Up;
                    lambad_down = inputLambdaForm.GetLambad_Down;
                }


                LOGIN_VEHICLE_INFO info = new LOGIN_VEHICLE_INFO();
                vehicleFiller.FillEntity(info);
                info.JYXM = checkItem.ItemCode;
                info.DLY = AppHelper.UserInfo.UserName;
                info.VEHICLEID = info.HPZLDH + info.HPHM;
                info.PPXH = info.PP + info.XH;

                //根据限值ab获取标准
                SetStanadardByType(info,checkItem.ItemCode); 
                info.GLKQXSSX = lambad_up;
                info.GLKQXSXX = lambad_down;
              
                ILoginVehicle loginVehicle = SimpleFactory.GetObjcet<ILoginVehicle>();
                Result<string> result = loginVehicle.Login<LOGIN_VEHICLE_INFO>(info);
                if (result.Succ)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    ResetLogin();
                }
                else
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存失败！"+ result.Msg, ContentAlignment.MiddleCenter, 1000);
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
            txtStandardType.Text = "";
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

        private void SetStanadardByType(LOGIN_VEHICLE_INFO info,string checkItem)
        {
            if ("2".Equals(info.StandardType))
            {
                //限值b
                info.ZYJSXZ = "1.2";
                info.COXZ = "5.0";
                info.HCXZ = "1.0";
                info.HC_NOXZ = "1.7";
                info.GDSCOXZ = "0.3";
                info.GDSHCXZ = "30";
                info.GLKQXSSX = "1.05";
                info.GLKQXSXX = "0.95";
                info.DSHCXZ = "40";
                info.DSCOXZ = "0.4";
                info.GXSXSXZ = "0.7";
                info.GLXZ = "0.4";
                info.ZSXZ = "0.7";
                info.LGMXZ = "1";
                info.HSUXZ = "26";
                info.HC5025XZ = "40";
                info.CO5025XZ = "0.3";
                info.NO5025XZ = "420";
                info.HC2540XZ = "44";
                info.CO2540XZ = "0.3";
                info.NO2540XZ = "390";
                if(checkItem.Contains("X3"))
                    info.NOXZ = "0.7";
                else
                    info.NOXZ = "1200";
            }
            else
            {
                //限值a
                if (checkItem.Contains("X3"))
                    info.NOXZ = "1.3";
                else
                    info.NOXZ = "1500";
            }
        }
    }
}




