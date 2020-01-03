using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Dtos
{
    public class UserInfo
    {
        private string _userAccount;
        private string _pwd;
        private string _userName;
        private string _power;

        public string UserAccount { get => _userAccount; set => _userAccount = value; }
        public string Pwd { get => _pwd; set => _pwd = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Power { get => _power; set => _power = value; }
    }
}
