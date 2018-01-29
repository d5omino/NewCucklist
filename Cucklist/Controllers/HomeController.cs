using System.Diagnostics;

using Cucklist.Models;

using Microsoft.AspNetCore.Mvc;

namespace Cucklist.Controllers
{
    public class HomeController:Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        
        
    }

    
}
