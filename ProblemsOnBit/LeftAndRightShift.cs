using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    class LeftAndRightShift
    {
        public LeftAndRightShift()
        {
            int No = 2;
            int No1 = 5;
            int No2=6;
            int val=10;
            int value = 15;

            Console.WriteLine(No << 1);           // 0010   -->   0100   = 4      // Left Shift by 1
            Console.WriteLine(No >> 1);           // 0010   -->   0001   = 1      // Right Shift by 1
            Console.WriteLine(No << 2);           // 0010   -->   1000   = 8      // Left Shift by 1
            Console.WriteLine(No >> 2);           // 0010   -->   0000   = 0      // Right Shift by 1 
            Console.WriteLine(No << 4);           // 00000010 -->   00100000   = 32  // Left Shift by 1
            Console.WriteLine(No >> 4);           // 0010    -->    0000   = 0      // Right Shift by 1 
            // Left Shipt Example .
            Console.WriteLine(val>>3);            // 1
            // Explain Left shift Operation.
            // 0000 0000 0000 0000 0000 0000 0000 1010      // val Binary Representation
            // After Right shift by 3
            // 0000 0000 0000 0000 0000 0000 0000 0001       // last 3 digit will be dropt and added in left hand side.

            // Right shift Example.
            Console.WriteLine(val<<3);              // 80
                                                    //Explain Right Shift Operation.
                                                    // 0000 0000 0000 0000 0000 0000 0000 1010      // val Binary Representation
                                                    // after Right shift by 3.
                                                    // 0000 0000 0000 0000 0000 0000 0101 0000      // every digit shipt by 3 and left hand side 3 digit will be dropt and
                                                    // Added last of Right hand side. LSB
            byte no=5;
            Byte val1 = (Byte)(~no);
            Console.WriteLine(no);
            UInt32 num = 4294967295;     // Max number will be store in usigned variable   
            int num1 = 2147483647;      // Max number /2 number will store in signed variable
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(10>>3);
            string binaryValue = Convert.ToString(value, 2).PadLeft(32, '0');    //conversion of int32 value to 32bit binary
        }
    }
}
