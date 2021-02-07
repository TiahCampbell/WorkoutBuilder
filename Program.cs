using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's Build a Workout!");


            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("1. Add Exercise From Library");
                Console.WriteLine("2. Create New Exercise");
                Console.WriteLine("3. View Workout");
                Console.WriteLine("4. Increase Difficulty of Workout");
                Console.WriteLine("5. Decrease Difficulty of Workout");
                Console.WriteLine("6. Select Exercise in Workout to Edit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
