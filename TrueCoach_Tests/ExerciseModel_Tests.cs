using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;

namespace TrueCoach_Tests
{
    public class ExerciseModel_Tests
    {
        [Fact]
        public void CanGetExceciseID()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 1;
            Assert.Equal(1, exercise.ID);
        }

        [Fact]
        public void CanSetExerciseID()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 1;
            exercise.ID = 2;
            Assert.Equal(2, exercise.ID);
        }

        [Fact]
        public void CanGetWorkoutID()
        {
            Exercise exercise = new Exercise();
            exercise.WorkoutID = 1;
            Assert.Equal(1, exercise.WorkoutID);
        }

        [Fact]
        public void CanSetExerciseWorkoutID()
        {
            Exercise exercise = new Exercise();
            exercise.WorkoutID = 1;
            exercise.WorkoutID = 2;
            Assert.Equal(2, exercise.WorkoutID);
        }

        [Fact]
        public void CanGetExceciseName()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "Name";
            Assert.Equal("Name", exercise.Name);
        }

        [Fact]
        public void CanSetExerciseName()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "First";
            exercise.Name = "Name";
            Assert.Equal("Name", exercise.Name);
        }

        [Fact]
        public void CanGetExceciseDescription()
        {
            Exercise exercise = new Exercise();
            exercise.Description = "Yes";
            Assert.Equal("Yes", exercise.Description);
        }

        [Fact]
        public void CanSetExerciseDescription()
        {
            Exercise exercise = new Exercise();
            exercise.Description = "No";
            exercise.Description = "Yes";
            Assert.Equal("Yes", exercise.Description);
        }

    }
}
