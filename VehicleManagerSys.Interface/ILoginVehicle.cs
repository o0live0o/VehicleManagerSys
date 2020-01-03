using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Interface
{
    public interface ILoginVehicle
    {
        Result<string> Login<VehicleInfo>(VehicleInfo vehicleInfo);

        string LoginReturnJson<VehicleInfo>(VehicleInfo vehicleInfo);

        Result Login<VehicleInfo,Result>(VehicleInfo vehicleInfo);
    }
}
