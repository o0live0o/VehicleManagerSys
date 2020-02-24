using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using HZH_Controls.Forms;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class AreaCodeForm : FrmBase
    {
        public string AreaCode { get; set; }

        private Dictionary<string, string> dic = new Dictionary<string, string>();

        public AreaCodeForm()
        {
            InitializeComponent();
        }

        public void LoadLoaclMsg()
        {
            try
            {
                if (File.Exists("地区编码.txt"))
                {
                    List<string> list = new List<string>();
                    foreach (string str in File.ReadLines("地区编码.txt", Encoding.GetEncoding("gbk")))
                    {
                        try
                        {
                            Regex regex = new Regex("(?<Code>\\S+)(?<Code1>\\s+)(?<Name>.*)");
                            Match match = regex.Match(str);
                            dic.Add(match.Groups["Code"].Value, match.Groups["Name"].Value);
                        }
                        catch 
                        {
                            throw;
                        }
                    }
                    dgvCode.DataSource = (from v in dic select new { Code = v.Key, Name = v.Value }).ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        private void SearchCode(string Name)
        {
            try
            {
                dgvCode.DataSource = (from v in dic.Where(s => s.Value.Contains(Name)) select new { Code = v.Key, Name = v.Value }).ToArray();
            }
            catch
            {
                throw;
            }
        }

        private void dgvCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic item = dgvCode.CurrentRow.DataBoundItem as object;
            AreaCode = item.Code;
            if(!string.IsNullOrEmpty(AreaCode))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }

            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SearchCode(txtName.Text.Trim());
        }

        private void AreaCodeForm_Shown(object sender, EventArgs e)
        {
            LoadLoaclMsg();
        }
    }
}
