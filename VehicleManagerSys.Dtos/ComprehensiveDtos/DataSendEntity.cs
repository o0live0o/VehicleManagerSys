using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class DataSendEntity
    {
        public string userCode { get; set; }

        public string hmac { get; set; }

        public string vehicleNo { get; set; }

        public string plateColorCode { get; set; }

        public string CompanyId { get; set; }

        public string Source { get; set; }

        public string IPCType { get; set; }

        public object Value { get; set; }
    }
}
