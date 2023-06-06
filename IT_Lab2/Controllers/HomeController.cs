using IT_Lab2.Contexts;
using IT_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing;

namespace IT_Lab2.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();
        public IActionResult Index() => View(db.Students.Include(s => s.Group));
    }
}