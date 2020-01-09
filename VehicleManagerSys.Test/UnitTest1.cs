using System;
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
    }
}
