using DaMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovApplicationContext _someContext { get; set; }

        // constructor
        public HomeController(ILogger<HomeController> logger, MovApplicationContext someName)
        {
            _logger = logger;
            _someContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        //added this to be the My_Podcasts Action
        public IActionResult My_Podcasts()
        {
            return View("My_Podcasts");
        }

       //added this for the movie form
       [HttpGet]
        public IActionResult MovieForm()
        {
            return View("MovieForm");
        }
        //and this to go to the confimation page
        [HttpPost]
        public IActionResult MovieForm(FormClass response)
        {
            _someContext.Add(response);
            _someContext.SaveChanges();
            return View("Confirmation");
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
