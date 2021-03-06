﻿using Microsoft.AspNetCore.Mvc;
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
        /// <summary>
        /// control the flow of the application
        /// </summary>
        /// <param name="WorkoutID"></param>
        /// <returns></returns>
        public List<Exercise> GetExercisePlan(int WorkoutID)
        {
            //string apiUrl = "https://localhost:44396/api/Exercise/" ;
            string apiUrl = "https://truecoachapi.azurewebsites.net/api/Exercise/" + WorkoutID;


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

        public IActionResult ExerciseListView(int workoutId)
        {
            var workoutList = GetExercisePlan(workoutId);

            return View("Detail", workoutList);
        }
    }
}