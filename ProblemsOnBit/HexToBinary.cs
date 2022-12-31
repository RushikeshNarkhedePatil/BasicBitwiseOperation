using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnBit
{
    class HexToBinary
    {
        public HexToBinary()
        {
            int i = 0;

            char[] hexadecimal = new char[100];
            hexadecimal[0] = '1';
            hexadecimal[1] = 'a';
            hexadecimal[2] = 'b';
            hexadecimal[3] = 'c';

            while (hexadecimal[i]!='\0')
            {

                //Console.WriteLine(i);
                switch (hexadecimal[i])
                {

                    case '0':
                        Console.WriteLine("0000");
                        break;
                    case '1':
                        Console.WriteLine("0001");
                        break;
                    case '2':
                        Console.WriteLine("0010");
                        break;
                    case '3':
                        Console.WriteLine("0011");
                        break;
                    case '4':
                        Console.WriteLine("0100");
                        break;
                    case '5':
                        Console.WriteLine("0101");
                        break;
                    case '6':
                        Console.WriteLine(0110);
                        break;
                    case '7':
                        Console.WriteLine(0111);
                        break;
                    case '8':
                        Console.WriteLine(1000);
                        break;
                    case '9':
                        Console.WriteLine(1001);
                        break;
                    case 'a':
                    case 'A':
                        Console.WriteLine(1010);
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine(1011);
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine(1100);
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine(1101);
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine(1110);
                        break;
                    case 'f':
                    case 'F':
                        Console.WriteLine(1111);
                        break;
                   
                    default:
                        break;
                }
                i++;
            }
            
        }
    }
}
