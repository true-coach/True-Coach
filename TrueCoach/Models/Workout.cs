using System.ComponentModel.DataAnnotations;

namespace TrueCoach.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public int WorkoutTypeID { get; set; }
        public Goals WorkoutGoals { get; set; }

        public WorkoutType WorkoutType { get; set; }
    }

    public enum Goals
    {
        [Display(Name = "Strength")]
        Strength = 1,
        [Display(Name = "Fat Loss")]
        FatLoss,
        [Display(Name = "Only 30 Minutes")]
        NoTime,
        [Display(Name = "Mobility")]
        Mobility
    }
}