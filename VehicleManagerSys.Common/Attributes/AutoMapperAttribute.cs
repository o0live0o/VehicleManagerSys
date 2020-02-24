using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Attributes
{
    public class AutoMapperAttribute :Attribute
    {
        public string MapName { get; set; }

        public string AimType { get; set; }

        public AutoMapperAttribute(string AimType, string MapName)
        {
            this.MapName = MapName;
            this.AimType = AimType;
        }
    }
}
