using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // comments are written like this
            /* or like
            this */
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
