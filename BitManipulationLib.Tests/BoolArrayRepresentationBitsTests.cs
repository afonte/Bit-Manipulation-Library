using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitManipulationLib.Tests
{
    [TestClass]
    public class BoolArrayRepresentationBitsTests
    {
        [TestMethod]
        public void SetTest()
        {
            BoolArrayRepresentationBits bits = new BoolArrayRepresentationBits(20);
            bits.Set(0);
            bits.Set(1);
            bits.Set(11);
            bits.Set(20);
            Assert.AreEqual(bits.Array[0], 0xc0); // set bit 0th and 1st in the first byte
            Assert.AreEqual(bits.Array[1], 0x10); // set 4th in the second byte
            Assert.AreEqual(bits.Array[2], 0x08); // set 5th in the third byte
        }

        [TestMethod]
        public void IsSetTest()
        {
            BoolArrayRepresentationBits bits = new BoolArrayRepresentationBits(23);
            bits.Array = new byte[] { 0x00, 0x00, 0x81 };
            Assert.IsTrue(bits.IsSet(16));
            Assert.IsTrue(bits.IsSet(23));
        }
    }
}
