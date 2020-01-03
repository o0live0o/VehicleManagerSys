using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HZH_Controls.Forms;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class LoadingForm : FrmLoading
    {
        public LoadingForm(string s = "正在加载……")
        {
            InitializeComponent();
            label2.Text = s;
        }
        protected override void BindingProcessMsg(string strText, int intValue)
        {
            label1.Text = strText;
            this.ucProcessLineExt1.Value = intValue;
        }
    }
}
