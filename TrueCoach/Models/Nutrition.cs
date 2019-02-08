using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Lose Body Fat")]
        LoseFat = 1,
        [Display(Name = "Build Muscle")]
        BuildMuscle,
        [Display(Name = "Maintainance")]
        Maintain
    }
}


