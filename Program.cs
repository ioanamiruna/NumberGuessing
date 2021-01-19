using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("WINNER");
                    win = true;
                }
            }
            while (win == false);
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
