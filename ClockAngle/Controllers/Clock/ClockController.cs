using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ClockAngleProject.Models;

namespace ClockAngleProject.Controllers
{
    public class ClockController : Controller
    {
        [HttpPost("/Clock/Create")]
        public ActionResult Create()
        {
            Clock myClock = new Clock();
            myClock.SetMinute(Request.Form["minute"]);
            myClock.SetHour(Request.Form["hour"]);
            return View("Display", myClock);
        }
    }
}
