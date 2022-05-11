using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PowerOf
    {
        public void power()
        {
            Console.WriteLine("Enter a number");
            int Num = Convert.ToInt32(Console.ReadLine());

            while(Num < 0 || Num >= 31)
            {
                Console.WriteLine("Enter a Valid Number");
                Num = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i <= Num; i++)
            {
                Console.WriteLine("2^" + i , (Math.Pow(2, i)));
            }
        }
    }
}
