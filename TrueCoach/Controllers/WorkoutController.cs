using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using TrueCoach.Models;

namespace TrueCoach.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Workout> GetWorkoutsByGoal(int goal)
        {
           //string apiUrl = "https://localhost:44396/api/Workouts/" ;
           string apiUrl = "https://truecoachapi.azurewebsites.net/api/Workouts/" + (int)goal;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    var workoutObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Workout>>(data);

                    return workoutObject;

                }
            }
            return null;
        }

        public IActionResult ViewWorkout([Bind("WorkoutGoals")] Workout workoutModel)
        {
            var goal = (int)workoutModel.WorkoutGoals;

            var workoutList = GetWorkoutsByGoal(goal);
            if (workoutList == null)
            {
                ViewBag.Status = "Invalid workout";
            }
            else
            {
                ViewBag.Status = "Goals " + goal;
                this.ControllerContext.HttpContext.Session.SetInt32("TrueCoachUserID", goal);

                return View("Index", workoutList);
            }
            return null;
        }

        public IActionResult Details(int workoutid)
        {
            return RedirectToAction("ExerciseListView", "Exercise", new { workoutId = workoutid });
        }
    }  
}