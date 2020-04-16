using EASkins.Controls;
using Live0xUtils.RegexUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using VehicleManagerSys.Entity.IVS;

namespace VehicleManagerSys.Manual
{
    public partial class SearchCarForm : MaterialForm
    {
        public static List<Tuple<string,string,string>> DefineTpye = new List<Tuple<string, string, string>>();

        public static int Code = 0;

        private static VEHICLE_DISPATCH m_diapatch = null;

        public SearchCarForm()
        {
            InitializeComponent();
            InitDefine();
            Clear();
        }

        private void Search()
        {
            string hphm = combQueryAera.Text + txtQueryPlateNo.Text.Trim();
            string vin = txtQueryVIN.Text.Trim();
            string hpzl = GetCodeByName(combQueryPlateType.Text, "HPZL");
            string result = "";

            Clear();

            LoadingForm frmLoading = new LoadingForm("正在查询...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "正在查询...");
                    result = WebSend.QueryCar(hphm, hpzl, "张成", vin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询时出现错误：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();


            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("查询结果为空");
                return;
            }
         
            string code = RegexXML.MatchField(result, "code", false);
            if ("1".Equals(code))
            {
                Code = 1;
                labTips.Text = "查询成功！";
                X18J52 x18J52 = RegexXML.XmlToModelByName<X18J52>(result);
                m_diapatch = new VEHICLE_DISPATCH() { HPHM =x18J52.hphm,HPZLDH = x18J52.hpzl,AJLSH = x18J52.jylsh,AJJCCS = x18J52.jycs,VIN = x18J52.clsbdh };
                labLwlsh.Text = m_diapatch.AJLSH;
            }
            else if (string.IsNullOrEmpty(code))
            {
                Code = 0;
                MessageBox.Show("查询信息为空" + result);
            }
            else
            {
                Code = 0;
                labTips.Text = $"查询失败！{RegexXML.MatchField(result, "message", false)}";
                MessageBox.Show(RegexXML.MatchField(result, "message", false));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Clear()
        {
            labTips.Text = "";
            labLwlsh.Text = "";
            Code = 0;
            m_diapatch = null;
        }

        private void InitDefine()
        {
            //号牌种类
            DefineTpye.Add(new Tuple<string, string, string>("小型汽车", "02", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型汽车", "01", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("警用汽车", "23", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("使馆汽车", "03", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("领馆汽车", "04", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("境外汽车", "05", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("外籍汽车", "06", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("教练汽车", "16", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("试验汽车", "18", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("农用运输车", "13", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("拖拉机", "14", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("挂车", "15", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("临时入境汽车", "20", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("临时行驶车", "22", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("两、三轮摩托车", "07", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻便摩托车", "08", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("使馆摩托车", "09", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("领馆摩托车", "10", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("境外摩托车", "11", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("外籍摩托车", "12", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("教练摩托车", "17", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("试验摩托车", "19", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("临时入境摩托车", "21", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("警用摩托", "24", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型新能源汽车", "51", "HPZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型新能源汽车", "52", "HPZL"));

            //车辆种类
            DefineTpye.Add(new Tuple<string, string, string>("重型普通半挂车", "B11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型厢式半挂车", "B12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式半挂车", "B13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板半挂车", "B14", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装箱半挂车", "B15", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型自卸半挂车", "B16", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型特殊结构半挂车", "B17", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式半挂车", "B18", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型旅居半挂车", "B19", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型专项作业半挂车", "B1A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型低平板半挂车", "B1B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型车辆运输半挂车", "B1C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式自卸半挂车", "B1D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板自卸半挂车", "B1E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装箱自卸半挂车", "B1F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型特殊结构自卸半挂车", "B1G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式自卸半挂车", "B1H", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型专项作业自卸半挂车", "B1J", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型低平板自卸半挂车", "B1K", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型中置轴旅居挂车", "B1U", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型中置轴车辆运输车", "B1V", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型中置轴普通挂车", "B1W", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型普通半挂车", "B21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型厢式半挂车", "B22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式半挂车", "B23", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板半挂车", "B24", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装箱半挂车", "B25", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型自卸半挂车", "B26", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型特殊结构半挂车", "B27", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式半挂车", "B28", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型旅居半挂车", "B29", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专项作业半挂车", "B2A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型低平板半挂车", "B2B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型车辆运输半挂车", "B2C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式自卸半挂车", "B2D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板自卸半挂车", "B2E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装箱自卸半挂车", "B2F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型特殊结构自卸半挂车", "B2G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式自卸半挂车", "B2H", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专项作业自卸半挂车", "B2J", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型低平板自卸半挂车", "B2K", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型中置轴旅居挂车", "B2U", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型中置轴车辆运输车", "B2V", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型中置轴普通挂车", "B2W", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型普通半挂车", "B31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型厢式半挂车", "B32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式半挂车", "B33", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板半挂车", "B34", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型自卸半挂车", "B35", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式半挂车", "B36", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型旅居半挂车", "B37", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型专项作业半挂车", "B38", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型低平板半挂车", "B39", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型车辆运输半挂车", "B3C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式自卸半挂车", "B3D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板自卸半挂车", "B3E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型集装箱自卸半挂车", "B3F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型特殊结构自卸半挂车", "B3G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式自卸半挂车", "B3H", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型专项作业自卸半挂车", "B3J", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型低平板自卸半挂车", "B3K", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型中置轴旅居挂车", "B3U", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型中置轴车辆运输车", "B3V", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型中置轴普通挂车", "B3W", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("无轨电车", "D11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("有轨电车", "D12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型普通全挂车", "G11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型厢式全挂车", "G12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式全挂车", "G13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板全挂车", "G14", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装箱全挂车", "G15", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型自卸全挂车", "G16", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式全挂车", "G17", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型旅居全挂车", "G18", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型专项作业全挂车", "G19", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型厢式自卸全挂车", "G1A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式自卸全挂车", "G1B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板自卸全挂车", "G1C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装箱自卸全挂车", "G1D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式自卸全挂车", "G1E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型专项作业自卸全挂车", "G1F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型普通全挂车", "G21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型厢式全挂车", "G22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式全挂车", "G23", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板全挂车", "G24", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装箱全挂车", "G25", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型自卸全挂车", "G26", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式全挂车", "G27", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型旅居全挂车", "G28", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专项作业全挂车", "G29", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型厢式自卸全挂车", "G2A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式自卸全挂车", "G2B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板自卸全挂车", "G2C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装箱自卸全挂车", "G2D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式自卸全挂车", "G2E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专项作业自卸全挂车", "G2F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型普通全挂车", "G31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型厢式全挂车", "G32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式全挂车", "G33", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板全挂车", "G34", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型自卸全挂车", "G35", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式全挂车", "G36", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型旅居全挂车", "G37", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型专项作业全挂车", "G38", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型厢式自卸全挂车", "G3A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式自卸全挂车", "G3B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板自卸全挂车", "G3C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型集装箱自卸全挂车", "G3D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式自卸全挂车", "G3E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型专项作业自卸全挂车", "G3F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型普通货车", "H11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型厢式货车", "H12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型封闭货车", "H13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式货车", "H14", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板货车", "H15", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装厢车", "H16", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型自卸货车", "H17", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型特殊结构货车", "H18", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式货车", "H19", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型车辆运输车", "H1A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型厢式自卸货车", "H1B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型罐式自卸货车", "H1C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型平板自卸货车", "H1D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型集装厢自卸货车", "H1E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型特殊结构自卸货车", "H1F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型仓栅式自卸货车", "H1G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型普通货车", "H21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型厢式货车", "H22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型封闭货车", "H23", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式货车", "H24", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板货车", "H25", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装厢车", "H26", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型自卸货车", "H27", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型特殊结构货车", "H28", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式货车", "H29", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型车辆运输车", "H2A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型厢式自卸货车", "H2B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型罐式自卸货车", "H2C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型平板自卸货车", "H2D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型集装厢自卸货车", "H2E", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型特殊结构自卸货车", "H2F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型仓栅式自卸货车", "H2G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型普通货车", "H31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型厢式货车", "H32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型封闭货车", "H33", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式货车", "H34", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板货车", "H35", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型自卸货车", "H37", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型特殊结构货车", "H38", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式货车", "H39", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型车辆运输车", "H3A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型厢式自卸货车", "H3B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型罐式自卸货车", "H3C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型平板自卸货车", "H3D", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型特殊结构自卸货车", "H3F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型仓栅式自卸货车", "H3G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型普通货车", "H41", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型厢式货车", "H42", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型封闭货车", "H43", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型罐式货车", "H44", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型自卸货车", "H45", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型特殊结构货车", "H46", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型仓栅式货车", "H47", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型车辆运输车", "H4A", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型厢式自卸货车", "H4B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型罐式自卸货车", "H4C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型特殊结构自卸货车", "H4F", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型仓栅式自卸货车", "H4G", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("普通低速货车", "H51", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("厢式低速货车", "H52", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("罐式低速货车", "H53", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("自卸低速货车", "H54", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("仓栅式低速货车", "H55", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("厢式自卸低速货车", "H5B", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("罐式自卸低速货车", "H5C", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轮式装载机械", "J11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轮式挖掘机械", "J12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轮式平地机械", "J13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型普通客车", "K11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型双层客车", "K12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型卧铺客车", "K13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型铰接客车", "K14", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型越野客车", "K15", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型轿车", "K16", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型专用客车", "K17", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型专用校车", "K18", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型普通客车", "K21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型双层客车", "K22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型卧铺客车", "K23", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型铰接客车", "K24", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型越野客车", "K25", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型轿车", "K26", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专用客车", "K27", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专用校车", "K28", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型普通客车", "K31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型越野客车", "K32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型轿车", "K33", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型专用客车", "K34", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型专用校车", "K38", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型面包车", "K39", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型半挂牵引车", "Q31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型半挂牵引车", "Q11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型全挂牵引车", "Q12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型半挂牵引车", "Q21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型全挂牵引车", "Q22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型全挂牵引车", "Q32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("普通正三轮摩托车", "M11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻便正三轮摩托车", "M12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("正三轮载客摩托车", "M13", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("正三轮载货摩托车", "M14", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("侧三轮摩托车", "M15", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("普通二轮摩托车", "M21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻便二轮摩托车", "M22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型轮式拖拉机", "T11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型轮式拖拉机", "T21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("手扶拖拉机", "T22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("手扶变形运输机", "T23", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型拖拉机", "T20", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("多功能拖拉机", "T19", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型专项作业车", "Z71", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型专项作业车", "Z41", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型专项作业车", "Z31", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型专项作业车", "Z21", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型专项作业车", "Z11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型专项作业车", "Z51", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型普通客车", "K41", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型越野客车", "K42", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型轿车", "K43", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型面包车", "K49", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("三轮汽车", "N11", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("大型载货专项作业车", "Z12", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("中型载货专项作业车", "Z22", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("小型载货专项作业车", "Z32", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("微型载货专项作业车", "Z42", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("重型载货专项作业车", "Z52", "CLZL"));
            DefineTpye.Add(new Tuple<string, string, string>("轻型载货专项作业车", "Z72", "CLZL"));
        }

        public static string GetCodeByName(string name, string type)
        {
           var tt=  DefineTpye.Where(p => p.Item3.Equals(type) && p.Item1.Equals(name));
            Tuple<string, string, string> entity = DefineTpye.Where(p => p.Item3.Equals(type) && p.Item1.Equals(name)).FirstOrDefault();
            if (entity != null)
            {
                return entity.Item2;
            }
            return name;
        }

        public static string GetNameByCode(string code, string type)
        {
            Tuple<string, string, string> entity = DefineTpye.Where(p => p.Item3.Equals(type) && p.Item2.Equals(code)).FirstOrDefault();
            if (entity != null)
            {
                return entity.Item3;
            }
            return code;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Code != 1 && string.IsNullOrEmpty(labLwlsh.Text.Trim()))
            {
                MessageBox.Show("查询信息失败，不能开始检测！");
                return;
            }
            else
            {
                ManualTestForm form = new ManualTestForm(m_diapatch);
                form.ShowDialog(this);
                Clear();
            }
            
        }

        private void btnRoadTest_Click(object sender, EventArgs e)
        {
            if (Code != 1 && string.IsNullOrEmpty(labLwlsh.Text.Trim()))
            {
                MessageBox.Show("查询信息失败，不能开始检测！");
                return;
            }
            else
            {
                RoadTestForm form = new RoadTestForm(m_diapatch);
                form.ShowDialog(this);
                Clear();
            }
        }
    }
}
