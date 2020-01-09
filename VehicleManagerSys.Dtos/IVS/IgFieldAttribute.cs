using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos.IVS
{

    /// <summary>
    /// 程序自定义的字段忽略规则
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class IgFieldAttribute : Attribute
    {

    }
}
