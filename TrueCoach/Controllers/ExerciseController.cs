using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TrueCoach.Models;

namespace TrueCoach.Controllers
{
    public class ExerciseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public List<Exercise> GetExercisePlan(int WorkoutID)
        {
            string apiUrl = "https://localhost:44396/api/Exercise/" + WorkoutID;
            //string apiUrl = "https://truecoachapi.azurewebsites.net/";


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    var exercises = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exercise>>(data);

                    return exercises;
                }
            }
            return null;
        }

        public IActionResult ExerciseListView(int workoutID)
        {
            var workoutList = GetExercisePlan(workoutID);

            return View("Index", workoutList);
        }
    }
}