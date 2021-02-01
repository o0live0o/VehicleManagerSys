using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Main.Selectors;
using CI.UIComponents.Selector;
using VehicleManagerSys.Dtos;
using Live0xUtils.DbUtils.SqlServer;
using HZH_Controls.Forms;
using VehicleManagerSys.Common;
using System.Threading;
using VehicleManagerSys.Core.Interfaces;
using VehicleManagerSys.Core.Services;
using VehicleManagerSys.Entity.IVS;
using System.Collections;
using Live0xUtils.FileUtils;
using VehicleManagerSys.Core.Services.SafetyTestServices;
using System.Web;
using VehicleManagerSys.Main.Enums;

namespace VehicleManagerSys.Main.UserControls
{
    public partial class LoginControl : UserControl
    {
        private ConstSelector _clzlSelector;
        private ConstSelector _hpzlSelector;
        private ConstSelector _qdxsSelector;
        private ConstSelector _rllbSelector;
        private ConstSelector _rllb2Selector;
        private ConstSelector _gyfsSelector;


        private ConstSelector _hpysSelector;
        private ConstSelector _syxzSelector;
        private ConstSelector _bsqxsSelector;
        private ConstSelector _jqfsSelector;
        private ConstSelector _jylbSelector;
        private ConstSelector _signTypeSelector;
        private ConstSelector _vehicleStatusSelector;
        private ConstSelector _countrySelector;

        private DateTimeSelector _ccrqSelector;
        private DateTimeSelector _djrqSelector;

        private ConstSelector _hasDpfSelector = null;
        private ConstSelector _hasObdSelector = null;
        private ConstSelector _hasSrcSelector = null;
        private ConstSelector _hasEgrSelector = null;
        private ConstSelector _checkItemSelector = null;
        private ConstSelector _treatmentDeviceType = null;
        private ConstSelector _fuelModelSelector = null;

        private ConstSelector _emissionStandardSelector = null;
        private ConstSelector _isDK = null;
        private ConstSelector _canCloseStableSys = null;
        private ConstSelector _isEntryTown = null;
        private ConstSelector _hasRYZF = null;
        private ConstSelector _hasHCL = null;
        private ConstSelector _hasCHZHQ = null;

        private ConstSelector _stanadrdTypeSelector = null;

        private VehicleInfo m_vehicleInfo = null;
        private MssqlHelper m_mssqlHelper = MssqlHelper.GetInstance();

        private IVehicleBusiness m_vehicleBusiness = null;

        public LoginControl()
        {
            InitializeComponent();
            m_vehicleBusiness = new VehicleBusinessYW();
            Init();
        }

