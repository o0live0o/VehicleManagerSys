using HZH_Controls;
using HZH_Controls.Forms;
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
            if (AppHelper.MainForm != null)
            {
                ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                {
                        FrmTips.ShowTips(AppHelper.MainForm, msg, 5000, true, System.Drawing.ContentAlignment.BottomRight, null, TipsSizeMode.None, new System.Drawing.Size(300, 123), TipsState.Error);
                });
            }
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
