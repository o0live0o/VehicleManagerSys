using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common.Attributes;

namespace VehicleManagerSys.Common
{
    public abstract class AppTools
    {
        /*
        * Src : 数据源
        * Dst：被填充的目标实体
        * Dst用特性标记Src里对应的字段
        */
        public static void FillEntiyByAttr<Src, Dst>(Src src, Dst dst)
        {
            PropertyInfo[] scrInfos = src.GetType().GetProperties();
            PropertyInfo[] dstInfos = dst.GetType().GetProperties();
            foreach (PropertyInfo dstInfo in dstInfos)
            {
                var attributes = dstInfo.GetCustomAttributes(typeof(MapperAttribute), false);
                foreach (var att in attributes)
                {
                    MapperAttribute attribute = att as MapperAttribute;
                    if (attribute != null && !string.IsNullOrEmpty(attribute.TagName))
                    {
                        foreach (PropertyInfo srcInfo in scrInfos)
                        {
                            try
                            {
                                if (srcInfo.Name.Equals(attribute.TagName))
                                {
                                    object o = srcInfo.GetValue(src, null);
                                    if (o != null && !string.IsNullOrEmpty(Convert.ToString(o)))
                                    {
                                        if (!dstInfo.PropertyType.IsGenericType)
                                        {
                                            dstInfo.SetValue(dst, o == null ? null : Convert.ChangeType(o, dstInfo.PropertyType), null);
                                        }
                                        else
                                        {
                                            Type genericTypeDefinition = dstInfo.PropertyType.GetGenericTypeDefinition();
                                            if (genericTypeDefinition == typeof(Nullable<>))
                                            {
                                                dstInfo.SetValue(dst, o == null ? null : Convert.ChangeType(o, dstInfo.PropertyType.GetGenericArguments()[0]), null);
                                            }
                                        }
                                        DigitsAttribute digitsAttr = dstInfo.GetCustomAttributes(typeof(DigitsAttribute), false).FirstOrDefault() as DigitsAttribute;
                                        if (digitsAttr != null)
                                        {
                                            dstInfo.SetValue(dst, digitsAttr.DigitsFormat(dstInfo.GetValue(dst, null), dstInfo.PropertyType), null);
                                        }

                                        DefineAttribute judgeAttr = dstInfo.GetCustomAttributes(typeof(DefineAttribute), false).FirstOrDefault() as DefineAttribute;
                                        if (judgeAttr != null)
                                        {
                                            dstInfo.SetValue(dst, judgeAttr.ChangeVal(dstInfo.GetValue(dst, null), dstInfo.PropertyType), null);
                                        }

                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Live0xUtils.LogUtils.ConsoleLog.Error("FillTools_" + dstInfo.Name + "_" + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        /*
        * Src : 数据源
    * Dst：被填充的目标实体
* Src用特性标记Dst里对应的字段
*/
        public static void FillEntityByAttrReverse<Src, Dst>(Src src, Dst dst)
        {
            PropertyInfo[] scrInfos = src.GetType().GetProperties();
            PropertyInfo[] dstInfos = dst.GetType().GetProperties();

            foreach (var srcInfo in scrInfos)
            {
                MapperAttribute attribute = srcInfo.GetCustomAttributes(typeof(MapperAttribute), false).FirstOrDefault() as MapperAttribute;
                if (attribute != null)
                {
                    foreach (var dstInfo in dstInfos)
                    {
                        if (dstInfo.Name.ToLower().Equals(attribute.TagName.ToLower()))
                        {
                            object o = srcInfo.GetValue(src, null);
                            if (!dstInfo.PropertyType.IsGenericType)
                            {
                                dstInfo.SetValue(dst, o == null ? null : Convert.ChangeType(o, dstInfo.PropertyType), null);
                            }
                            else
                            {
                                Type genericTypeDefinition = dstInfo.PropertyType.GetGenericTypeDefinition();
                                if (genericTypeDefinition == typeof(Nullable<>))
                                {
                                    dstInfo.SetValue(dst, o == null ? null : Convert.ChangeType(o, dstInfo.PropertyType.GetGenericArguments()[0]), null);
                                }
                            }


                            DigitsAttribute digitsAttr = srcInfo.GetCustomAttributes(typeof(DigitsAttribute), false).FirstOrDefault() as DigitsAttribute;
                            if (digitsAttr != null)
                            {
                                dstInfo.SetValue(dst, digitsAttr.DigitsFormat(srcInfo.GetValue(src, null), dstInfo.PropertyType), null);
                            }

                            DefineAttribute judgeAttr = srcInfo.GetCustomAttributes(typeof(DefineAttribute), false).FirstOrDefault() as DefineAttribute;
                            if (judgeAttr != null)
                            {
                                dstInfo.SetValue(dst, judgeAttr.ChangeValReverse(srcInfo.GetValue(src, null), dstInfo.PropertyType), null);
                            }
                        }
                    }
                }
            }

        }
    }
}
