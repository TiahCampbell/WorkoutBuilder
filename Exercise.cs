using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Exercise
    {
        public string Name { get; set; }
        public int RepsPerSet { get; set; } = 10;
        public string MuscleWorked { get; set; }
        public int NumberOfSets { get; set; } = 1;
        public int WeightUsed { get; set; }
        public int MuscleExaustion { get; set; } = 20;

        public Exercise()
        {

        }
        
        public Exercise(string name, string muscleWorked, int weightUsed)
        {
            Name = name;
            MuscleWorked = muscleWorked;
            WeightUsed = weightUsed;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetRepsPerSet(int repsPerSet)
        {
            RepsPerSet = repsPerSet;
        }

        public int GetRepsPerSet()
        {
            return RepsPerSet;
        }

        public void SetMuscleWorked(string muscleWorked)
        {
            MuscleWorked = muscleWorked;
        }

        public string GetMuscleWorked()
        {
            return MuscleWorked;
        }

        public void SetNumberOfSets(int numberOfSets)
        {
            NumberOfSets = numberOfSets;
        }

        public int GetNumberOfSets()
        {
            return NumberOfSets;
        }

        public void SetWeightUsed(int weightUsed)
        {
            WeightUsed = weightUsed;
        }

        public int GetWeightUsed()
        {
            return WeightUsed;
        }

        public void IncreaseDifficulty()
        {
            RepsPerSet += 2;

            NumberOfSets += 1;
        }

        public void DecreaseDifficulty()
        {
            RepsPerSet -= 2;

            NumberOfSets -= 1;
        }

        public void IncreaseWeight()
        {
            WeightUsed += 5;
        }

        public void DecreaseWeight()
        {
            WeightUsed -= 5;
        }

        public int CalculateMuscleExaustion()
        {
            MuscleExaustion *= NumberOfSets;

            return MuscleExaustion;
        }

        
    }
}
