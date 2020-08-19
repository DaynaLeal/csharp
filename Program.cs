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
            // Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            // Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            // Console.Write("\nPress any key to exit...");
            // Console.ReadKey(true);

            // Create Variables
            string dogName = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console
            Console.WriteLine(dogName);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            Console.Write("Pick a number: ");
            int numInput = Convert.ToInt32(Console.ReadLine());
            Console.Write($"You chose the number {numInput} on {date:d} at {date:t}\n");
        }
    }
}
