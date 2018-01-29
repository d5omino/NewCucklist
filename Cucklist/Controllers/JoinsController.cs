using System.Threading.Tasks;

using Cucklist.Data;
using Cucklist.Models;

using Microsoft.AspNetCore.Mvc;

namespace Cucklist.Controllers
{
    public class JoinsController:Controller
    {
        private readonly ApplicationDbContext _context;

        public JoinsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Joins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Joins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JoinId,GivenName,FamilyName,Email,Phone,Contact,Notify")] Join @join)
        {
            if(ModelState.IsValid)
            {
                _context.Add(@join);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Index",$"Home");
            }
            return View(@join);
        }


    }
}
