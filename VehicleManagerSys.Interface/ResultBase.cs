using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Interface
{
    public class Result<T>
    {
        public Result()
        {
            Succ = false;
            Msg = "";
        }

        public bool Succ { get; set; }

        public string Msg { get; set; }

        public T Entity { get; set; }
    }
}
