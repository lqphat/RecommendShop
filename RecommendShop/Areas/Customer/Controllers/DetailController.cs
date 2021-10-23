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

    public class DetailController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DetailController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string id)
        {
            var detailProductVm = GetById(id);
            return View(detailProductVm);
        }

        public DetailVm GetById(string id)
        {
            var detailVm = new DetailVm();

            detailVm.Product = (Models.ProductModel)_context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            detailVm.ListAttribute = (List<Models.AttributeModel>)_context.Attributes.Where(a => a.ProductId == id).ToList();
            detailVm.ListReview = (List<Models.ReviewModel>)_context.Reviews.Where(r => r.ProductId == id).ToList();
            detailVm.ListCategory = _context.Categories.ToList();

            return detailVm;
        }
    }
}
