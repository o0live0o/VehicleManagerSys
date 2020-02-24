using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Attributes
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    public class MapperAttribute :Attribute
    {
        public string TagName = "";
        public MapperAttribute(string TagName)
        {
            this.TagName = TagName;
        }

        
    }
}
