using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common;
using VehicleManagerSys.Entity.IVS;

namespace VehicleManagerSys.Manual
{
    public abstract class AppCache
    {
        public static void LoadCache()
        {
            LoadUser();
        }

        #region 人员缓存
        private static List<EMPLOYEE_USER> _users = new List<EMPLOYEE_USER>();

        private static void LoadUser() => _users = AppHelper.Db.QueryList<EMPLOYEE_USER>("SELECT * FROM EMPLOYEE_USER", null).ToList();

        public static IEnumerable<EMPLOYEE_USER> GetUsers(Func<EMPLOYEE_USER, bool> func)
        {
            if (_users == null || func == null)
                throw new Exception();

            var e = _users.GetEnumerator();
            while (e.MoveNext())
            {
                if (func(e.Current))
                    yield return e.Current;
            }
        }
    }
    #endregion

}
