using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThisIsTest
{
    [TestClass]
    public class TestOnePlusOne
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lib = new ThisIsALibrary.Math();
            var result = lib.OnePlusOne();
            Assert.AreEqual(result,2);
        }
    }
}
