using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class CurrentSeller
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string logo { get; set; }
        public int price { get; set; }
        public string product_id { get; set; }
        public int store_id { get; set; }
        public bool is_best_store { get; set; }
        public object is_offline_installment_supported { get; set; }
    }
}
