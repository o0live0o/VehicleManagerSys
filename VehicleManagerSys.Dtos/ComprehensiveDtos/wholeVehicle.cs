using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class wholeVehicle
    {
        public singleVehicle singleVehicle
        {
            get;
            set;
        }

        public vehicleSerial1 vehicleSerial1
        {
            get;
            set;
        }

        public brakeSeqTime brakeSeqTime
        {
            get;
            set;
        }

        public brakeSeq brakeSeq
        {
            get;
            set;
        }

        public vehicleSerial2 vehicleSerial2
        {
            get;
            set;
        }
    }
}
