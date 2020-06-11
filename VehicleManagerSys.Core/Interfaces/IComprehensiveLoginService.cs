using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Core.Interfaces
{
    interface IComprehensiveLoginService
    {
        string GetSerialNumber(Entity.IVS.VEHICLE_DISPATCH instance);
    }
}
