using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public Workout WorkoutID { get; set; }
        public string Name { get; set; }
        public string Describtion { get; set; }
        public string link { get; set; }
    }
}
