using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Common
{

    public abstract class LogHelper
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Error(string msg)
        {
            logger.Error(msg);
        }

        public static void Debug(string msg)
        {
            logger.Debug(msg);
        }

        public static void Trace(string msg)
        {
            logger.Trace(msg);
        }
    }
}
