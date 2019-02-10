using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TrueCoach.Models;


namespace TrueCoach_Tests
{
    public class WorkoutType_Tests
    {
        [Fact]
        public void CanGetWorkoutTypeID()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.ID = 1;
            Assert.Equal(1, workoutType.ID);
        }
        [Fact]
        public void CanSetWorkoutTypeID()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.ID = 1;
            workoutType.ID = 2;
            Assert.Equal(2, workoutType.ID);
        }

        [Fact]
        public void CanGetWorkoutTypeName()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.Name = "Name";
            Assert.Equal("Name", workoutType.Name);
        }
        [Fact]
        public void CanSetWorkoutTypeName()
        {
            WorkoutType workoutType = new WorkoutType();
            workoutType.Name = "First";
            workoutType.Name = "Name";
            Assert.Equal("Name", workoutType.Name);
        }

    }
}
