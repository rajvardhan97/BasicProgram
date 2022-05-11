using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            float value = 0;
            Console.WriteLine("Enter a number to find Nth harmonic number ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(float i = 1; i <= n; i++)
            {
              value += 1 / i;
            }

            Console.WriteLine("Nth Harmonic number is " + value);
        }
    }
}
