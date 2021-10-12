using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO
{
    public class ProductModelDTO
    {
        public int id { get; set; }
        public int master_id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public string url_key { get; set; }
        public string url_path { get; set; }
        public string type { get; set; }
        public object book_cover { get; set; }
        public string short_description { get; set; }
        public int price { get; set; }
        public int list_price { get; set; }
        public int original_price { get; set; }
        public int discount { get; set; }
        public int discount_rate { get; set; }
        public double rating_average { get; set; }
        public int review_count { get; set; }
        public string thumbnail_url { get; set; }
        public string description { get; set; }

    }
}
