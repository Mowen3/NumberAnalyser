using System;

namespace NumberAnalyser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi there and welcome to the number analyser!");
            Console.WriteLine("Please enter your name below so I can refer to you properly throughout the session.");
            var userName = (Console.ReadLine());

            while (true)
            {
                Console.WriteLine($"Okay {userName}, now please enter a number between 1 and 100");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0 && number < 60)
                {
                    Console.WriteLine($"So {userName}, your number is odd and less than 60");
                }

                else if (number % 2 == 0 && number >= 2 && number <= 24)
                {
                    Console.WriteLine($"So {userName}, your number is even and less than 25 exclusive");
                }

                else if (number % 2 == 0 && number >= 24 && number <= 60)
                {
                    Console.WriteLine($"So {userName}, your number is even and between 25 and 60 inclusive");
                }

                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"So {userName}, your number is Even and greater than 60");
                }

                else if (number % 2 != 0 && number > 60)
                {
                    Console.WriteLine($"So {userName}, your number is odd and greater than 60");
                }

                else break;
            
            }

        }
    }
}