        private void Init()
        {
            _clzlSelector = new ConstSelector(txtCLZL, false, false, "CLZL", txtCLZL.Width);
            _clzlSelector.EntityFiller = selectorFiller;

            _hpzlSelector = new ConstSelector(txtHPZL, false, false, "HPZL", txtHPZL.Width);
            _hpzlSelector.EntityFiller = selectorFiller;

            _gyfsSelector = new ConstSelector(txtGYFS, false, false, "SupplyType", txtGYFS.Width);
            _gyfsSelector.EntityFiller = selectorFiller;

            _qdxsSelector = new ConstSelector(txtQDXS, false, false, "QDXS", txtQDXS.Width);
            _qdxsSelector.EntityFiller = selectorFiller;

            _rllbSelector = new ConstSelector(txtRLLB, false, false, "RLLB", txtRLLB.Width);
            _rllbSelector.EntityFiller = selectorFiller;

            _rllb2Selector = new ConstSelector(txtRLLB2, false, false, "RLLB", txtRLLB2.Width);
            _rllb2Selector.EntityFiller = selectorFiller;
            //_rllbSelector.SubjectChanged += _rllbSelector_SubjectChanged;

            _hpysSelector = new ConstSelector(txtHPYS, false, false, "HPYS", txtGYFS.Width);
            _hpysSelector.EntityFiller = selectorFiller;

            _syxzSelector = new ConstSelector(txtSYXZ, false, false, "SYXZ", txtGYFS.Width);
            _syxzSelector.EntityFiller = selectorFiller;

            _bsqxsSelector = new ConstSelector(txtBSQXS, false, false, "BSXLX", txtGYFS.Width);
            _bsqxsSelector.EntityFiller = selectorFiller;

            _jqfsSelector = new ConstSelector(txtJQFS, false, false, "JQFS", txtGYFS.Width);
            _jqfsSelector.EntityFiller = selectorFiller;

            _signTypeSelector = new ConstSelector(txtSignType, false, false, "SignType", txtSignType.Width);
            _signTypeSelector.EntityFiller = selectorFiller;

            _ccrqSelector = new DateTimeSelector(txtCCRQ);

            _djrqSelector = new DateTimeSelector(txtCCDJRQ);

            _hasDpfSelector = new ConstSelector(txtHasDpf, false, false, "SysYesOrNo", txtHasScr.Width);
            _hasDpfSelector.EntityFiller = selectorFiller;

            _hasObdSelector = new ConstSelector(txtHasObd, false, false, "SysYesOrNo", txtHasScr.Width);
            _hasObdSelector.EntityFiller = selectorFiller;

            _hasSrcSelector = new ConstSelector(txtHasScr, false, false, "SysYesOrNo", txtHasScr.Width);
            _hasSrcSelector.EntityFiller = selectorFiller;

            _hasEgrSelector = new ConstSelector(txtHasEgr, false, false, "SysYesOrNo", txtHasScr.Width);
            _hasEgrSelector.EntityFiller = selectorFiller;

            _jylbSelector = new ConstSelector(txtJylb, false, false, "DetectType", txtHasScr.Width);
            _jylbSelector.EntityFiller = selectorFiller;

            _stanadrdTypeSelector = new ConstSelector(txtStandardType, false, false, "StandardType", txtHasScr.Width);
            _stanadrdTypeSelector.EntityFiller = selectorFiller;

            _vehicleStatusSelector = new ConstSelector(txtVehicleStatus, false, false, "VehicleStatus", txtVehicleStatus.Width);
            _vehicleStatusSelector.EntityFiller = selectorFiller;

            _countrySelector = new ConstSelector(txtCountry, false, false, "CountryType", txtCountry.Width);
            _countrySelector.EntityFiller = selectorFiller;

            _canCloseStableSys = new ConstSelector(txtCloseStableSys, false, false, "SysYesOrNo", txtCloseStableSys.Width);
            _canCloseStableSys.EntityFiller = selectorFiller;

            _isEntryTown = new ConstSelector(txtEnterTown, false, false, "SysYesOrNo", txtEnterTown.Width);
            _isEntryTown.EntityFiller = selectorFiller;

            _hasRYZF = new ConstSelector(txtRYZF, false, false, "SysYesOrNo", txtRYZF.Width);
            _hasRYZF.EntityFiller = selectorFiller;

            _hasHCL = new ConstSelector(txtHasHCL, false, false, "SysYesOrNo", txtHasHCL.Width);
            _hasHCL.EntityFiller = selectorFiller;

            _hasCHZHQ = new ConstSelector(txtHasCHZHQ, false, false, "SysYesOrNo", txtHasCHZHQ.Width);
            _hasCHZHQ.EntityFiller = selectorFiller;

            //_checkItemSelector = new ConstSelector(txtCheckItem,false,false,"CheckItem",txtCheckItem.Width);
            //_checkItemSelector.EntityFiller = selectorFiller;

            _fuelModelSelector = new ConstSelector(txtFuleModel, false, false, "FuleModel", txtFuleModel.Width);
            _fuelModelSelector.EntityFiller = selectorFiller;

            _emissionStandardSelector = new ConstSelector(txtEmissionStandard, false, false, "EmissionStandard", txtEmissionStandard.Width);
            _emissionStandardSelector.EntityFiller = selectorFiller;

            _treatmentDeviceType = new ConstSelector(txtTreatmentDeviceType, false, false, "DealDeviceType", txtTreatmentDeviceType.Width);
            _treatmentDeviceType.EntityFiller = selectorFiller;

            _isDK = new ConstSelector(txtDK, false, false, "SysYesOrNo", txtDK.Width);
            _isDK.EntityFiller = selectorFiller;

            //txtHPHM.Text = "川";
            //combQueryAera.SelectedItem = "川";

            chkNetCheck.Checked = "1".Equals(IniHelper.ReadIni(MainConstant.SignalConfig, MainConstant.IsNetSearch, AppHelper.IniFilePath));
            chkNetPF.Checked = "1".Equals(IniHelper.ReadIni(MainConstant.SignalConfig, MainConstant.IsNetPFSearch, AppHelper.IniFilePath));
            txtHPHM.Text = IniHelper.ReadIni(MainConstant.SignalConfig, MainConstant.PlateNoArea, AppHelper.IniFilePath);
            combQueryAera.SelectedItem = IniHelper.ReadIni(MainConstant.SignalConfig, MainConstant.PlateNoArea, AppHelper.IniFilePath);
        }

