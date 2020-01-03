using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos.Emuns
{
    public enum FuelEnum
    {
        [Description("汽油")]
        Gasoline = 1,
        [Description("柴油")]
        Diesel = 2,
        [Description("混合动力")]
        Mixture = 3
    }
}
