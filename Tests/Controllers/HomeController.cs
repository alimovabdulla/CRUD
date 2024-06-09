﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tests.DataBase;
using Tests.Entities;
using Tests.Models;

namespace Tests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClassContext _context;
        public HomeController(ILogger<HomeController> logger, ClassContext classContext)
        {
            _context = classContext;
            _logger = logger;
        }

        public IActionResult Index()
        {


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
