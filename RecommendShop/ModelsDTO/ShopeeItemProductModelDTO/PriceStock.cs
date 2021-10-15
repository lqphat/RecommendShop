using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class PriceStock
    {
        public int? allocated_stock { get; set; }
        public object stock_breakdown_by_location { get; set; }
    }
}
