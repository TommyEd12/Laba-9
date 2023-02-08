using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba_9;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangle expected = new Triangle(3, 4, 5);
            Triangle t = new Triangle(4, 5, 6);
            Assert.AreEqual(expected, t);
        }
    }
}
