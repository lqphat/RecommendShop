using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class Attribute
    {
        public string name { get; set; }
        public string value { get; set; }
        public int id { get; set; }
        public bool is_timestamp { get; set; }
        public object brand_option { get; set; }
        public object val_id { get; set; }
    }
}
