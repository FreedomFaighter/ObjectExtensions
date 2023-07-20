using ObjectExtensions;
using System;

namespace IsNullUnitTests
{
    [TestClass]
    public class ExtensionUnitTests
    {
        [TestMethod]
        public void IsNullTrue()
        {
            object obj = null;
            Assert.IsTrue(obj.IsNull());
        }

        [TestMethod]
        public void IsNullFalse()
        {
            object obj = new object();
            Assert.IsFalse(obj.IsNull());
        }
    }
}