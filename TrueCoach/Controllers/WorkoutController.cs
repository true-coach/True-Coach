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
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public List<Workout> GetWorkoutByGoal(Goals goal)
        {
            string apiUrl = "https://localhost:44396/api/Workouts/" + (int)goal;

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
        public IActionResult ViewWorkout(Goals goal)
        {
            var workout = GetWorkoutByGoal(goal);
            if (workout == null)
            {
                ViewBag.Status = "Invalid workout";
            }
            else
            {
                ViewBag.Status = "Goals " + goal;
                // this.HttpContext.Session.("TrueCoachUserID", (int)goal);

                this.ControllerContext.HttpContext.Session.SetInt32("TrueCoachUserID", (int)goal);

                //this.ControllerContext.HttpContext.Session.SetInt32("TrueCoachUserID", );

                return RedirectToAction("Index", "Workout");
            }            
        return null;
        }
        public IActionResult Results()
            {
                return View("Index");
            }
    }
}