using System.Diagnostics;

using Cucklist.Models;

using Microsoft.AspNetCore.Mvc;

namespace Cucklist.Controllers
{
    public class HomeController:Controller
    {


        public string ContactPermission;
        public IActionResult Index()
        {

            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
