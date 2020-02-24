using HZH_Controls.Forms;
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
using VehicleManagerSys.Common.Dtos;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class AutoMapConfigForm : FrmWithTitle
    {
        public AutoMapConfigForm()
        {
            InitializeComponent();
        }

        public void Init()
        {
            if (Directory.Exists(AppHelper.AutoMapperConfigs))
            {
                string[] files = Directory.GetFiles(AppHelper.AutoMapperConfigs, "*.txt");
                if (files != null)
                {
                    combFileName.Items.AddRange(files);
                    combFileName.SelectedIndexChanged += CombFileName_SelectedIndexChanged;
                }
            }
        }

        private void CombFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = AppHelper.GetFileContent(Path.Combine(AppHelper.AutoMapperConfigs, combFileName.Text));
            if (!string.IsNullOrEmpty(str))
            {
                MapRegular[] s = JsonConvert.DeserializeObject<MapRegular[]>(str);
                settingFiller.DisplayEntity(s);
            }
        }

        private void AutoMapConfigForm_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
