using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    class BinaryToDecimal
    {
        public BinaryToDecimal()
        {
            int[] arr = new int[32];
            int No = 1111;
            int Base = 1;
            int DecimalNo = 0;
            int BinaryNo;
            int Digit;
            BinaryNo = No;
            while (No>0)
            {
                Digit = No % 10;
                DecimalNo = DecimalNo + Digit * Base;
                No = No / 10;
                Base = Base * 2;
            }
            Console.WriteLine("Decimal Number is : "+DecimalNo);
            Console.WriteLine("Binary Number is  : "+BinaryNo);
        }
    }
}
