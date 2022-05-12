namespace BasicProgram
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a  number for a particular problem.\n " +
                "Press 1 to Flip coin and find percentage of heads and tails \n" +
                " Press 2 for checking Leap year \n Press 3 for finding power of 2 " +
                "\n Press 4 for Harmonic number \n Press 5 for prime factors \n Press 6 to find quotient and remainder \n" +
                " Press 7 to swap 2 numbers \n Press 8 to Check if a number is even or odd \n Press 9 to Check Whether an " +
                "Alphabet is Vowel or Consonant \n Press 10 to Find the Largest Among Three Numbers \n ");

            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
               case 1:                                      
                    FlipCoin flip = new FlipCoin();
                    flip.Flip();         
                    break;
               case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
               case 3:
                    PowerOf poweroftwo = new PowerOf();
                    poweroftwo.power();
                    break;
                case 4:
                    HarmonicNumber num = new HarmonicNumber();
                    num.Harmonic();
                    break;
                case 5:
                    PrimeFactors prime = new PrimeFactors();
                    prime.factor();
                    break;
                case 6:
                    QuotientRemainder answer = new QuotientRemainder();
                    answer.qnr();
                    break;
                case 7:
                    Swapping swapnum = new Swapping();
                    swapnum.swap();
                    break;
                case 8:
                    EvenOdd even = new EvenOdd();
                    even.evenoddprogram();
                    break;
                case 9:
                    Alphabet consonant = new Alphabet();
                    consonant.vowel();
                    break;
                case 10:
                    Greatest number = new Greatest();
                    number.largest();
                    break;
            }
        }
    }
}