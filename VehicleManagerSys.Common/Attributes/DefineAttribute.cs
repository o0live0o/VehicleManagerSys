using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DefineAttribute : Attribute
    {
        public string DefineType = null;
        public DefineAttribute(string defineType)
        {
            DefineType = defineType;
        }

        public object ChangeVal(object o, Type type)
        {
            if (!string.IsNullOrEmpty(DefineType))
            {
                if (!type.IsGenericType)
                {
                    return Convert.ChangeType(AppHelper.GetNetType(DefineType, Convert.ToString(o)), type);
                }
                else
                {
                    Type genericTypeDefinition = type.GetGenericTypeDefinition();
                    if (genericTypeDefinition == typeof(Nullable<>))
                    {
                        return Convert.ChangeType(AppHelper.GetNetType(DefineType, Convert.ToString(o)), type.GetGenericArguments()[0]);
                    }
                }
            }
            return o;
        }


        public object ChangeValReverse(object o, Type type)
        {
            if (!string.IsNullOrEmpty(DefineType))
            {
                if (!type.IsGenericType)
                {
                    return Convert.ChangeType(AppHelper.GetLocalType(DefineType, Convert.ToString(o)), type);
                }
                else
                {
                    Type genericTypeDefinition = type.GetGenericTypeDefinition();
                    if (genericTypeDefinition == typeof(Nullable<>))
                    {
                        return Convert.ChangeType(AppHelper.GetLocalType(DefineType, Convert.ToString(o)), type.GetGenericArguments()[0]);
                    }
                }
            }
            return o;
        }
    }
}
