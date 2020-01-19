using EASkins.Controls;
using HZH_Controls;
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
using VehicleManagerSys.Main.CustomForms;

namespace VehicleManagerSys.Main
{
    public partial class MainForm : MaterialForm
    {
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
            ControlHelper.FreezeControl(this, true);
            TreeNode tnLogin = new TreeNode("车辆报检");
            tnLogin.Nodes.Add("环保报检");
            this.tvMenu.Nodes.Add(tnLogin);

            TreeNode tnDataManager = new TreeNode("数据管理");
            tnDataManager.Nodes.Add("综检上传");
           // tnDataManager.Nodes.Add("报告单");
            this.tvMenu.Nodes.Add(tnDataManager);

            TreeNode tnSetting = new TreeNode("系统管理");
            tnSetting.Nodes.Add("系统设置");
            tnSetting.Nodes.Add("综检上传配置");
            this.tvMenu.Nodes.Add(tnSetting);
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strName = e.Node.Text.Trim();
            if (!new string[] { "车辆报检","数据管理", "系统管理" }.Contains(strName))
            {
                panControl.Controls.Clear();
            }
            switch (strName)
            {
                case "环保报检":
                    AddForm(new VehicleLoginForm());
                    break;
                case "综检上传":
                    AddForm(new ComprehensiveTestForm());
                    break;
                case "报告单":
                    AddForm(new ReportTestForm());
                    break;
                case "综检上传配置":
                    AddForm(new ComprehensiveUploadSettingForm());
                    break;
                case "系统设置":
                    AddForm(new DbSettingForm());
                    break;
            }
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
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0,0);
        }

    }
}
