using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Main
{
    public abstract class MainConstant
    {
        //ini文件节点名
        public const string SignalConfig = "报检配置";

        //ini文件键名
        public const string IsNetSearch = "IsNetSearch";   //是否联网查询

        public const string IsNetPFSearch = "IsNetPFSearch";   //是否排放联网查询

        public const string PlateNoArea = "PlateNoArea";  //号牌所属区域

        public const string DetectTypeTxt = "DetectTypeTxt"; //检验类别

        public const string DetectType = "DetectType"; //检验类别代号
    }
}
