using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DigitsAttribute : Attribute
    {
        public int _diigits = 0;
        public DigitsAttribute(int i)
        {
            _diigits = i;
        }

        public object Validate(object o)
        {
            //double d = 0.0;
            //if (o != null && double.TryParse(Convert.ToString(o), out d))
            //{
            //    return Math.Round(d, _diigits).ToString();
            //}
            decimal d;
            if (o != null && decimal.TryParse(Convert.ToString(o), out d))
            {
                System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();

                nfi.NumberDecimalDigits = _diigits;

                return d.ToString("N", nfi);
            }
            return o;
        }

        public object DigitsFormat(object o, Type type)
        {
            decimal d;
            if (o != null && decimal.TryParse(Convert.ToString(o), out d))
            {
                //System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
                //nfi.NumberDecimalDigits = _diigits;
                string s = Math.Round(d, _diigits).ToString();
                if (!type.IsGenericType)
                {
                    return Convert.ChangeType(s, type);
                }
                else
                {
                    Type genericTypeDefinition = type.GetGenericTypeDefinition();
                    if (genericTypeDefinition == typeof(Nullable<>))
                    {
                        return Convert.ChangeType(s, type.GetGenericArguments()[0]);
                    }
                }
            }
            return o;
        }
    }
}
