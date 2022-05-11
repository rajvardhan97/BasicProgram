using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PrimeFactors
    {
        public void factor()
        {
            Console.WriteLine("Enter a number to find its prime factors ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int flag = 0;

           Console.Write("Prime factors of {0} = ", num);
            for (int i = 2; i < num; i++)  
            {
                if (num % i == 0)      
                {
                    count = 0;
                    for (int j = 1; j <= i; j++)   
                    {
                        if (i % j == 0)     
                            count++;            
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }

            if (flag == 0)
                Console.Write("There is no Prime factor for {0} ", num);
        }
    }
}
