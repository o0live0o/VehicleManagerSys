using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common;

namespace VehicleManagerSys.Core.ExtendMethods
{
    public static class ExtendMethod
    {

        public static string ManualMsg(this string s)
        {
            if (string.IsNullOrEmpty(s) || s == "-")
            {
                s = "无";
            }
            return s;
        }

        public static string GetBZZ(this string s, string plateType)
        {
            string strResult = "无";
            string strType = "";
            try
            {
                //if (plateType.Contains("Q"))
                //{
                //    strType = "牵";
                //}
                //else if (plateType.Contains("H"))
                //{
                //    strType = "货";
                //}
                //else if (plateType.Contains("K"))
                //{
                //    strType = "客";
                //}

                if (!string.IsNullOrEmpty(s) && s != "0" && !string.IsNullOrEmpty(strType))
                {
                    if (s == "1")
                    {
                        strResult = "并装双轴";
                    }
                    else if (s == "2")
                    {
                        strResult = "并装三轴";
                    }
                }
            }
            catch (Exception ex)
            {
                strResult = "无";
            }
            return strResult;
        }

        public static string To_Int_Str(this string s, string DefaultVal = "")
        {
            int i;
            string strResult = DefaultVal;
            if (int.TryParse(s, out i))
            {
                strResult = i.ToString();
            }
            return strResult;
        }

        public static string To_Double(this string s, int num = 0, string DefaultVal = "")
        {
            double d;
            string strResult = DefaultVal;
            if (double.TryParse(s, out d))
            {

                strResult = Math.Round(d, num).ToString();
            }
            return strResult;
        }

        public static string To_Net_HPYS(this string s)
        {
            string strResult = "1";
            if (!string.IsNullOrEmpty(s))
            {
                switch (s)
                {
                    case "蓝":
                        strResult = "1";
                        break;
                    case "黄":
                        strResult = "2";
                        break;
                    case "黑":
                        strResult = "3";
                        break;
                    case "白":
                        strResult = "4";
                        break;
                    case "绿":
                        strResult = "5";
                        break;
                    case "其他":
                        strResult = "9";
                        break;
                    case "农黄":
                        strResult = "91";
                        break;
                    case "农绿":
                        strResult = "92";
                        break;
                    case "黄绿":
                        strResult = "93";
                        break;
                    case "渐变绿":
                        strResult = "94";
                        break;
                }


            }
            return strResult;
        }

        public static int To_ZXZSL(this string s)
        {
            if (s == "1")
            {
                return 1;
            }
            else if (s == "2")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public static string To_Net_CSYS(this string s)
        {
            string strResult = "Z";
            s = s.Replace(",", "");
            switch (s)
            {
                case "白":
                    strResult = "A";
                    break;
                case "灰":
                    strResult = "B";
                    break;
                case "黄":
                    strResult = "C";
                    break;
                case "粉":
                    strResult = "D";
                    break;
                case "红":
                    strResult = "E";
                    break;
                case "紫":
                    strResult = "F";
                    break;
                case "绿":
                    strResult = "G";
                    break;
                case "蓝":
                    strResult = "H";
                    break;
                case "棕":
                    strResult = "I";
                    break;
                case "黑":
                    strResult = "J";
                    break;
                case "白绿":
                    strResult = "Y";
                    break;
            }
            return strResult;
        }

        public static string To_Unbalance_Result(this string strPd, string strBPHLV, bool bQZ)
        {
            string strResult = "-1";
            float fBPHLV = 100;
            if (strPd == "0")
            {
                return "4";
            }
            if (float.TryParse(strBPHLV, out fBPHLV))
            {
                if (strPd == "1")
                {
                    if (bQZ)
                    {
                        if (fBPHLV <= 20)
                        {
                            strResult = "1";
                        }
                        else
                        {
                            strResult = "2";

                        }
                    }
                    else
                    {
                        if (fBPHLV <= 24)
                        {
                            strResult = "1";
                        }
                        else
                        {
                            strResult = "2";
                        }
                    }
                }
                else if (strPd == "10")
                {
                    strResult = "1";
                }
                else if (strPd == "11")
                {
                    strResult = "2";
                }
                else
                {
                    strResult = "-1";
                }
            }
            return strResult;
        }

        public static string To_Net_Date(this string s)
        {
            string strResult = s;
            DateTime d;
            if (DateTime.TryParse(s, out d))
            {
                strResult = d.ToString("yyyyMMdd");
            }
            return strResult;
        }

        public static string To_Net_ZJPD(this string s)
        {
            string strResult = "N";

            switch (s)
            {
                case "0":
                    strResult = "4";
                    break;
                case "1":
                    strResult = "0";
                    break;
                case "2":
                    strResult = "-1";
                    break;
                case "10":
                    strResult = "1";
                    break;
                case "11":
                    strResult = "2";
                    break;
            }

            return strResult;
        }

        public static string To_Net_DetectLine(this string s)
        {
            string strResult = "A";

            if (AppHelper.ComprehensiveSetting.DetectLineC)
            {
                if (AppHelper.ComprehensiveSetting.Lines != null)
                {
                    DetectLineEntity entity = AppHelper.ComprehensiveSetting.Lines.FirstOrDefault(x => x.LocalLine.Equals(s));
                    if (entity != null)
                    {
                        strResult = entity.DetectLine;
                    }
                }
            }
            else
            {
                strResult = s;
            }

            return strResult;
        }

        public static string To_Net_KCLXDJ(this string s)
        {
            string strResult = "";
            switch (s)
            {
                case "特大型高三级":
                    strResult = "11";
                    break;
                case "特大型高二级":
                    strResult = "12";
                    break;
                case "特大型高一级":
                    strResult = "13";
                    break;
                case "特大型中级":
                    strResult = "14";
                    break;
                case "特大型普通级":
                    strResult = "15";
                    break;
                case "大型高三级":
                    strResult = "21";
                    break;
                case "大型高二级":
                    strResult = "22";
                    break;
                case "大型高一级":
                    strResult = "23";
                    break;
                case "大型中级":
                    strResult = "24";
                    break;
                case "大型普通级":
                    strResult = "25";
                    break;
                case "中型高二级":
                    strResult = "31";
                    break;
                case "中型高一级":
                    strResult = "32";
                    break;
                case "中型中级":
                    strResult = "33";
                    break;
                case "中型普通级":
                    strResult = "34";
                    break;
                case "小型高二级":
                    strResult = "41";
                    break;
                case "小型高一级":
                    strResult = "42";
                    break;
                case "小型中级":
                    strResult = "43";
                    break;
                case "小型普通级":
                    strResult = "44";
                    break;
                case "乘用车高二级":
                    strResult = "51";
                    break;
                case "乘用车高一级":
                    strResult = "52";
                    break;
                case "乘用车中级":
                    strResult = "53";
                    break;
                case "乘用车普通级":
                    strResult = "54";
                    break;
                case "其他":
                    strResult = "9";
                    break;
            }
            return strResult;
        }

    }
}
