using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReginaNews.Models;
using System.Diagnostics;
using System.Linq;

namespace ReginaNews.Controllers
{
    public class HomeController : Controller
    {
        NewsContext Db;
        public HomeController(NewsContext context)
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
        public IActionResult TeamMember()
        {
            return View();
        }
        public IActionResult News(int id)

        {
            var result = Db.News.Where(x =>x.CategoryId == id).OrderByDescending(x=>x.Date).ToList();
             return View(result);
        }


        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DeletNews(int id)
        {
            var News = Db.News.Find(id);
            Db.News.Remove(News);
            Db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Contact ()
            
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveContact(ContactUs model)
            
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        

        [HttpPost]
       
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
