using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    class BitwiseOR
    {
        public BitwiseOR()
        {
            int No = -122;                   //00000001    11111110
            int No1 = 1;
            int No2 = 7;
            int No3 = 8;
            Console.WriteLine(No3|No2);     // output 15
            Console.WriteLine(No3&No2);    // Output 0
            No=~No;     // Bitwise Not Replace Value // No= 121
            Console.WriteLine(~No);    // Output -122 Replace value and add 1
             Console.WriteLine(No1^No2);    // Output 6
            
        }
    }
}
