using Live0xUtils.XMLUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos.SafetyTest
{
    [XEle("QueryCondition")]
    public class Request_18C49
    {
        public Request_18C49()
        {
            jylb = "01";
        }

        public string hphm { get; set; }

        public string hpzl { get; set; }

        public string clsbdh { get; set; }

        public string jyjgbh { get; set; }

        public string jylb { get; set; }
    }
}
