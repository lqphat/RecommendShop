using Microsoft.AspNetCore.Mvc;
using RecommendShop.Areas.Customer.ViewModels;
using RecommendShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm()
            {
                ListCategory = _context.Categories.ToList(),
                ListProduct = _context.Products.ToList()
            };
            return View(homeVm);
        }
    }
}
