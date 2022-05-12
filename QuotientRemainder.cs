using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class QuotientRemainder
    {
        public void qnr()
        {
            int quotient = 0, remainder = 0;

            Console.Write("Enter Dividend first : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;

            remainder = dividend % divisor;

            Console.WriteLine("Quotient is: " + quotient);
            Console.WriteLine("Remainder is: " + remainder);

        }
    }
}
