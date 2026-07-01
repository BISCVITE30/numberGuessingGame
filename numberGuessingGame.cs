using System;
namespace Test
{
    class Program
    {
        static int Greeting()
        {

            Console.WriteLine("Welcome to the Number Guessing Game!!!");
            Console.Write("Please, select your number from 1 to 100: ");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            return guessNum;
        }

        static int GoRandom()
        {
            Random rdNum = new Random();
            int rightNum = rdNum.Next(1, 101);
            return rightNum;
        }
        
        static void LetsGoGambling(int guessNum, int rightNum)
        {
            while (guessNum != rightNum)
            {
                if (guessNum < rightNum)
                {
                    Console.WriteLine("Try a higher number.");

                }
                else
                {
                    Console.WriteLine("Try a smaller number");
                }

                Console.Write("select another number: ");
                guessNum = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine($"Nice! That’s the right number. This is {guessNum}");
        }
        static void Main(string[] args)
        {
            int guessNum = Greeting();
            int rightNum = GoRandom();
            LetsGoGambling(guessNum, rightNum);
        }
    }
}