using lackep;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lacekp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Feature.Method("pawel");

            Assert.Equals(result, true);
        }
    }
}
