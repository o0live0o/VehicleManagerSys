using CI.UIComponents.Helper;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldConfig
{
    public partial class Form1 : FrmWithTitle
    {
        private Items[] items = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FieldConfig fieldConfig = new FieldConfig();
            entityFiller1.FillEntity(fieldConfig.I);
        }

        public class FieldConfig
        {
            public Items[] I
            { get; set; }
        }

        public class Items
        {
            public string Item1 { get; set; }
            public string Item3 { get; set; }
        }
    }
}
