using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    class CheckBit
    {
        public CheckBit()
        {
            int no = 5;
            int [] arr= new int[32];
            int i;
            for(i=0;no>0;i++)
            {
                arr[i] = no % 2;
                if (arr[i] == 1)
                {
                    Console.WriteLine("On bit index is : " + i);  
                }
                no =no/2;
            }
            Console.WriteLine("Binary no is : ");
            for (i=i-1;i>=0;i--)
            {
                Console.Write(arr[i]);
            }

        }
    }
}
