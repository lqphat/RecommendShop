using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Areas.Customer.ViewModels
{
    public class DetailVm
    {
        public ProductModel Product { get; set; }
        public List<AttributeModel> ListAttribute { get; set; }
        public List<ReviewModel> ListReview { get; set; }
        public List<CategoryModel> ListCategory{ get; set; }
}
}
