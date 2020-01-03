using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Dtos.Emuns;

namespace VehicleManagerSys.Dtos
{
    [Serializable]
    public class CheckItem
    {
        public CheckItem()
        {
            IsCheck = false;
        }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public List<FuelEnum> FuelType { get; set; }
        public bool IsCheck { get; set; }
    }
}
