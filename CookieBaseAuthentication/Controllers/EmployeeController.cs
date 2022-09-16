using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookieBaseAuthentication.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "user,admin")]
        public IActionResult Details()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Add()
        {
            return View();
        }
    }
}