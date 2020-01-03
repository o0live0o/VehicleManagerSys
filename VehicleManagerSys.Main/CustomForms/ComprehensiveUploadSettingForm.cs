using CI.UIComponents.Helper;
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

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class ComprehensiveUploadSettingForm : FrmWithTitle
    {
        public ComprehensiveUploadSettingForm()
        {
            InitializeComponent();
            DisplaySetting();
        }

        private void DisplaySetting()
        {
            settingFiller.DisplayEntity(AppHelper.ComprehensiveSetting) ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(AppHelper.ComprehensiveSetting);
            AppHelper.ComprehensiveSetting.ImgList = AppHelper.ComprehensiveSetting.ImgList.OrderBy(s =>
            {
                int d = 100;
                int.TryParse(s.ImgType, out d);
                return d;
            }).ThenBy(s =>
            {
                int d = 100;
                int.TryParse(s.ImgKey, out d);
                return d;
            }).ToArray();
            if (!Directory.Exists(AppHelper.ComprehensiveSetting.ImagePath))
            {
                Directory.CreateDirectory(AppHelper.ComprehensiveSetting.ImagePath);
            }
            File.WriteAllText(AppHelper.ComprehensiveConfigFile, JsonConvert.SerializeObject(AppHelper.ComprehensiveSetting, Formatting.Indented));
            FrmTips.ShowTips(AppHelper.MainForm, "保存成功", 1000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 50), TipsState.Success);
        }

        private void btnPicPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(file.SelectedPath))
                {
                    txtImgPath.Text = file.SelectedPath;
                }
            }
        }

        private void btnAreaSelect_Click(object sender, EventArgs e)
        {
            AreaCodeForm areaCode = new AreaCodeForm();
            areaCode.ShowDialog(this);
            if (areaCode.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                txtAreaCode.Text = areaCode.AreaCode;
            }
        }

        private void btnDeletePicType_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvImgType.CurrentRow.Index > -1)
                {
                    CGridHelper.RemoveDataRow(dgvImgType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteLineType_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetectLine.CurrentRow.Index > -1)
                {
                    CGridHelper.RemoveDataRow(dgvDetectLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOperator.CurrentRow.Index > -1)
                {
                    CGridHelper.RemoveDataRow(dgvOperator);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
