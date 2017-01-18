using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulationLib
{
    public class BitExtractor32
    {
        const int TOTAL_BITS = 32;

        /// <summary>
        /// Extracts one bit from the num
        /// </summary>
        /// <param name="num">Number to represent something with its bits</param>
        /// <param name="ind">index to extract</param>
        /// <param name="length">total interested bits from right to left</param>
        /// <returns>the number without the bit in index position</returns>
        public uint ExtractOneBit(uint num, int ind, int length)
        {
            uint maskL = uint.MaxValue;
            int shifts = length - ind;
            maskL <<= shifts;
            uint leftPart = maskL & num;
            leftPart >>= 1;

            uint maskR = uint.MaxValue;
            shifts = TOTAL_BITS - (length - ind - 1);
            if (shifts == TOTAL_BITS)
                maskR = 0;
            else
                maskR >>= shifts;

            uint rigthPart = maskR & num;
            return leftPart + rigthPart;
        }
    }
}
