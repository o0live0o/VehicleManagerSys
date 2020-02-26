using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;
using VehicleManagerSys.Common.Dtos;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ValChangeOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private NetTypeDefine m_netTypeDefine = null;
        private bool bIsUpdate = false;

        public ValChangeOptForm()
        {
            InitializeComponent();
            m_netTypeDefine = new NetTypeDefine();
            entityFiller.DisplayEntity(m_netTypeDefine);
        }

        public ValChangeOptForm(NetTypeDefine netTypeDefine)
        {
            InitializeComponent();
            m_netTypeDefine = netTypeDefine;
            entityFiller.DisplayEntity(m_netTypeDefine);
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_netTypeDefine);
                bool succ = _mssqlHelper.InsertOrUpdate(m_netTypeDefine, null, new string[] { "ID" }, null);
                if (succ)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    bIsUpdate = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！", ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
        }
    }
}
