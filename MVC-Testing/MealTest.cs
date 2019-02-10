using NUnit.Framework;
using TrueCoach.Models;

namespace Tests
{
    public class MealTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MealID1()
        {
            Meal meal = new Meal();
            meal.ID = 1;

            Assert.AreEqual(1, meal.ID);
        }

        [Test]
        public void MealID2()
        {
            Meal meal = new Meal();
            meal.ID = 2;

            Assert.AreEqual(2, meal.ID);
        }

        [Test]
        public void NutritionID1()
        {
            Meal meal = new Meal();
            meal.NutritionId = 1;

            Assert.AreEqual(1, meal.NutritionId);
        }

        [Test]
        public void NutritionID2()
        {
            Meal Meal = new Meal();
            Meal.NutritionId = 2;

            Assert.AreEqual(2, Meal.NutritionId);
        }

        [Test]
        public void Meal_Name1()
        {
            Meal meal = new Meal();
            meal.Name = "Turkey";

            Assert.AreEqual("Turkey", meal.Name);
        }

        [Test]
        public void Meal_Name2()
        {
            Meal meal = new Meal();
            meal.Name = "Shrimp";

            Assert.AreEqual("Shrimp", meal.Name);
        }

        [Test]
        public void MealDescription1()
        {
            Meal meal = new Meal();
            meal.Description = "discription #1";

            Assert.AreEqual("discription #1", meal.Description);
        }

        [Test]
        public void MealDescription2()
        {
            Meal meal = new Meal();
            meal.Description = "discription #2";

            Assert.AreEqual("discription #2", meal.Description);
        }


    }
}