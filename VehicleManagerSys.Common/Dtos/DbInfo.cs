using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Dtos
{
    public class DbInfo
    {
        private string _dataBaseName;
        private string _dataBaseServer;
        private string _dataBaseUser;
        private string _dataBasePwd;

        public string DataBaseName { get => _dataBaseName; set => _dataBaseName = value; }
        public string DataBaseServer { get => _dataBaseServer; set => _dataBaseServer = value; }
        public string DataBaseUser { get => _dataBaseUser; set => _dataBaseUser = value; }
        public string DataBasePwd { get => _dataBasePwd; set => _dataBasePwd = value; }
    }
}
