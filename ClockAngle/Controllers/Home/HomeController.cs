using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClockAngleProject.Models;

namespace ClockAngleProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form()
        {
            return View();
        }
    }
}
