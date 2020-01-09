using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Core.Interfaces
{
    interface IComprehensiveUploadService
    {
        bool UploadReport();

        bool VehicleLogin(string testNo);
    }
}