        /// <summary>
        /// 登录车辆信息
        /// </summary>
        /// <returns></returns>
        private bool Send()
        {
            if (!validator1.Validate()) return false;
            //if (string.IsNullOrEmpty(txtCheckItem.Text) || (txtCheckItem.Tag != null && string.IsNullOrEmpty(txtCheckItem.Tag.ToString())))
            //{
            //    FrmTips.ShowTipsError(AppHelper.MainForm, "请选择检验项目", ContentAlignment.MiddleCenter, 2000);
            //    return false;
            //}
            bool succ = false;
            string[] carIgnoreArr = null;
            try
            {
                m_vehicleInfo = new VehicleInfo();

                FillEntity(m_vehicleInfo); //m_vehicleInfo.TestNoForNet
                AppMessage message = m_vehicleBusiness.SendCar(m_vehicleInfo);



                if (message.Succ)
                {
                    VEHICLE_DISPATCH vehicle_dispatch = new VEHICLE_DISPATCH();
                    loginFiller.FillEntity(vehicle_dispatch);
                    vehicle_dispatch.PFLSH = message.NetTestNo;
                    vehicle_dispatch.JCCS = message.Times;
                    vehicle_dispatch.FJXM = "";
                    vehicle_dispatch.YJXM = "";
                    vehicle_dispatch.JCZT_STATUS = "0";
                    vehicle_dispatch.JYXM = message.DetectItem + ",";
                    vehicle_dispatch.VEHICLEID = vehicle_dispatch.HPZLDH + vehicle_dispatch.HPHM;
                    vehicle_dispatch.JCLSH = "P" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    //更新联网流水号
                    string sql = $"UPDATE VehicleInfo SET TestNoForNet = '{message.NetTestNo}' WHERE  PlateNo = '{m_vehicleInfo.PlateNo}'";
                    m_mssqlHelper.ExcuteNonQuery(sql, null);
                    sql = $"UPDATE LOGIN_VEHICLE_INFO SET  JYXM = '{ vehicle_dispatch.JYXM}' , PFLSH = '{message.NetTestNo}' WHERE  HPHM = '{m_vehicleInfo.PlateNo}'";
                    m_mssqlHelper.ExcuteNonQuery(sql, null);

                    //carIgnoreArr = (from p in vehicle_dispatch.GetType().GetProperties()
                    //                where p.GetValue(vehicle_dispatch, null) == null || string.IsNullOrEmpty(p.GetValue(vehicle_dispatch, null).ToString())
                    //                select p.Name).ToArray();
                    carIgnoreArr = new string[] { "ID", "JCZL", "LTGG", "ZJLWZT", "SFJMPZ", "OBDJYY", "WQYCY", "OBDCommCL", "OBDCommCX", "Standard", "VehicleKind", "IsEFI", "IsAsm", "OBDOutlookID", "OutlookID", "GGMINNMD", "GGMAXNMD" };
                    succ = m_mssqlHelper.InsertOrUpdate(vehicle_dispatch, null, new string[] { "HPHM" }, carIgnoreArr);

                    if (succ)
                        FrmTips.ShowTipsSuccess(AppHelper.MainForm, "报检成功！"
                            + "检测方法:" + message.DetectItem + "检测次数:" + message.Times + Environment.NewLine
                            + "联网流水号:" + message.NetTestNo, ContentAlignment.MiddleCenter, 5000);
                    else
                        FrmTips.ShowTipsError(AppHelper.MainForm, "报检失败！" + message.Msg, ContentAlignment.MiddleCenter, 3000);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "报检失败！" + message.Msg, ContentAlignment.MiddleCenter, 3000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "报检异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
            return succ;
        }

        /// <summary>
        /// 保存基本信息
        /// </summary>
        /// <returns></returns>
        private bool Save()
        {
            if (!validator1.Validate()) return false;

            bool succ = false;
            string[] carIgnoreArr = null;
            try
            {
                //保存VehicleInfo表
                m_vehicleInfo = new VehicleInfo();
                FillEntity(m_vehicleInfo);
                carIgnoreArr = (from p in m_vehicleInfo.GetType().GetProperties()
                                where p.GetValue(m_vehicleInfo, null) == null || string.IsNullOrEmpty(p.GetValue(m_vehicleInfo, null).ToString())
                                select p.Name).ToArray();
                succ = m_mssqlHelper.InsertOrUpdate(m_vehicleInfo, null, new string[] { "PlateNo" }, carIgnoreArr);
                if (succ)
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存VehicleInfo成功！", ContentAlignment.MiddleCenter, 1000);
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存VehicleInfo失败！", ContentAlignment.MiddleCenter, 1000);

                //保存LOGIN_VEHICLE_INFO表
                LOGIN_VEHICLE_INFO login_vehicle_info = new LOGIN_VEHICLE_INFO();
                loginFiller.FillEntity(login_vehicle_info);

                login_vehicle_info.VEHICLEID = login_vehicle_info.HPZLDH + login_vehicle_info.HPHM;
                login_vehicle_info.PPXH = login_vehicle_info.PP + login_vehicle_info.XH;
                carIgnoreArr = (from p in login_vehicle_info.GetType().GetProperties()
                                where p.GetValue(login_vehicle_info, null) == null || string.IsNullOrEmpty(p.GetValue(login_vehicle_info, null).ToString())
                                select p.Name).ToArray();
                succ = m_mssqlHelper.InsertOrUpdate(login_vehicle_info, null, new string[] { "HPHM" }, carIgnoreArr);
                if (succ)
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存LOGIN_VEHICLE_INFO成功！", ContentAlignment.MiddleCenter, 1000);
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存LOGIN_VEHICLE_INFO失败！", ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存信息异常！" + ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
            return succ;
        }

        public void FillEntity<T>(T t)
        {
            vehicleFiller.FillEntity(t);
        }

        public void DisplayEntity<T>(T t)
        {
            vehicleFiller.DisplayEntity(t);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Save();
            Send();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkNetCheck.Checked)
                {
                    NetSearch(NetType.AJ);
                }
                else if (chkNetPF.Checked)
                {
                    NetSearch(NetType.PF);
                }
                else
                {
                    string plateNo = txtQueryPlateNo.Text.Trim();
                    if (string.IsNullOrEmpty(plateNo))
                    {
                        FrmTips.ShowTipsError(AppHelper.MainForm, "号牌号码不能为空");
                        return;
                    }

                    plateNo = combQueryAera.Text + plateNo;

                    LOGIN_VEHICLE_INFO loginInfo = new LOGIN_VEHICLE_INFO();
                    Hashtable hashtable = new Hashtable();
                    string sql = "SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM = @HPHM";
                    hashtable.Add("HPHM", plateNo);
                    loginInfo = m_mssqlHelper.Query<LOGIN_VEHICLE_INFO>(sql, hashtable);

                    VehicleInfo vehicleInfo = new VehicleInfo();
                    hashtable.Clear();
                    sql = "SELECT * FROM VehicleInfo WHERE PlateNo = @PlateNo";
                    hashtable.Add("PlateNo", plateNo);
                    vehicleInfo = m_mssqlHelper.Query<VehicleInfo>(sql, hashtable);

                    bool hasVal = false;

                    if (loginInfo != null && !string.IsNullOrEmpty(loginInfo.HPHM))
                    {
                        hasVal = true;
                        loginFiller.DisplayEntity(loginInfo);
                    }

                    if (vehicleInfo != null && !string.IsNullOrEmpty(vehicleInfo.PlateNo))
                    {
                        hasVal = true;
                        vehicleFiller.DisplayEntity(vehicleInfo);
                    }

                    if (!hasVal)
                        FrmTips.ShowTipsError(AppHelper.MainForm, "没有查询到车辆信息");


                }
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "查询异常:" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loginFiller.DisplayEntity(null);
            vehicleFiller.DisplayEntity(null);

        }

        private void chkNetCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkNetCheck.Checked && chkNetPF.Checked)
            {
                chkNetPF.Checked = false;
                IniHelper.WriteIni(MainConstant.SignalConfig, MainConstant.IsNetPFSearch, chkNetPF.Checked ? "1" : "0", AppHelper.IniFilePath);
            }

            IniHelper.WriteIni(MainConstant.SignalConfig, MainConstant.IsNetSearch, chkNetCheck.Checked ? "1" : "0", AppHelper.IniFilePath);
        }

