using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class NetSetting_YW_Form : FrmWithTitle
    {
        public NetSetting_YW_Form()
        {
            InitializeComponent();
            DisplayEnity();
        }

        private void DisplayEnity()
        {
            settingFiller.DisplayEntity(AppHelper.EnvironmentNetSetting);
        }

        private void DbSettingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(AppHelper.EnvironmentNetSetting);
            File.WriteAllText(AppHelper.EnvironmentConfigFile, JsonConvert.SerializeObject(AppHelper.EnvironmentNetSetting, Formatting.Indented));
            FrmTips.ShowTips(AppHelper.MainForm, "保存成功", 1000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 50), TipsState.Success);
        }
    }
}
