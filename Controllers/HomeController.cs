using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testport.Models;
using testport.Data;

namespace testport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult savedata(Login login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appDbContext.Add(login);
                    _appDbContext.SaveChanges();
                    ViewBag.Message = "Info Saved Successfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "There is an error";
                }

            }
            return View("index");
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
