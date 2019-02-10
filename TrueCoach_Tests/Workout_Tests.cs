using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;

namespace TrueCoach_Tests
{
    public class Workout_Tests
    {
        [Fact]
        public void CanGetWorkoutID()
        {
            Workout workout = new Workout();
            workout.ID = 1;
            Assert.Equal(1, workout.ID);
        }
        [Fact]
        public void CanSetWorkoutID()
        {
            Workout workout = new Workout();
            workout.ID = 1;
            workout.ID = 2;
            Assert.Equal(2, workout.ID);
        }

        [Fact]
        public void CanGetWorkoutWorkoutTypeID()
        {
            Workout workout = new Workout();
            workout.WorkoutTypeID = 1;
            Assert.Equal(1, workout.WorkoutTypeID);
        }
        [Fact]
        public void CanSetWorkoutWorkoutTypeID()
        {
            Workout workout = new Workout();
            workout.WorkoutTypeID = 1;
            workout.WorkoutTypeID = 2;
            Assert.Equal(2, workout.WorkoutTypeID);
        }

        [Fact]
        public void CanGetWorkoutWorkoutGoals()
        {
            Workout workout = new Workout();
            workout.WorkoutGoals = Goals.FatLoss;
            Assert.Equal(Goals.FatLoss, workout.WorkoutGoals);
        }
        [Fact]
        public void CanSetWorkoutWorkoutGoals()
        {
            Workout workout = new Workout();
            workout.WorkoutGoals = Goals.FatLoss;
            workout.WorkoutGoals = Goals.Mobility;
            Assert.Equal(Goals.Mobility, workout.WorkoutGoals);
        }
    }
}
