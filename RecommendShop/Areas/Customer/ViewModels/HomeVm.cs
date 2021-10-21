using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Customer.ViewModels
{
    public class HomeVm
    {
        public List<CategoryModel> ListCategory { get; set; }
        public List<ProductModel> ListProduct { get; set; }
    }
}
