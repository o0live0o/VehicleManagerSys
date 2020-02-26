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
    public partial class YunWangReCheckOptForm : FrmWithTitle
    {
        private bool b_Checkappearance = false;

        public YunWangReCheckOptForm(string plateNo,string testNo)
        {
            InitializeComponent();
            this.Title = plateNo;
            this.txtTestNo.InputText = testNo;
        }

        private void btnConfirm_BtnClick(object sender, EventArgs e)
        {
            b_Checkappearance = chkAppearence.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool IsCheckAppearance
        {
            get { return b_Checkappearance; }
        }

    }
}
