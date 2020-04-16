using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live0xUtils.DbUtils.SqlServer;
using System.Collections;
using VehicleManagerSys.Common;
using HZH_Controls;
using System.Threading;
using VehicleManagerSys.Entity.IVS;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class LoginForm : FrmWithTitle
    {
        public LoginForm()
        {
            InitializeComponent();
            //Dictionary<int, string> keyDic = new Dictionary<int, string>();
            //keyDic.Add(13, "Enter");
            //keyDic.Add(65, "A");
            //this.HotKeys = keyDic;
        }

        private void btnCancel_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_BtnClick(object sender, EventArgs e)
        {
            labWarn.Text = "";
            string user = txtUser.InputText.Trim();
            string pwd = txtPwd.InputText.Trim();
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pwd))
            {
                labWarn.Text = "用户名、密码不能为空！";
                return;
            }
            pwd =  Live0xUtils.Encryption.EncryptionMD5.GetMD5Hash(user+pwd);
            EMPLOYEE_USER emplpyee = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    string sql = "SELECT * FROM EMPLOYEE_USER WHERE EMPLOYEE_ID = @EMPLOYEE_ID AND EMPLOYEE_PWD = @EMPLOYEE_PWD";
                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("EMPLOYEE_ID", user);
                    hashtable.Add("EMPLOYEE_PWD", pwd);
                    emplpyee = MssqlHelper.GetInstance().Query<EMPLOYEE_USER>(sql, hashtable);
                    ControlHelper.ThreadInvokerControl(this, () =>
                    {

                        if (emplpyee != null && !string.IsNullOrEmpty(emplpyee.EMPLOYEE_NAME) && !string.IsNullOrEmpty(emplpyee.ID))
                        {
                            AppHelper.UserInfo.UserName = emplpyee.EMPLOYEE_NAME;
                            AppHelper.UserInfo.Power = emplpyee.LICENSE_NAME;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            labWarn.Text = "*登录失败，用户名或密码错误！";
                        }
                    });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(this, () =>
                    {
                        FrmTips.ShowTipsError(this,ex.Message);
                    });
                }
            }, null, this,true,"正在登录……",200);
        
        }

        private void labDbSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DbSettingForm dbSettingForm = new DbSettingForm();
            dbSettingForm.IsShowCloseBtn = true;
            dbSettingForm.ShowDialog(this); 
        }

        private bool LoginForm_HotKeyDown(string strHotKey)
        {
            return true;
        }
    }
}
