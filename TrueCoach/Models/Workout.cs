﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        Strength,
        FatLoss,
        NoTime,
        Mobility
    }
}

