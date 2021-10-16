using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Models
{
    public class ReviewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string ReviewId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public float Rank { get; set; }

        [ForeignKey("ProductId")]
        public string ProductId { get; set; }
        public ProductModel Product { get; set; }

    }
}
