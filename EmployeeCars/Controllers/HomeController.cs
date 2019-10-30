using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeCars.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCars.Controllers
{
    public class HomeController : Controller
    {
        private EMPLContext db;
        public HomeController(EMPLContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Employes.ToListAsync());
        }
        public IActionResult RegForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegForm(Employee emp)
        {
            db.Employes.Add(emp);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}