using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitManipulationLib.Tests
{
    [TestClass]
    public class BitExtractor32Tests
    {
        [TestMethod]
        public void ExtracOneBitTest_BitSetTo0()
        {
            // Remove at 4th bit from 52 => 26
            // num = 52 -> 110100  (6 bit length) 
            // res = 26 -> 11010  (5 bit length) 
            uint num = 52;
            BitExtractor32 bit32Extractor = new BitExtractor32();
            var reducedNum = bit32Extractor.ExtractOneBit(num, 4, 6);
            Assert.AreEqual(26U, reducedNum);
        }

        [TestMethod]
        public void ExtracOneBitTest_BitSetTo1()
        {
            // Remove at 3rd bit from 52 => 24 
            // num = 52 -> 110100  (6 bit length) 
            // res = 24 -> 11000  (5 bit length) 
            uint num = 52;
            BitExtractor32 bit32Extractor = new BitExtractor32();
            var reducedNum = bit32Extractor.ExtractOneBit(num, 3, 6);
            Assert.AreEqual(24U, reducedNum);
        }

        [TestMethod]
        public void ExtracOneBitTest_NotAllBitsOfInterest()
        {
            // Remove at 0th bit from 436 => 212 (extraction in the last 6 bits 
            // num = 436 -> 110 110100  (6 bit length of interest) 
            // res = 212 -> 110 10100  (5 bit length of interest) 
            uint num = 436;
            BitExtractor32 bit32Extractor = new BitExtractor32();
            var reducedNum = bit32Extractor.ExtractOneBit(num, 0, 6);
            Assert.AreEqual(212U, reducedNum);
        }
    }
}
