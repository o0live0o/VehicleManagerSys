using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Dtos
{
    public class Constant
    {
        public Constant()
        {
            Code = "";
            Name = "";
            ConstantType = "";
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ConstantType { get; set; }
    }
}
