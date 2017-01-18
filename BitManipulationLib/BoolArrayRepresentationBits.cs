using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulationLib
{
    public class BoolArrayRepresentationBits
    {
        byte[] shiftLefts = new byte[] { 1, 1 << 1, 1 << 2, 1 << 3, 1 << 4, 1 << 5, 1 << 6, 1 << 7 };

        public byte[] Array { get; set; }

        public BoolArrayRepresentationBits(int maxValue)
        {
            Array = new byte[maxValue / 8 + 1];
        }

        public void Set(int bit)
        {
            int index = bit / 8;
            int rem = bit % 8;
            int shiftsL = 7 - rem;
            Array[index] |= shiftLefts[shiftsL];
        }

        public bool IsSet(int bit)
        {
            int index = bit / 8;
            int rem = bit % 8;
            int shiftsL = 7 - rem;
            int pot2 = shiftLefts[shiftsL];
            return (Array[index] & pot2) == pot2;
        }
    }
}
