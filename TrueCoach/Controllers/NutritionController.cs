using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrueCoach.Models;

namespace TrueCoach.Controllers
{
    public class NutritionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewMealPlan([Bind("NutritionGoals")] Nutrition nutritionModel)
        {
            var goal = (int)nutritionModel.NutritionGoals;

            var nutritionPlan = GetNutritionByGoal(goal);

            return View("Detail", nutritionPlan);
        }

        public List<Meal> GetNutritionByGoal(int goal)
        {
            //string apiUrl = "https://localhost:44396/api/Nutrition/" + goal;
            string apiUrl = "https://truecoachapi.azurewebsites.net/api/Nutrition/" + goal;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    var nutritionObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Meal>>(data);

                    return nutritionObject;

                }
            }
            return null;
        } 
    }
}