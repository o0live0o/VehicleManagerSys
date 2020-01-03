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
    public partial class DbSettingForm : FrmWithTitle
    {
        public DbSettingForm()
        {
            InitializeComponent();
            DisplayEnity();
        }

        private void DisplayEnity()
        {
            settingFiller.DisplayEntity(AppHelper.DbSetting);
        }

        private void DbSettingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(AppHelper.DbSetting);
            File.WriteAllText(AppHelper.DbConfigFile, JsonConvert.SerializeObject(AppHelper.DbSetting, Formatting.Indented));
            FrmTips.ShowTips(AppHelper.MainForm, "保存成功", 1000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 50), TipsState.Success);
            MssqlHelper.GetInstance().Init(AppHelper.DbSetting.DataBaseServer,
                        AppHelper.DbSetting.DataBaseName,
                        AppHelper.DbSetting.DataBaseUser,
                        AppHelper.DbSetting.DataBasePwd);
        }
    }
}
