using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecommendShop.Data;
using RecommendShop.Models;
using RecommendShop.ModelsDTO;
using RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO;
using RecommendShop.ModelsDTO.TikiItemProductModelDTO;
using RecommendShop.ModelsDTO.TikiItemReviewModelDTO;
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
        private string productId;
        private string shopId;
        private string type;
        private string path;
        private RestClient clientProduct;
        private RestClient clientReview;
        //private IRestResponse responseReview;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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
                int startIndexProductId, lengProductId, startIndexShopId, lengProductShopId;
                if (productLink.Contains("?"))
                {
                    var shortPath = productLink.Substring(0, productLink.IndexOf("?"));
                    int indexOfQuestion = productLink.IndexOf("?");
                    int indexOfDot = shortPath.LastIndexOf(".");
                    int indexOfDash = shortPath.LastIndexOf("-");

                     startIndexProductId = indexOfDot + 1;
                     lengProductId = indexOfQuestion - startIndexProductId;

                     startIndexShopId = indexOfDash + 3;
                     lengProductShopId = indexOfDot - startIndexShopId;
                }
                else
                {
                    int indexOfDot = productLink.LastIndexOf(".");
                    int indexOfDash = productLink.LastIndexOf("-");

                    startIndexProductId = indexOfDot + 1;
                    lengProductId = productLink.Length - startIndexProductId;

                    startIndexShopId = indexOfDash + 3;
                    lengProductShopId = indexOfDot - startIndexShopId;
                }

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
            var product = new ProductModel();
            var listBreadcrumb = new List<Breadcrumb>();
            var listCate = new List<CategoryModel>();
            var listDatum = new List<Datum>();
            var listRating = new List<Rating>();
            var listReview = new List<ReviewModel>();
            var listAttribute = new List<AttributeModel>();
            //var list
            if (type == "TIKI")
            {
                #region PRODUCT
                clientProduct = new RestClient($"https://tiki.vn/api/v2/products/{productId}");
                clientProduct.Timeout = -1;
                var requestProduct = new RestRequest(Method.GET);
                IRestResponse responseProduct = clientProduct.Execute(requestProduct);

                
                var productDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsDTO.TikiItemProductModelDTO.Root>(responseProduct.Content);
                var attributes = productDto.ToModelConfiguration();

                product = productDto.ToProductModel();

                listAttribute.AddRange(attributes);

                listBreadcrumb = productDto.breadcrumbs;

                listCate = listBreadcrumb.ToListCategoryModel();

                #endregion

                #region REVIEW

                var sellerId = productDto.current_seller.id;

                var length = 1;

                for (int i = 1; i <= length && listReview.Count <= 50; i++)
                {
                    clientReview = new RestClient($"https://tiki.vn/api/v2/reviews?product_id={productId}&seller_id={sellerId}&page={i}");
                    //path = $"https://tiki.vn/api/v2/reviews?product_id={productId}&seller_id={sellerId}";
                    clientReview.Timeout = -1;
                    var requestReview = new RestRequest(Method.GET);
                    //responseReview = clientReview.Execute(requestReview);
                    IRestResponse responseReview = clientReview.Execute(requestReview);

                    var reviewDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsDTO.TikiItemReviewModelDTO.Root>(responseReview.Content);
                    
                    length = reviewDto.paging.last_page; // Set lai dieu kien

                    path = length.ToString();

                    listDatum = reviewDto.data;

                    var reviewOnePage = listDatum.ToListReviewModel();

                    listReview.AddRange(reviewOnePage);
                }
                #endregion

            }
            else if(type == "SHOPEE")
            {
                #region PRODUCT

                clientProduct = new RestClient($"https://shopee.vn/api/v4/item/get?itemid={productId}&shopid={shopId}");
                clientProduct.Timeout = -1;
                var requestProduct = new RestRequest(Method.GET);
                IRestResponse responseProduct = clientProduct.Execute(requestProduct);

                var productDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsDTO.ShopeeItemProductModelDTO.Root>(responseProduct.Content);
                #endregion

                #region REVIEW
                clientReview = new RestClient($"https://shopee.vn/api/v2/item/get_ratings?itemid={productId}&limit=50&offset=0&shopid={shopId}");
                clientReview.Timeout = -1;
                var requestReview = new RestRequest(Method.GET);
                //responseReview = clientReview.Execute(requestReview);
                IRestResponse responseReview = clientReview.Execute(requestReview);

                var reviewDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsDTO.ShopeeItemReviewModelDTO.Root>(responseReview.Content);

                listRating = reviewDto.data.ratings;

                listReview = listRating.ToReviewModel();
                #endregion
            }

            ViewBag.c1 = product.ProductId;
            //ViewBag.c2 = product.Name;
            //ViewBag.c3 = listReview[0].Title;
            //ViewBag.c4 = listReview[0].Content;
            //ViewBag.c5 = listCate[0].Name;
            //ViewBag.c6 = listCate[1].Name;

            var lsCate = _context.Categories.ToList();
            foreach (var item in listCate)
            {
                var temp = lsCate.Where(c => c.CategoryId == item.CategoryId).FirstOrDefault();
                if (lsCate.Count == 0 || temp == null)
                {
                    _context.Categories.Add(item);
                }
            }
            _context.Reviews.AddRange(listReview);
            _context.Products.Add(product);
            _context.Attributes.AddRange(listAttribute);


            _context.SaveChanges();
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
