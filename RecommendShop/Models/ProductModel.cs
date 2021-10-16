using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Models
{
    public class ProductModel
    {
        [Key]
        //public string Id { get; set; }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string PriceCurrent { get; set; }
        public string PriceOld { get; set; }
        public string Description { get; set; }
        public string ImageMainUrl { get; set; }
        public double Rating { get; set; }
        public List<AttributeModel> ListConfiguration { get; set; }
        public List<ReviewModel> ListReview { get; set; }

        [ForeignKey("CategoryId")]
        public string CategoryId { get; set; }
        public CategoryModel Category { get; set; }


    }
}
