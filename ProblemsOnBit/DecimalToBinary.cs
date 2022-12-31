using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    internal class DecimalToBinary
    {
        public DecimalToBinary()
        {
            int[] arr = new int[32];
            int i = 0;
            int No = 5;
            int Digit = 0;
            for (i = 0; No > 0; i++)
            {
                arr[i] = No % 2;
                No = No / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
