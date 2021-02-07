using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Workout
    {
        public List<Exercise> ListofExercises = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            ListofExercises.Add(exercise);
        }

        public Exercise EditExercise()
        {
            int index = 1;

            Console.WriteLine("Please select an exercise from the list to edit:");

            foreach (Exercise exercise in ListofExercises)
            {
                Console.WriteLine(index + ". " + exercise.Name);
                Console.WriteLine("Muscle being worked: " + exercise.MuscleWorked);
                Console.WriteLine("Muscle exaustion level: " + exercise.MuscleExaustion);
                Console.WriteLine("Number of repetitions per set: " + exercise.RepsPerSet);
                Console.WriteLine("Number of sets: " + exercise.NumberOfSets);
                Console.WriteLine("Weight used: " + exercise.WeightUsed + " lbs");
                Console.WriteLine(" ");

                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListofExercises[indexSelected - 1];
        }
        public void RemoveExercise()
        {
            int index = 1;

            Console.WriteLine("Please select an exercise from the list to remove:");

            foreach (Exercise exercise in ListofExercises)
            {
                Console.WriteLine(index + ". " + exercise.Name);
                Console.WriteLine("Muscle being worked: " + exercise.MuscleWorked);
                Console.WriteLine("Muscle exaustion level: " + exercise.MuscleExaustion);
                Console.WriteLine("Number of repetitions per set: " + exercise.RepsPerSet);
                Console.WriteLine("Number of sets: " + exercise.NumberOfSets);
                Console.WriteLine("Weight used: " + exercise.WeightUsed + " lbs");
                Console.WriteLine(" ");
                
                index++;

            }
            
            int indexSelected = Convert.ToInt32(Console.ReadLine());
            ListofExercises.RemoveAt(indexSelected - 1);
            
        }

        public void ViewWorkout()
        {
            int index = 1;
            foreach (Exercise exercise in ListofExercises)
            {
                Console.WriteLine(index + ". " + exercise.Name);
                Console.WriteLine("Muscle being worked: " + exercise.MuscleWorked);
                Console.WriteLine("Muscle exaustion level: " + exercise.MuscleExaustion);
                Console.WriteLine("Number of repetitions per set: " + exercise.RepsPerSet);
                Console.WriteLine("Number of sets: " + exercise.NumberOfSets);
                Console.WriteLine("Weight used: " + exercise.WeightUsed + " lbs");
                Console.WriteLine(" ");

                index++;
            }


        }
        public void IncreaseWorkoutDifficulty()
        {
            foreach (Exercise exercise in ListofExercises)
            {
                exercise.IncreaseDifficulty();
            }
        }
        public void DecreaseWorkoutDifficulty()
        {
            foreach (Exercise exercise in ListofExercises)
            {
                exercise.DecreaseDifficulty();
            }
        }
    }
}
