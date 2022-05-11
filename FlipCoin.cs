using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class FlipCoin
    {
        public void Flip()
        {
            int Head=0, Tail=0;
            float HeadPerc, TailPerc;
            Console.WriteLine("Enter the number of times you want to flip coin");
            int Flips = Convert.ToInt32(Console.ReadLine());

            while(Flips <= 0)
            {
                Console.WriteLine("Invalid Input, Enter a number greater than 0");
                Flips=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Flips; i++)
            {
                Random random = new Random();
                int num = random.Next(0, 2);
                if (num < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
            }
                HeadPerc = Head * 100 / Flips;
                TailPerc = Tail * 100 / Flips;

            Console.WriteLine("Heads percentage is " + HeadPerc + "%");
            Console.WriteLine("Tails percentage is " + TailPerc + "%");
        }
    }
}