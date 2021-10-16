using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Models
{
    public class AttributeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string AttributeId { get; set; }


        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
