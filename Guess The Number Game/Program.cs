using System;
namespace Guess_The_Number_Game
{
    class Program
    {
        public static int userGuess = 0;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberGuess = rnd.Next(1000);
            NumberGuess(numberGuess);
        }
        static int GetInput(string inputMessage)
        {
            int rawInput = 0;
            while (true)
            {
                Console.WriteLine($"{inputMessage}\n");
                try
                {
                    rawInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input, try again");
                }
            }
            return rawInput;
        }

        static void NumberGuess(int numberGuess)
        {
            for (int i = 0; i < 10; i++)
            {
                userGuess = GetInput("please input your guess");
                if (userGuess > numberGuess)
                {
                    Console.WriteLine("Too high");
                }
                else if (userGuess < numberGuess)
                {
                    Console.WriteLine("Too low");
                }
                else if (userGuess == numberGuess)
                {
                    Console.WriteLine("Your guess was correct");
                    break;
                }
            }
        }
    }
}
