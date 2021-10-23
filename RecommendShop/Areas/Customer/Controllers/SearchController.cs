using Microsoft.AspNetCore.Mvc;
using RecommendShop.Areas.Customer.ViewModels;
using RecommendShop.Data;
using RecommendShop.Models;
using RecommendShop.ModelsDTO.TikiItemProductModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchByCategoryId(string id)
        {
            var lsProduct = new SearchVm();
            lsProduct.ListProduct = _context.Products.Where(p => p.CategoryId == id).ToList();
            lsProduct.ListCategory = _context.Categories.ToList();
            return View(nameof(Index), lsProduct);
        }

        public IActionResult SearchBySlug(string slug)
        {
            slug = slug.ToSlug();
            var lsProduct = new SearchVm();
            lsProduct.ListCategory = _context.Categories.ToList();
            lsProduct.ListProduct = _context.Products.Where(p => p.UrlKey.Contains(slug)).ToList();
            return View(nameof(Index), lsProduct);
        }

    }
}
