using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Char myChar = 'O';

            for (var i = 0; i < 8; i++)
            {
                for (var x = 0; x < 8; x++)
                {
                    myChar = getChar(myChar);

                    Console.Write(myChar);
                }

                myChar = getChar(myChar);

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static Char getChar(Char theChar)
        {
            if (theChar == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
    }
}

