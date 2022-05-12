using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Greatest
    {
        public void largest()
        {
            Console.WriteLine("Enter the first number ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number ");
            int third = Convert.ToInt32(Console.ReadLine());
            int max = first;

            if (first >= second && first >= third)
            {
                max = first;
            }
            else if (second >= first && second >= third)
            {
                max = second;
            }
            else if (third >= first && third >= second)
            {
                max = third;
            }
            Console.WriteLine("Greatest number is " + max);
        }
    }
}
