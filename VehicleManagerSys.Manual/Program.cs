using Live0xUtils.DbUtils.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common;

namespace VehicleManagerSys.Manual
{
    static class Program
    {
        public static System.Threading.Mutex Run;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bRun = false;
            Run = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out bRun);
            if (bRun)
            {

                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //初始化配置文件
                    AppHelper.GetInstance();
                    Application.DoEvents();
                    //初始化数据库连接
                    if (AppHelper.DbSetting != null)
                        MssqlHelper.GetInstance().Init(AppHelper.DbSetting.DataBaseServer,
                            AppHelper.DbSetting.DataBaseName,
                            AppHelper.DbSetting.DataBaseUser,
                            AppHelper.DbSetting.DataBasePwd);

                    LoadingForm frmLoading = new LoadingForm("正在加载系统...");
                    frmLoading.BackgroundWorkAction = delegate ()
                    {
                        try
                        {
                            frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "正在加载常量...");
                            AppHelper.GetInstance().LoadContsatnt();
                            frmLoading.CurrentMsg = new KeyValuePair<int, string>(30, "正在加载常量...");
                            AppHelper.GetInstance().InitNetDefine();
                            frmLoading.CurrentMsg = new KeyValuePair<int, string>(50, "正在加载常量...");
                            AppHelper.GetInstance().InitDb();
                            frmLoading.CurrentMsg = new KeyValuePair<int, string>(70, "正在加载用户...");
                            AppCache.LoadCache();
                            frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "加载完成！");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("加载系统时出现错误：" + ex.Message);
                        }
                    };
                    frmLoading.ShowDialog();
                    Application.Run(new SearchCarForm());
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }
    }
}
