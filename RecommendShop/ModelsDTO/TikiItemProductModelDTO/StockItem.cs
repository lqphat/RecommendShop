using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class StockItem
    {
        public int max_sale_qty { get; set; }
        public int min_sale_qty { get; set; }
        public object preorder_date { get; set; }
        public int qty { get; set; }
    }
}
