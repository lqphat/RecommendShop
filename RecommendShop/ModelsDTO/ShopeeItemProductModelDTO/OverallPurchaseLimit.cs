using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class OverallPurchaseLimit
    {
        public int order_max_purchase_limit { get; set; }
        public object overall_purchase_limit { get; set; }
        public object item_overall_quota { get; set; }
        public object start_date { get; set; }
        public object end_date { get; set; }
    }
}
