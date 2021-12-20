using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
         
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<OurTeams> ourTeams = _context.OurTeams.Include("Position").ToList();
            return View(ourTeams);
        }
    }
}
