using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        public void TestCombine()
        {
            int i = 4;
            List<int> list = new List<int>() { 1,2,3,4,5,6};
        }

        
    }
}
