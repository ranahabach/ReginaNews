using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReginaNews.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ReginaNews.Controllers
{
    public class HomeController : Controller
    {
        NewsContext Db; 
        public HomeController (NewsContext context)
        {
            Db = context;

        }

        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()

        {
            var result = Db.Category.ToList();               
            return View(result);
        }
        public IActionResult About()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact ()
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
