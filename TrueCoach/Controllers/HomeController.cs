using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrueCoach.Models;

namespace TrueCoach.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = TempData["TrueCoachUserID"];

            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
