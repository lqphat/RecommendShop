using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecommendShop.Models;
using RecommendShop.Services.TikiServices.ProductTiKiService;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductTikiService _productTikiService;
        private string productId;
        private string shopId;
        private string type;
        private string path;
        private RestClient client;

        public HomeController(ILogger<HomeController> logger, IProductTikiService productTikiService)
        {
            _logger = logger;
            _productTikiService = productTikiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string productLink)
        {
            if (productLink.Contains("https://tiki.vn"))
            {
                var shortPath = productLink.Substring(0, productLink.IndexOf("?"));
                int indexOfDot = shortPath.LastIndexOf(".");
                int indexOfDash = shortPath.LastIndexOf("-");

                int startIndexProductId = indexOfDash + 2;
                int lengProductId = indexOfDot - startIndexProductId;

                productId = productLink.Substring(startIndexProductId, lengProductId);
                type = "TIKI";
                //path = $"{shortPath}\n{productId}\n{shopId}";
            }
            else if (productLink.Contains("https://shopee.vn"))
            {
                var shortPath = productLink.Substring(0, productLink.IndexOf("?"));
                int indexOfQuestion = productLink.IndexOf("?");
                int indexOfDot = shortPath.LastIndexOf(".");
                int indexOfDash = shortPath.LastIndexOf("-");

                int startIndexProductId = indexOfDot + 1;
                int lengProductId = indexOfQuestion - startIndexProductId;

                int startIndexShopId = indexOfDash + 3;
                int lengProductShopId = indexOfDot - startIndexShopId;

                productId = productLink.Substring(startIndexProductId, lengProductId);
                shopId = productLink.Substring(startIndexShopId, lengProductShopId);
                type = "SHOPEE";
                //path = $"{shortPath}\n{productId}\n{shopId}";

            }
            //return Content(path);
            return RedirectToAction("GetData", new { type = type, productId = productId, shopId = shopId });
        }

        [HttpGet]
        public IActionResult GetData(string type, string productId, string shopId)
        {
            if (type == "TIKI")
            {
                client = new RestClient($"https://TIKI.vn/api/v2/products/{productId}");
            }
            else if(type == "SHOPEE")
            {
                client = new RestClient($"https://shopee.vn/api/v4/item/get?itemid={productId}&shopid={shopId}");
            }
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(response.Content);
            ViewBag.Data = dataDto;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
