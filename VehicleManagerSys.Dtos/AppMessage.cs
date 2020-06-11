using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Dtos
{
    public class AppMessage
    {
        private bool _succ = false;
        private string _msg = "";
        private string _netTestNo = "";
        private string _localTestNo = "";
        private string _times = "1";
        private string _detectItem = "";
        private VehicleInfo _vehicleInfo = null;

        public bool Succ { get => _succ; set => _succ = value; }
        public string Msg { get => _msg; set => _msg = value; }
        public VehicleInfo VehicleInfo { get => _vehicleInfo; set => _vehicleInfo = value; }
        public string NetTestNo { get => _netTestNo; set => _netTestNo = value; }
        public string LocalTestNo { get => _localTestNo; set => _localTestNo = value; }
        public string Times { get => _times; set => _times = value; }
        public string DetectItem { get => _detectItem; set => _detectItem = value; }
    }
}
