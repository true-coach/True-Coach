﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrueCoach.Models;

namespace TrueCoach.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public User GetUserByUserName(string user)
        {
          // string apiUrl = "https://localhost:44396/api/users/" + user;
            string apiUrl = "https://truecoachapi.azurewebsites.net/api/users/" + user;
           

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    var userObject = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(data);

                    return userObject;

                }
            }
            return null;
        }

        public IActionResult Login(string UserName)
        {
            var user = GetUserByUserName(UserName);
            if (user == null)
            {
                ViewBag.Status = "Invalid User";
                return RedirectToAction("Index", "User");

            }
            else
            {
                ViewBag.Status = "Welcome " + user.UserName;
                this.ControllerContext.HttpContext.Session.SetInt32("TrueCoachUserID", user.ID);

            }

            return RedirectToAction("Index", "Home");
        }

        public User CreateUserByUserName(string user)
        {
            //string apiUrl = "http://localhost:44396/api/users/" + user;
            string apiUrl = "https://truecoachapi.azurewebsites.net/api/users/" + user;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //doesnt get passed this point
                HttpResponseMessage response = client.PostAsync(apiUrl,null).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    var userObject = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(data);

                    return userObject;

                }
            }
            return null;
        }

        public IActionResult CreateUser(string UserName)
        {
            var user = CreateUserByUserName(UserName);
            this.ControllerContext.HttpContext.Session.SetString("TrueCoachUserID", user.UserName);
            HttpContext.Session.SetString("TrueCoachUserID", user.UserName);
           TempData["TrueCoachUserID"] = user.UserName;
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
          return View("Register");
        }
    }
}