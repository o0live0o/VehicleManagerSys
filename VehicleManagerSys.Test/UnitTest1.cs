using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleManagerSys.Dtos;

namespace VehicleManagerSys.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "-0s3";
            int iTimes = 1;
            int.TryParse(s, out iTimes);
        }

        [TestMethod]
        public void TestCombine()
        {
            StringBuilder sb = new StringBuilder(4);
            foreach (var item in typeof(VehicleInfo).GetProperties())
            {
                sb.Append($"[{item.Name}] varchar(50) COLLATE Chinese_PRC_CI_AS DEFAULT '' NOT NULL,");
            }
            string s = sb.ToString();
            int i = 4;
            List<int> list = new List<int>() { 1,2,3,4,5,6};
        }

        [TestMethod]
        public void FieldTest()
        {
            string[] field = "JCLSH,dlrq,jylb, DCRL,CNZZXH,DDJXH,WQCZY,WQLSH,CHZHQQK,ZZL,HCLLX,ZBZL,HCLXH,ZJ,PQGSL,FDJGS,EDGL,FDJPL,QDZW,QDZS,EDZS,CYS,QDXS,QDXSDH,CCRQ,JQFS,JQFSDH,GYFS,FDJXH,FDJH,BSXLX,BSXLXDH,FDJZZCS,RLLB,RLLBDH,FDJSCQY,CLZL,FDJSB,PPXH,CLPFJD,CLZZCS,OBDWZ,VIN".Split(',');
            string[] vals = "'XC0009202003111004',convert(varchar-getdate()-20),'新车生产下线','','','','','CN ZC G5 Z2 0224000052 000017','','42200','','42005','','1000','1','6','276','9.726','2','1/2','2000','3','后实时四驱','204','2020-03-11','增压中冷','高压共轨','D10.38-50','200100011998','MT','章丘市圣井唐王山路北潘王路西;杭州市萧山区萧山经济开发区红垦农场红泰六路699号','柴油','B','中国重型汽车集团有限公司','XZJ5428JQZ50K',' 中国重汽牌','徐工牌','国五','徐州工程机械集团有限公司','左','LXGCPA425LA002869'".Split(',');
            StringBuilder sb = new StringBuilder(4);
            StringBuilder sb1 = new StringBuilder(4);

            for (int i = 0; i < field.Length; i++)
            {
                sb.Append(field[i] +"\r\n");
            }

            for (int i = 0; i < vals.Length; i++)
            {
                sb1.Append(vals[i] + "\r\n");
            }
            File.WriteAllText("field.txt",sb.ToString()); 
            File.WriteAllText("val.txt", sb1.ToString()); ;
        }

    }
}
