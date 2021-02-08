using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Workout myWorkout = new Workout();
            Exercise myExercise = new Exercise();

            Console.WriteLine("Hello! Let's Build a Workout!");


            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("1. Create New Exercise");
                Console.WriteLine("2. View Workout");
                Console.WriteLine("3. Increase Difficulty of Workout");
                Console.WriteLine("4. Decrease Difficulty of Workout");
                Console.WriteLine("5. Select Exercise in Workout to Edit");
                Console.WriteLine("6. Select Exercise in Workout to Delete");
                Console.WriteLine("7. Exit Workout Builder");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("What is the name of your exercise?\n(Examples: Push-Up, Squat, Deadlift, Pull-Up)");
                        string name = Console.ReadLine();
                        Console.WriteLine("What muscle does your exercise work? \n(Examples: Tricpes, Biceps, Quadriceps, Hamstrings, Chest, Back)");
                        string muscleWorked = Console.ReadLine();
                        Console.WriteLine("Will you be using any added weight? \nEnter the amount of weight, in pounds, used: \n(Enter 0 for bodyweight only)");
                        int weightUsed = Convert.ToInt32(Console.ReadLine());

                        myExercise = new Exercise(name, muscleWorked, weightUsed);
                        myWorkout.AddExercise(myExercise);
                        break;
                    case "2":
                        myWorkout.ViewWorkout();
                        break;
                    case "3":
                        myWorkout.IncreaseWorkoutDifficulty();
                        Console.WriteLine("You increased the difficulty of your workout.");
                        break;
                    case "4":
                        myWorkout.DecreaseWorkoutDifficulty();
                        Console.WriteLine("You decreased the difficulty of your workout.");
                        break;
                    case "5":
                        myExercise = myWorkout.EditExercise();

                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                        Console.Clear();

                        bool keepEditing = true;
                        while (keepEditing)
                        {
                            if (myExercise.RepsPerSet < 1)
                            {
                                myExercise.RepsPerSet = 1;
                            }
                            if (myExercise.NumberOfSets < 1)
                            {
                                myExercise.NumberOfSets = 1;
                            }
                            myExercise.CalculateMuscleExaustion();
                            if (myExercise.MuscleExaustion > 100)
                            {
                                myExercise.MuscleExaustion = 100;
                            }
                            if (myExercise.WeightUsed < 0)
                            {
                                myExercise.WeightUsed = 0;
                            }

                            Console.WriteLine(myExercise.Name);
                            Console.WriteLine("Muscle being worked: " + myExercise.MuscleWorked);
                            Console.WriteLine("Muscle exaustion level: " + myExercise.MuscleExaustion + "%");
                            Console.WriteLine("Number of repetitions per set: " + myExercise.RepsPerSet);
                            Console.WriteLine("Number of sets: " + myExercise.NumberOfSets);
                            Console.WriteLine("Weight used: " + myExercise.WeightUsed + " lbs");
                            Console.WriteLine(" ");

                            Console.WriteLine("1. Change Number of Repetitions");
                            Console.WriteLine("2. Change Number of Sets");
                            Console.WriteLine("3. Increase Weight Used by 5 lbs");
                            Console.WriteLine("4. Decrease Weight Used by 5 lbs");
                            Console.WriteLine("5. Select Another Exercise to Edit");
                            Console.WriteLine("4. Return to Main Menu");

                            string editChoice = Console.ReadLine();

                            Console.WriteLine("Press Any Key to Continue");
                            Console.ReadKey();
                            Console.Clear();

                            switch (editChoice)
                            {
                                case "1":
                                    Console.WriteLine("Please enter your new amount of repetitions for this exercise:");
                                    int newReps = Convert.ToInt32(Console.ReadLine());
                                    myExercise.SetRepsPerSet(newReps);
                                    Console.WriteLine("The repetitions for " + myExercise.Name + " are now " + myExercise.RepsPerSet);
                                    break;
                                case "2":
                                    Console.WriteLine("Please enter your new amount of sets for this exercise:");
                                    int newSets = Convert.ToInt32(Console.ReadLine());
                                    myExercise.SetNumberOfSets(newSets);
                                    Console.WriteLine("The sets for " + myExercise.Name + " are now " + myExercise.NumberOfSets);
                                    break;
                                case "3":
                                    myExercise.IncreaseWeight();
                                    Console.WriteLine("The weight for " + myExercise.Name + " is now " + myExercise.WeightUsed + " lbs");
                                    break;
                                case "4":
                                    myExercise.DecreaseWeight();
                                    Console.WriteLine("The weight for " + myExercise.Name + " is now " + myExercise.WeightUsed + " lbs");
                                    break;
                                case "5":
                                    myExercise = myWorkout.EditExercise();
                                    break;
                                case "6":
                                    keepEditing = false;
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("Press Any Key to Continue");
                            Console.ReadKey();
                            Console.Clear();


                        }
                        break;
                    case "6":
                        myWorkout.RemoveExercise();
                        Console.WriteLine("The selected exercise was removed from your workout.");
                        break;
                    case "7":
                        Console.WriteLine("Thanks for working out with us! Bye!");
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }

                Console.WriteLine("Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}
