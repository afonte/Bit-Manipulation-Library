using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulationLib
{
    public class BitUtils
    {

        public static bool IsPowerOfTwo(uint x)
        {
            return x > 0 && (x & (x - 1)) == 0;
        }

        public static string ToBinary(uint num)
        {
            string bin = "";
            uint coc = num;
            while (coc > 0)
            {
                uint rem = coc % 2;
                bin = rem + bin;
                coc = coc / 2;
            }
            return bin;
        }
    }
}
