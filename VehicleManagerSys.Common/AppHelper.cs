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
        //字段转换文件夹路径
        public static string AutoMapperConfigs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoMapperConfig");
        //数据库配置文件
        public static string DbConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "DbConfig.json"); 
        //综检联网信息配置文件
        public static string ComprehensiveConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "ComprehensiveConfig.json");
        //环保联网信息配置文件
        public static string EnvironmentConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "EnvironmentConfig.json");
        //用户信息
        public static UserInfo UserInfo = new UserInfo() { UserName = "(未登录)" };
        //数据库常量
        public static List<Constant> Constants = new List<Constant>();
        
        public static DbInfo DbSetting = null;
        public static ComprehensiveInfo ComprehensiveSetting = null;
        public static EnvironmentNetSetting EnvironmentNetSetting = null;

        public static List<NetTypeDefine> NetDefine = new List<NetTypeDefine>();
        public static Form MainForm = null;

        public static volatile object AppLocker = new object();



        static AppHelper()
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);

            if (!Directory.Exists(AutoMapperConfigs))
                Directory.CreateDirectory(AutoMapperConfigs);

            if (!File.Exists(DbConfigFile))
                File.WriteAllText(DbConfigFile, JsonConvert.SerializeObject(new DbInfo(), Formatting.Indented));

            if (!File.Exists(ComprehensiveConfigFile))
                File.WriteAllText(ComprehensiveConfigFile, JsonConvert.SerializeObject(new ComprehensiveInfo(), Formatting.Indented));

            if (!File.Exists(EnvironmentConfigFile))
                File.WriteAllText(EnvironmentConfigFile, JsonConvert.SerializeObject(new EnvironmentNetSetting(), Formatting.Indented));
            
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
                EnvironmentNetSetting = JsonConvert.DeserializeObject<EnvironmentNetSetting>(File.ReadAllText(EnvironmentConfigFile));
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

        public bool InitNetDefine()
        {
            bool succ = true;
            try
            {
                NetDefine = Live0xUtils.DbUtils.SqlServer.MssqlHelper.GetInstance().QueryList<NetTypeDefine>("SELECT * FROM NetTypeDefine", null).ToList();
     
                if (NetDefine == null || NetDefine.Count == 0)
                {
                    succ = false;
                    File.WriteAllText(AppHelper.ConfigFolder + "DefineType.txt", "读取定义信息失败,不能进行正常检测");
                }
                File.WriteAllText(AppHelper.ConfigFolder + "DefineType.txt", JsonConvert.SerializeObject(new List<object>() { NetDefine }, Formatting.Indented));
            }
            catch (Exception ex)
            {
                succ = false;
                //File.WriteAllText("初始化定义信息失败.txt", ex.Message);
                //MessageBox.Show("读取定义信息失败：" + ex.Message);
                //File.WriteAllText(AppHelper.ConfigFolder + "DefineType.txt", "读取定义信息失败：" + ex.Message);
            }
            return succ;
        }

        public  void  LoadContsatnt()
        {
            try
            {
                string sql = "SELECT CON_CHNAME AS ConstantType,CON_CODE AS Code,CON_CON AS Name  FROM CONST_DEFINE";
                Constants = Live0xUtils.DbUtils.SqlServer.MssqlHelper.GetInstance().QueryList<Constant>(sql,null).ToList();
                if (Constants != null)
                {
                    Constants.Add(new Constant() { Code = "0", Name = "蓝牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "1", Name = "黄牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "2", Name = "白牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "3", Name = "黑牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "4", Name = "绿牌", ConstantType = "HPYS_Ex" });
                    Constants.Add(new Constant() { Code = "5", Name = "黄绿", ConstantType = "HPYS_Ex" });
                }

                if (File.Exists("constant.json"))
                {
                    string constantJson = File.ReadAllText("constant.json",Encoding.GetEncoding("GB2312"));
                    List<Constant> fileConstants = JsonConvert.DeserializeObject<List<Constant>>(constantJson);
                    Constants.AddRange(fileConstants.ToArray());
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

        public static string  GetFileContent(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);
            throw new Exception("文件不存在");
        }

        public static string GetNetType(string type, string local)
        {
            NetTypeDefine define = NetDefine.Where(p => p.DefineType.Equals(type) && p.LocalCode.Equals(local.Replace(",", "").Replace("，", ""))).FirstOrDefault();
            if (define != null)
            {
                return define.NetCode;
            }
            return local;
        }

        public static string GetLocalType(string type, string net)
        {
            NetTypeDefine define = NetDefine.Where(p => p.DefineType.Equals(type) && p.NetCode.Equals(net)).FirstOrDefault();
            if (define != null)
            {
                return define.LocalCode;
            }
            return net;
        }

        public static void CreatePblicKey()
        { 
        }

        public static void CreatePrivateKey()
        { 
        }
       
    }
}
