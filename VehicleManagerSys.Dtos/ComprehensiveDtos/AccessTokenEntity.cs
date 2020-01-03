using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class AccessTokenEntity
    {
        public string code { get; set; }

        public string status { get; set; }

        public string access_token { get; set; }
    }
}
