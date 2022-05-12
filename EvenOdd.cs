using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class EvenOdd
    {
        public void evenoddprogram()
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine(number + " is an odd number");
            }
        }
    }
}
