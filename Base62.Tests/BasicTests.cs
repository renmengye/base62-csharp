using System;
using Base62;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Base62.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] x = { 128, 128, 128, 128, 128, 128 };
            string s = x.ToBase62();
            byte[] x2 = s.FromBase62();
            Assert.IsTrue(x.SequenceEqual(x2));
        }
    }
}
