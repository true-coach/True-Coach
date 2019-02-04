using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public WorkoutType workoutTypeID { get; set; }
        public  Goal GoalID { get; set; }
    }
}
