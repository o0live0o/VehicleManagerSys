using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class brake
    {
        public List<initData> initData
        {
            get;
            set;
        }

        public wholeVehicle wholeVehicle
        {
            get;
            set;
        }

        public List<singleAxle> singleAxle
        {
            get;
            set;
        }

        public roadTest roadTest
        {
            get;
            set;
        }
    }
}
