using NUnit.Framework;
using TrueCoach.Models;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Exercise_Name1()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "Bench";

            Assert.AreEqual("Bench" , exercise.Name);
        }

        [Test]
        public void Exercise_Name2()
        {
            Exercise exercise = new Exercise();
            exercise.Name = "Squat";

            Assert.AreEqual("Squat", exercise.Name);
        }

        [Test]
        public void ExerciseID1()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 1;

            Assert.AreEqual(1, exercise.ID);
        }

        [Test]
        public void ExerciseID2()
        {
            Exercise exercise = new Exercise();
            exercise.ID = 2;

            Assert.AreEqual(2, exercise.ID);
        }
    }
}