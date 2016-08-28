using System;

namespace FizzBuzz
{
    class Counter
    {
        static void Main(string[] args)
        {
            string fb = "";

            Console.WriteLine("FizzBuzz numbers:");

            for (int i = 1; i <= 100; i++)
            {
                fb = (i % 3 == 0) ? "Fizz" : "";
                fb += (i % 5 == 0) ? "Buzz" : "";
                fb += ((i % 3 > 0) && (i % 5 > 0)) ? i.ToString() : "";
                Console.WriteLine(fb);
            }

            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
