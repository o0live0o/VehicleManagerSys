using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos.BB
{
     public class ENV_TESTINFO
    {
        public ENV_TESTINFO()
        {
            VIN = "";
            TESTNO = "";
            CREATEDATE = "";
            STATUS = "";
            XXGKBH = "";
            OTESTDATE = "";
        }
        public string VIN { get; set; }
        public string TESTNO { get; set; }
        public string CREATEDATE { get; set; }
        public string STATUS { get; set; }
        public string XXGKBH { get; set; }

        public string OTESTDATE { get; set; }
    }
}
