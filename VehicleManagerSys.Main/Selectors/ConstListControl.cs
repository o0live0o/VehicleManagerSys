using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CI.UIComponents.Helper;
using Live0xUtils.DbUtils.SqlServer;
using System.Collections;
using VehicleManagerSys.Common.Dtos;
using VehicleManagerSys.Common;

namespace VehicleManagerSys.Main.Selectors
{
    public partial class ConstListControl : UserControl
    {
        public EventHandler AfterSelected;
        private  Constant m_entity;
        private string m_searchText = string.Empty;
        private System.Windows.Forms.Timer m_timer;
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private string mTypeName;

        public ConstListControl(string typeName)
        {
            InitializeComponent();
            this.mTypeName = typeName;
            RefreshData();
            m_timer = new System.Windows.Forms.Timer();
            m_timer.Interval = 200;
            m_timer.Tick += new EventHandler(m_timer_Tick);
            m_timer.Start();
            dgv.Columns[0].Width = dgv.Width - 1;
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                m_timer.Stop();

                if (m_searchText != txtSearch.Text.Trim())
                {
                    RefreshData();
                    m_searchText = txtSearch.Text.Trim();
                }
            }
            catch { }
            finally
            {
                m_timer.Start();
            }
        }

        private void RefreshData()
        {
            try
            {
                if (!this.DesignMode)
                {
                    string searchText = txtSearch.Text.Trim();
                    //string sql = "SELECT * FROM CONST_DEFINE WHERE CON_CHNAME = @CON_CHNAME AND CON_CON LIKE '%'+@CON_CON+'%'";
                    //Hashtable hashtable = new Hashtable();
                    //hashtable.Add("CON_CHNAME", mTypeName);
                    //hashtable.Add("CON_CON", searchText);
                    //IList<Constant> list = _mssqlHelper.QueryList<Constant>(sql, hashtable).ToList();
                    IList<Constant> list = AppHelper.Constants.Where(p=> !string.IsNullOrEmpty(p.Name) && !string.IsNullOrEmpty(p.ConstantType) &&
                    p.Name.Contains(searchText) && p.ConstantType.Equals(mTypeName)).ToList();
                    CGridHelper.FillGrid<Constant>(dgv, list);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public Constant ConstView
        {
            get { return m_entity; }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected new bool DesignMode
        {
            get
            {
                bool returnFlag = false;
#if DEBUG
                if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                {
                    returnFlag = true;
                }
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToUpper().Equals("DEVENV"))
                {
                    returnFlag = true;
                }
#endif
                return returnFlag;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m_entity = CGridHelper.GetCurrentData<Constant>(dgv);
            if (AfterSelected != null)
                AfterSelected(sender, e);
            //SendKeys.Send("{Tab}");
        }
    }
}
