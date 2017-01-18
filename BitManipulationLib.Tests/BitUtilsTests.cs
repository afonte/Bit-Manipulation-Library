using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitManipulationLib.Tests
{
    [TestClass]
    public class BitUtilsTests
    {
        [TestMethod]
        public void IsPowerOfTwoTest()
        {
            Assert.IsTrue(BitUtils.IsPowerOfTwo(2));
            Assert.IsTrue(BitUtils.IsPowerOfTwo(16));
            Assert.IsTrue(BitUtils.IsPowerOfTwo(1024));

            Assert.IsFalse(BitUtils.IsPowerOfTwo(15));
            Assert.IsFalse(BitUtils.IsPowerOfTwo(1000));
            Assert.IsFalse(BitUtils.IsPowerOfTwo(0));
        }

        [TestMethod]
        public void ToBinaryTest()
        {
            Assert.AreEqual("1000", BitUtils.ToBinary(8));
            Assert.AreEqual("1111111", BitUtils.ToBinary(127));
            Assert.AreEqual("100000001", BitUtils.ToBinary(257));
        }
    }
}
