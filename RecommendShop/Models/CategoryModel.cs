using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Models
{
    public class CategoryModel
    {
        [Key]
        public string CategoryId { get; set; }
        //public string Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string ParentId { get; set; }
        public List<ProductModel> ListProduct { get; set; }
    }
}
