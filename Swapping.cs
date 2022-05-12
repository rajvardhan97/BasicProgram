using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Swapping
    {
        public void swap()
        {
            Console.WriteLine("Enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            temp = num1;
            num1 = num2;
            num2 = temp;
            
            Console.WriteLine("After swapping");
            Console.WriteLine("First Number = {0}", num1);
            Console.WriteLine("Second Number = {0}", num2);
        }
    }
}
