using System.Collections.Generic;

namespace TrueCoach.Models
{
    public class Nutrition
    {
        public int ID { get; set; }
        public int GoalID { get; set; }
        public Meal[] Meals { get; set; }

        public FoodGoal NutritionGoals { get; set; }

    }

    public enum FoodGoal
    {
        LoseFat = 1,
        BuildMuscle,
        Maintain
    }
}

