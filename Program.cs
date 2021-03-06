﻿using System;

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
            int numOne = 12932;
            int numTwo = -2828472;
            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numOne));
            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numTwo)));
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
            string storyInterpolated = $"{beginningInterpolated} {middleInterpolated} {endInterpolated}";
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
            string fullName = "Farhad Hesam Abbasi";
            // Get first letter
            int charPosition = fullName.IndexOf("F");
            char firstLetter = fullName[charPosition];
            // Get last strName
            charPosition = fullName.IndexOf("Abbasi");
            string lastName = fullName.Substring(charPosition);
            // Print results
            Console.WriteLine($"{firstLetter}. {lastName}");

            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
            // Get camera directions
            int position = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(position, length);
            // Get scene description
            position = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(position);
            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();
            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();
            // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}");

            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            double tripDuration = distance / rate;
            bool answer = tripDuration <= timeToDinner;
            Console.WriteLine(answer);

            bool beach = true;
            bool hiking = false;
            bool city = true;
            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;
            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision);

            int socks = 6;
            if (socks <= 3)
            {
              Console.WriteLine("Time to do laundry!");
            }

            int people = 12;
            string weather = "bad";
            if (people <= 10 && weather == "nice")
            {
              Console.WriteLine("SaladMart");
            }
            else
            {
              Console.WriteLine("Soup N Sandwich");
            }

            int guests = 0;
            if(guests >= 4)
            {
              Console.WriteLine("Catan");
            }
            else if(guests >= 1)
            {
              Console.WriteLine("Innovation");
            }
            else 
            {
              Console.WriteLine("Solitaire");
            }

            Console.WriteLine("Type your favorite genre");
            string genre = Console.ReadLine();
            switch(genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Oddysey");
                    break;    
                default:
                    Console.WriteLine("No Movie Found");
                    break;      
            }

            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
            Console.WriteLine(message);

            Math.Min(3, 5);
            string msg = "Yabba dabba doo!";
            Console.WriteLine(msg);
            msg.Substring(0, 1);

            string designer = "Anders Hejlsberg";
            int indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace);
            Console.WriteLine(secondName);

            VisitPlanets();
            VisitPlanets(3);
            VisitPlanets(7);
            VisitPlanets(9);
            VisitPlanets(numberOfPlanets: 2);
            VisitPlanets(numberOfPlanets: 2, name: "Dayna");

            NamePets("Laika", "Albert");
            NamePets("Mango", "Puddy", "Bucket");
            NamePets();

            Console.WriteLine(DecoratePlanet("Jupiter"));

            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            int nameAsInt;
            bool outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);
            bool outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);

            bool marker;
            Console.WriteLine(Whisper("HELLO AGAIN", out marker));

            

        }

        //OUTSIDE OF MAIN METHOD STARTS HERE
        // static void VisitPlanets()
        // {
        //   Console.WriteLine("You visited many new planets…");
        // }

        static void VisitPlanets(int numberOfPlanets = 5)
        {
          Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }

        static void VisitPlanets(
          string adjective = "brave",
          string name = "Cosmonaut", 
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
          Console.WriteLine($"Welcome back, {adjective} {name}.");
          Console.WriteLine($"You visited {numberOfPlanets} new planets...");
          Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }

        static void NamePets(string name1, string name2)
        {
          Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
        }

        static void NamePets(string name1, string name2, string name3)
        {
          Console.WriteLine($"Your pets {name1}, {name2}, and {name3} will be joining your voyage across space!");
        }

        static void NamePets()
        {
          Console.WriteLine("Aw, you have no spacefaring pets");
        }

        static string DecoratePlanet(string name)
        {
          return $"*.*.* Welcome to {name} *.*.*";
        }

        static string Whisper(string phrase, out bool wasWhispered)
        {
          wasWhispered = true;
          return phrase.ToLower();
        }
    }
}
