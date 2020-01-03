using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class emission
    {
        public gasolineVehicle gasolineVehicle
        {
            get;
            set;
        }

        public dieselVehicle dieselVehicle
        {
            get;
            set;
        }
    }
}
