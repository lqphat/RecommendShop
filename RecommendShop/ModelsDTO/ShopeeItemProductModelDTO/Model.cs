using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class Model
    {
        public object itemid { get; set; }
        public int status { get; set; }
        public int current_promotion_reserved_stock { get; set; }
        public string name { get; set; }
        public int promotionid { get; set; }
        public object price { get; set; }
        public List<PriceStock> price_stocks { get; set; }
        public bool current_promotion_has_reserve_stock { get; set; }
        public int normal_stock { get; set; }
        public Extinfo extinfo { get; set; }
        public object price_before_discount { get; set; }
        public object modelid { get; set; }
        public int stock { get; set; }
        public bool has_gimmick_tag { get; set; }
    }
}
