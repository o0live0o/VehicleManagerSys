using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Main
{
    public abstract class SimpleFactory
    {
        public static T GetObjcet<T>()
        {
            Assembly assembly = Assembly.Load("VehicleManagerSys.LoginIvs");
            Type type  = assembly.GetType("VehicleManagerSys.LoginIvs." + typeof(T).Name.Substring(1,typeof(T).Name.Length-1));
            object obj = Activator.CreateInstance(type);
            return (T)obj;
        }
    }
}
