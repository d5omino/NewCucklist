using Microsoft.AspNetCore.Mvc;

namespace Cucklist.Controllers
{
    public class JoinController:Controller
    {


        [HttpPost]
        public IActionResult Index(string email)
        {
            return View();
        }
    }
}