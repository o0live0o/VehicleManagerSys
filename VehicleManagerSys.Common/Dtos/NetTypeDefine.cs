using Live0xUtils.DbUtils.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common.Dtos
{
    public class NetTypeDefine
    {
        [KeyField]
        public int ID { get; set; }

        public string DefineType { get; set; }

        public string LocalName { get; set; }

        public string LocalCode { get; set; }

        public string NetName { get; set; }

        public string NetCode { get; set; }

        public string Remark { get; set; }
    }
}
