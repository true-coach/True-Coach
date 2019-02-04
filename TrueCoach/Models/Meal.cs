using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models
{
    public class Meal
    {
        public int ID { get; set; }
        public Nutrition NutritionID { get; set; }
        public string Name { get; set; }
        public string Describtion { get; set; }
    }
}
