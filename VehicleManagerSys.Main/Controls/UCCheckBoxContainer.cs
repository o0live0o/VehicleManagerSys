using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;

namespace VehicleManagerSys.Main.Controls
{
    public partial class UCCheckBoxContainer : UserControl
    {


        public UCCheckBoxContainer()
        {
            InitializeComponent();
        }

        public void AddCheckItem(IEnumerable<KeyValuePair<string, string>> list)
        {
            flpContainer.Controls.Clear();
            var enums = list.GetEnumerator();
            while (enums.MoveNext())
            {
                var s = enums.Current;
                var checkBox = new UCCheckBox();
                checkBox.TextValue = s.Key;
                checkBox.Tag = s.Value;
                flpContainer.Controls.Add(checkBox);
            }
        }

    public IEnumerable<string> GetCheckVal()
        {
            foreach (var item in flpContainer.Controls)
            {
                if (item is UCCheckBox)
                {
                    UCCheckBox checkBox = item as UCCheckBox;
                    if (checkBox.Checked && checkBox.Tag != null && !string.IsNullOrEmpty(checkBox.Tag.ToString()))
                        yield return checkBox.Tag.ToString();
                }
            }
        }

        public IEnumerable<KeyValuePair<string, string>> GetCheckItem()
        {
            foreach (var item in flpContainer.Controls)
            {
                if (item is UCCheckBox)
                {
                    UCCheckBox checkBox = item as UCCheckBox;
                    if (checkBox.Checked && checkBox.Tag != null && !string.IsNullOrEmpty(checkBox.Tag.ToString()))
                        yield return new KeyValuePair<string, string>(checkBox.TextValue,checkBox.Tag.ToString());
                }
            }
        }

    }
}
