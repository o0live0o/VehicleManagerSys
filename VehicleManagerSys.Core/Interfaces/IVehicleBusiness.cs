using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Dtos;

namespace VehicleManagerSys.Core.Interfaces
{
    public interface IVehicleBusiness
    {
        AppMessage SearchCar(VehicleInfo info);

        AppMessage SendCar(VehicleInfo info);

        AppMessage SaveCar(VehicleInfo info);
    }
}
