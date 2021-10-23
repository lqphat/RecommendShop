using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Customer.ViewModels
{
    public class SearchVm
    {
        public List<ProductModel> ListProduct { get; set; }
        public List<CategoryModel> ListCategory{ get; set; }
    }
}
