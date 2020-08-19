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
            // Console.WriteLine("\nWhat is your strName? ");
            var strName = Console.ReadLine();
            var date = DateTime.Now;
            // Console.WriteLine($"\nHello, {strName}, on {date:d} at {date:t}!");
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

            // Console.Write("Pick a number: ");
            // int numInput = Convert.ToInt32(Console.ReadLine());
            // Console.Write($"You chose the number {numInput} on {date:d} at {date:t}\n");

            // Number of pizza shops
            int pizzaShops = 4332;
            // Number of employees
            int totalEmployees = 86928;
            // Revenue
            decimal revenue = 390819.28m;
            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);

            // Your Age
            int userAge = 27;
            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;
            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
            // Time to Jupiter
            double journeyToJupiter = 6.142466;
            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;
            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;
            // Log calculations to console
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            // declare steps variable
            int steps = 0;
            // Two steps forward 
            steps += 2;
            // One step back 
            steps -= 1;
            // Print result to the console
            Console.WriteLine(steps);

            // Number of students
            int students = 18;
            // Number of students in a group
            int groupSize = 4;
            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;
            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            double numberOne = 6.5;
            double numberTwo = 4;
            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));
            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));
            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));

            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            // Second string variable
            string firstSpeech = "My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";
            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);

            // Declare the variables
            string beginning = "This is the beginning. ";
            string middle = "This is the middle. ";
            string end = "This is the end.";
            // Concatenate the string and the variables
            string story = beginning + middle + end;
            // Print the story to the console 
            Console.WriteLine(story);

            // Declare the variables
            string beginningInterpolated = "Once upon a time,";
            string middleInterpolated = "The kid climbed a tree";
            string endInterpolated = "Everyone lived happily ever after.";
            // Interpolate the string and the variables
            string storyInterpolated = $"{beginning} {middle} {end}";
            // Print the story to the console 
            Console.WriteLine(storyInterpolated);

            // Create password
            string password = "a92301j2add";
            // Get password length
            int passwordLength = password.Length;
            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");
            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

            // User Name
            string strName = "Farhad Hesam Abbasi";
            // Get first letter
            int charPosition = strName.IndexOf("F");
            char firstLetter = strName[charPosition];
            // Get last strName
            charPosition = strName.IndexOf("Abbasi");
            string lastName = strName.Substring(charPosition);
            // Print results
            Console.WriteLine($"{firstLetter}. {lastName}");

            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);
            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);
            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();
            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();
            // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}");
        }
    }
}
