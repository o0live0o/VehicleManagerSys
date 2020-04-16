using EASkins.Controls;
using HZH_Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Main.CustomForms;
using VehicleManagerSys.Main.UserControls;

namespace VehicleManagerSys.Main
{
    public partial class MainForm : MaterialForm
    {
        private List<SysMenu> m_menus = new List<SysMenu>();
        private Dictionary<string, Control> m_dicControl = new Dictionary<string, Control>();
        private Control m_currentControl = null;
        public MainForm()
        {
            InitializeComponent();
            AppHelper.MainForm = this;
            InitMenu();
            labUser.Text = AppHelper.UserInfo.UserName;
        }

        /// <summary>
        /// 初始化报告单
        /// </summary>
        private void InitMenu()
        {
            try
            {
                m_menus = JsonConvert.DeserializeObject<List<SysMenu>>(File.ReadAllText("MenuConfig.json")); //加载菜单列表
                ControlHelper.FreezeControl(this, true);
                foreach (var item in m_menus.Where(p => p.ParentId.Equals(0)))
                {
                    this.tvMenu.Nodes.Add(InitMenu(item, m_menus));
                }
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(this, ex.Message);
            }
            //TreeNode tnLogin = new TreeNode("车辆报检");
            //tnLogin.Nodes.Add("环保报检");
            //tnLogin.Nodes.Add("环保报检(云网)");
            //tnLogin.Nodes.Add("环保复检(云网)");
            //this.tvMenu.Nodes.Add(tnLogin);

            //TreeNode tnDataManager = new TreeNode("数据管理");
            //tnDataManager.Nodes.Add("综检上传");
            //tnDataManager.Nodes.Add("报告单");
            //this.tvMenu.Nodes.Add(tnDataManager);

            //TreeNode tnSetting = new TreeNode("系统管理");
            //tnSetting.Nodes.Add("系统设置");
            //tnSetting.Nodes.Add("综检联网配置");
            //tnSetting.Nodes.Add("环保联网配置");
            //tnSetting.Nodes.Add("字段转换配置");
            //this.tvMenu.Nodes.Add(tnSetting);
        }

        private TreeNode InitMenu(SysMenu sysMenu, List<SysMenu> list, int parentId = 0)
        {
            TreeNode treeNode = new TreeNode() { Text = sysMenu.MenuName, Tag = sysMenu.MenuPath };
            foreach (var item in list.Where(p => p.ParentId.Equals(sysMenu.MenuId)))
                treeNode.Nodes.Add(InitMenu(item, list, item.MenuId));
            return treeNode;
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {

            string strKey = (e.Node.Tag ?? "").ToString();

            if (string.IsNullOrEmpty(strKey)) return;

            if (m_currentControl != null) m_currentControl.Visible = false;
            if (m_dicControl.ContainsKey(strKey))
            {
                m_currentControl = m_dicControl[strKey];
                m_currentControl.Visible = true;
            }
            else
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                object o = assembly.CreateInstance(strKey, true);
                if (o != null)
                {
                    //panControl.Controls.Clear();
                    Control control = (Control)o;
                    if (control is Form)
                        ((Form)control).TopLevel = false;
                    control.Dock = DockStyle.Fill;
                    control.AllowDrop = false;
                    panControl.Controls.Add(control);
                    control.BringToFront();
                    control.Show();
                    m_currentControl = control;
                    lock (AppHelper.AppLocker)
                    {
                        if (!m_dicControl.ContainsKey(strKey))
                            m_dicControl.Add(strKey, control);
                    }
                }
            }
            //string strName = e.Node.Text.Trim();
            //if (!new string[] { "车辆报检","数据管理", "系统管理" }.Contains(strName))
            //{
            //    panControl.Controls.Clear();
            //}
            //switch (strName)
            //{
            //    case "环保报检":
            //        AddForm(new VehicleLoginForm());
            //        break;
            //    case "综检上传":
            //        AddForm(new ComprehensiveTestForm());
            //        break;
            //    case "报告单":
            //        AddForm(new ReportTestForm());
            //        break;
            //    case "综检联网配置":
            //        AddForm(new ComprehensiveUploadSettingForm());
            //        break;
            //    case "系统设置":
            //        AddForm(new DbSettingForm());
            //        break;
            //    case "环保报检(云网)":
            //        AddControl(new LoginControl());
            //        break;
            //    case "环保复检(云网)":
            //        AddForm(new YunWangReCheckForm());
            //        break;
            //    case "环保联网配置":
            //        AddForm(new NetSetting_YW_Form());
            //        break;
            //    case "字段转换配置":
            //        AddForm(new ValChangeForm());
            //        break;
            //}
        }


        public void AddForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.AllowDrop = false;
            panControl.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        public void AddControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            control.AllowDrop = false;
            panControl.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FullScreen();
        }

        //窗体最大化
        private void FullScreen()
        {
            return;
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0,0);
        }

    }
}
