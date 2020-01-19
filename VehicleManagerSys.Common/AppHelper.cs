using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagerSys.Common.Dtos;

namespace VehicleManagerSys.Common
{
    public  class AppHelper
    {
        private static AppHelper _appHelper = null;
        //配置文件夹路径
        public static string ConfigFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs");  
        //数据库配置文件
        public static string DbConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "DbConfig.json"); 
        //综检上传信息配置文件
        public static string ComprehensiveConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "ComprehensiveConfig.json");
        //用户信息
        public static UserInfo UserInfo = new UserInfo() { UserName = "(未登录)" };
        //数据库常量
        public static List<Constant> Constants = new List<Constant>();

        public static DbInfo DbSetting = null;
        public static ComprehensiveInfo ComprehensiveSetting = null;


        public static Form MainForm = null;

        public static volatile object AppLocker = new object();



        static AppHelper()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);

            if (!File.Exists(DbConfigFile))
                File.WriteAllText(DbConfigFile, JsonConvert.SerializeObject(new DbInfo(), Formatting.Indented));

            if (!File.Exists(ComprehensiveConfigFile))
                File.WriteAllText(ComprehensiveConfigFile, JsonConvert.SerializeObject(new ComprehensiveInfo(), Formatting.Indented));

            _appHelper = new AppHelper();
        }

        private AppHelper()
        {
            InitConfig();
        }

        public static AppHelper GetInstance()
        {
            return _appHelper;
        }

        private void InitConfig()
        {
            try
            {
                DbSetting = JsonConvert.DeserializeObject<DbInfo>(File.ReadAllText(DbConfigFile));
                ComprehensiveSetting = JsonConvert.DeserializeObject<ComprehensiveInfo>(File.ReadAllText(ComprehensiveConfigFile));
                if (!string.IsNullOrEmpty(ComprehensiveSetting.ImagePath) && !Directory.Exists(ComprehensiveSetting.ImagePath))
                {
                    Directory.CreateDirectory(ComprehensiveSetting.ImagePath);
                }
            }
            catch
            {
                throw;
            }
        }

        public  void  LoadContsatnt()
        {
            try
            {
                string sql = "SELECT CON_CHNAME AS ConstantType,CON_CODE AS Code,CON_CON AS Name  FROM CONST_DEFINE";
                Constants = Live0xUtils.DbUtils.SqlServer.MssqlHelper.GetInstance().QueryList<Constant>(sql,null).ToList();
                if (Constants != null)
                {
                    Constants.Add(new Constant() { Code = "1", Name = "是", ConstantType = "SysYesOrNo"});
                    Constants.Add(new Constant() { Code = "0", Name = "否", ConstantType = "SysYesOrNo" });
                    Constants.Add(new Constant() { Code = "1", Name = "限值a", ConstantType = "StandardType" });
                    Constants.Add(new Constant() { Code = "2", Name = "限值b", ConstantType = "StandardType" });

                    Constants.Add(new Constant() { Code = "0", Name = "蓝牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "1", Name = "黄牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "2", Name = "白牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "3", Name = "黑牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "4", Name = "绿牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "5", Name = "黄绿", ConstantType = "HPYS_Ex" });
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 根据Code找到CONSTDEFINE表中对应的中文名
        /// </summary>
        /// <param name="type"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetDefineName(string type, string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                Constant localTypeDefine = Constants.Where(p => p.ConstantType.Equals(type) && p.Code.Equals(code)).FirstOrDefault();
                if (localTypeDefine != null)
                {
                    return localTypeDefine.Name;
                }
            }
            return "";
        }


        /// <summary>
        /// 根据中文名找到CONSTDEFINE表中对应的Code
        /// </summary>
        /// <param name="type"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetDefineCode(string type, string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Constant localTypeDefine = Constants.Where(p => p.ConstantType.Equals(type) && p.Name.Equals(name)).FirstOrDefault();
                if (localTypeDefine != null)
                {
                    return localTypeDefine.Code;
                }
            }
            return "";
        }

        public static void CreatePblicKey()
        { 
        }

        public static void CreatePrivateKey()
        { 
        }
       
    }
}
