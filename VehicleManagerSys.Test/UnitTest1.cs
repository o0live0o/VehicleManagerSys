using System;
using System.Collections.Generic;
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

        
    }
}
