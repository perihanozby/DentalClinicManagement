using Microsoft.AspNetCore.Mvc;
using DentalClinicManagement.Models;
using System.Linq;
using DentalClinicManagement.Data;

namespace DentalClinicManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminUser adminUser)
        {
            var admin = _context.AdminUsers
                .FirstOrDefault(a => a.UserName == adminUser.UserName && a.Password == adminUser.Password);

            if (admin != null)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }
    }
}
