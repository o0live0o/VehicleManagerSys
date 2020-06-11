using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Common.Attributes;

namespace VehicleManagerSys.Dtos.SafetyTest
{
    public class Response_18C49
    {
        public Response_18C49()
        {
            xh = "";
            hpzl = "";
            hphm = "";
            clpp1 = "";
            clxh = "";
            clpp2 = "";
            gcjk = "";
            zzg = "";
            zzcmc = "";
            clsbdh = "";
            fdjh = "";
            cllx = "";
            csys = "";
            syxz = "";
            sfzmhm = "";
            sfzmmc = "";
            syr = "";
            ccdjrq = "";
            djrq = "";
            yxqz = "";
            qzbfqz = "";
            fzjg = "";
            glbm = "";
            bxzzrq = "";
            zt = "";
            dybj = "";
            fdjxh = "";
            rlzl = "";
            pl = "";
            gl = "";
            zxxs = "";
            cwkc = "";
            cwkk = "";
            cwkg = "";
            hxnbcd = "";
            hxnbkd = "";
            hxnbgd = "";
            gbthps = "";
            zs = "";
            zj = "";
            qlj = "";
            hlj = "";
            ltgg = "";
            lts = "";
            zzl = "";
            zbzl = "";
            hdzzl = "";
            hdzk = "";
            zqyzl = "";
            qpzk = "";
            hpzk = "";
            hbdbqk = "";
            ccrq = "";
            clyt = "";
            ytsx = "";
            xszbh = "";
            jyhgbzbh = "";
            xzqh = "";
            zsxzqh = "";
            zzxzqh = "";
            sgcssbwqk = "";
            sfmj = "";
            bmjyy = "";
            sfxny = "";
            xnyzl = "";
            bz = "";
        }
        /// <summary>
        /// 获取或设置机动车序号
        /// </summary>
        [Mapper("VehicleSerialNo")]
        public string xh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌种类
        /// </summary>
        [Mapper("PlateType")]
        public string hpzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置号牌号码
        /// </summary>
        [Mapper("PlateNo")]
        public string hphm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置中文品牌
        /// </summary>
        [Mapper("Brand")]
        public string clpp1
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆型号
        /// </summary>
        [Mapper("Model")]
        public string clxh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置英文品牌
        /// </summary>
        public string clpp2
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置国产/进口
        /// </summary>
        [Mapper("Country")]
        public string gcjk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制造国
        /// </summary>
        public string zzg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置制造厂名称
        /// </summary>
        [Mapper("Manufacturer")]
        public string zzcmc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆识别代号
        /// </summary>
        [Mapper("VIN")]
        public string clsbdh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机号
        /// </summary>
        [Mapper("EngineNumber")]
        public string fdjh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆类型
        /// </summary>
        [Mapper("VehicleType")]
        public string cllx
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车身颜色
        /// </summary>
        public string csys
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置使用性质
        /// </summary>
        [Mapper("UseType")]
        public string syxz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置身份证明号码
        /// </summary>
        public string sfzmhm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置身份证明名称
        /// </summary>
        public string sfzmmc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置机动车所有人
        /// </summary>
        [Mapper("Owner")]
        public string syr
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置初次登记日期
        /// </summary>
        [Mapper("RegisterDate")]
        public string ccdjrq
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置最近定检日期
        /// </summary>
        public string djrq
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验有效期止
        /// </summary>
        public string yxqz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置强制报废期止
        /// </summary>
        public string qzbfqz
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发证机关
        /// </summary>
        public string fzjg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置管理部门
        /// </summary>
        public string glbm
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置保险终止日期
        /// </summary>
        public string bxzzrq
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置机动车状态
        /// </summary>
        [Mapper("VehicleStatus")]
        public string zt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置抵押标记0-未抵押，1-已抵押
        /// </summary>
        public string dybj
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置发动机型号
        /// </summary>
        [Mapper("EngineModel")]
        public string fdjxh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置燃料种类
        /// </summary>
        [Mapper("FuelType")]
        public string rlzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置排量
        /// </summary>
        [Mapper("Displacement")]
        public string pl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置功率
        /// </summary>
        [Mapper("Power")]
        public string gl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置转向形式
        /// </summary>
        public string zxxs
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车外廓长
        /// </summary>
        [Mapper("Length")]
        public string cwkc
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车外廓宽
        /// </summary>
        [Mapper("Width")]
        public string cwkk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车外廓高
        /// </summary>
        [Mapper("Height")]
        public string cwkg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置货箱内部长度
        /// </summary>
        public string hxnbcd
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置货箱内部宽度
        /// </summary>
        public string hxnbkd
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置货箱内部高度
        /// </summary>
        public string hxnbgd
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置钢板弹簧片数
        /// </summary>
        public string gbthps
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轴数
        /// </summary>
        [Mapper("AxleAmount")]
        public string zs
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轴距
        /// </summary>
        public string zj
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置前轮距
        /// </summary>
        public string qlj
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置后轮距
        /// </summary>
        public string hlj
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轮胎规格
        /// </summary>
        public string ltgg
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置轮胎数
        /// </summary>
        public string lts
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置总质量
        /// </summary>
        [Mapper("TotalWeight")]
        public string zzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置整备质量
        /// </summary>
        [Mapper("KerbWeight")]
        public string zbzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核定载质量
        /// </summary>
        [Mapper("ApproveWeight")]
        public string hdzzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置核定载客
        /// </summary>
        [Mapper("PassengerAmount")]
        public string hdzk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置准牵引总质量
        /// </summary>
        public string zqyzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驾驶室前排载客人数
        /// </summary>
        public string qpzk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置驾驶室后排载客人数
        /// </summary>
        public string hpzk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置环保达标情况
        /// </summary>
        public string hbdbqk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置出厂日期
        /// </summary>
        [Mapper("ManufactureDate")]
        public string ccrq
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置车辆用途
        /// </summary>
        [Mapper("VehicleUseType")]
        public string clyt
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置用途属性
        /// </summary>
        public string ytsx
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置行驶证证芯编号
        /// </summary>
        public string xszbh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置检验合格标志
        /// </summary>
        public string jyhgbzbh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置管理辖区
        /// </summary>
        [Mapper("Jurisdiction")]
        public string xzqh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置住所地址行政区划
        /// </summary>
        public string zsxzqh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置联系地址行政区划
        /// </summary>
        public string zzxzqh
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置事故车损伤部位情况
        /// </summary>
        public string sgcssbwqk
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否免检
        /// </summary>
        public string sfmj
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置不免检原因
        /// </summary>
        public string bmjyy
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置是否新能源汽车
        /// </summary>
        public string sfxny
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置新能源汽车种类
        /// </summary>
        public string xnyzl
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string bz
        {
            get;
            set;
        }

    }

}
