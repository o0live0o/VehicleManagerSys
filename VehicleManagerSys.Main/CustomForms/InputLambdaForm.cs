using HZH_Controls.Forms;
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

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class InputLambdaForm : FrmWithTitle
    {
        private string lambad_up = "1.05";
        private string labmad_down = "0.95";

        public InputLambdaForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_BtnClick(object sender, EventArgs e)
        {
            lambad_up = txtLambda_Up.InputText.Trim();
            labmad_down = txtLambda_Down.InputText.Trim();

            if (string.IsNullOrEmpty(lambad_up) || string.IsNullOrEmpty(labmad_down))
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "限值不能为空", ContentAlignment.MiddleCenter, 1000);
                return;
            }

            Regex regex = new Regex("^[0-9]{1}([.]{1}[0-9]+){0,1}$");
            if (!regex.IsMatch(labmad_down) || !regex.IsMatch(lambad_up))
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "限值格式不正确", ContentAlignment.MiddleCenter, 1000);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetLambad_Up 
        {
            get { return lambad_up; }
        }

        public string GetLambad_Down
        {
            get { return labmad_down; }
        }
    }
}
