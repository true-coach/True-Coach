using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCoach.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace TrueCoach.Controllers
{
    public class WorkoutTypeController:Controller
    //{
    // public async Task<IActionResult> Index(string workoutTypeName)
    //    {
    //        workoutType = await_context.GetWorkoutType();

    //        if (!string.IsNullOrEmpty(workoutTypeName))
    //        {
    //            WorkoutType = workoutTypeName.Where(wt => wt.Name.ToLower().contains(workoutTypeName.ToLower()));
    //        }
    //    }
    //}


    //Get:Workouttype/create
    {
        private object _context;
        public IActionResult create()
        {
            return View();
        }
        public async Task<IActionResult> create([Bind("ID,Name")]WorkoutType workoutType)
        {
            await _context.CreateWorkoutType(WorkoutType);
            return RedirectToAction(nameof(Index));
        }
        return View(room);
    }
    //Get:WorkoutType/Edit

        public async Task<IActionResult> Edit(int? id)
    {
        if(id==null)
    }

}



