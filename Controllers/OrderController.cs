using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View(new Order());
        }
    }
}
