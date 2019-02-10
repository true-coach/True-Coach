using NUnit.Framework;
using TrueCoach.Models;

namespace NutritionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NutritionID1()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.ID = 1;

            Assert.AreEqual(1, nutrition.ID);
        }

        [Test]
        public void MealID2()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.ID = 2;

            Assert.AreEqual(2, nutrition.ID);
        }

        [Test]
        public void GoalID1()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.GoalID = 1;

            Assert.AreEqual(1, nutrition.GoalID);
        }

        [Test]
        public void NutritionID2()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.GoalID = 2;

            Assert.AreEqual(2, nutrition.GoalID);
        }

        [Test]
        public void MealLoseFat()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.NutritionGoals = FoodGoal.LoseFat;

            Assert.AreEqual(FoodGoal.LoseFat, nutrition.NutritionGoals);
        }
        [Test]
        public void MealLBuildMuscle()
        {
            Nutrition nutrition = new Nutrition();
            nutrition.NutritionGoals = FoodGoal.BuildMuscle;

            Assert.AreEqual(FoodGoal.BuildMuscle, nutrition.NutritionGoals);
        }
    }
}