        private void chkNetPF_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkNetPF.Checked && chkNetCheck.Checked)
            {
                chkNetCheck.Checked = false;
                IniHelper.WriteIni(MainConstant.SignalConfig, MainConstant.IsNetSearch, chkNetCheck.Checked ? "1" : "0", AppHelper.IniFilePath);
            }

            IniHelper.WriteIni(MainConstant.SignalConfig, MainConstant.IsNetPFSearch, chkNetCheck.Checked ? "1" : "0", AppHelper.IniFilePath);
        }

        private void combQueryAera_SelectedIndexChanged(object sender, EventArgs e)
        {
            IniHelper.WriteIni(MainConstant.SignalConfig, MainConstant.PlateNoArea, combQueryAera.Text, AppHelper.IniFilePath);
        }

        private void NetSearch(NetType netType = NetType.AJ)
        {
            var hphm = combQueryAera.Text.Trim() + txtQueryPlateNo.Text.Trim();
            var vin = txtQueryVin.Text.Trim();
            var hpzl = AppHelper.GetDefineCode("HPZL", combQueryPlateType.Text);
            var hpys = AppHelper.GetNetType("HPYS",AppHelper.GetDefineCode("HPYS", combPlateColor.Text.Replace("牌", "")));

            if (netType == NetType.AJ)
            {
                hphm = HttpUtility.UrlEncode(hphm);

                SafetyTestService safetyTestService = new SafetyTestService();
                var message = safetyTestService.Request18C49(hphm, vin, hpzl);
                if (message.Succ && message.VehicleInfo != null)
                {
                    vehicleFiller.DisplayEntity(message.VehicleInfo);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "查询失败:" + message?.Msg);
            }
            else
            {
                VehicleInfo info = new VehicleInfo();
                info.PlateNo = hphm;
                info.VIN = vin;
                info.PlateColor = hpys;
                VehicleBusinessYW yW = new VehicleBusinessYW();
                var pfMsg = yW.SearchCar(info);
                if (pfMsg.Succ && pfMsg.VehicleInfo != null)
                {
                    vehicleFiller.DisplayEntity(pfMsg.VehicleInfo);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "查询失败:" + pfMsg?.Msg);
            }

        }


    }
}
