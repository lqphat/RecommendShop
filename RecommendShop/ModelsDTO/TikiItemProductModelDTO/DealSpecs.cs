using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class DealSpecs
    {
        public bool is_hot_deal { get; set; }
        public int qty { get; set; }
        public int max_sale_qty { get; set; }
        public int qty_ordered { get; set; }
        public double special_to_date { get; set; }
        public int price { get; set; }
        public int list_price { get; set; }
        public int original_price { get; set; }
        public int discount_rate { get; set; }
        public int progress { get; set; }
        public string progress_text { get; set; }
        public int v5 { get; set; }
    }
}
