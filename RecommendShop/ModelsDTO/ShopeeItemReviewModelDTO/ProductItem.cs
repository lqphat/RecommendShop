using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class ProductItem
    {
        public long itemid { get; set; }
        public int shopid { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int is_snapshot { get; set; }
        public long snapshotid { get; set; }
        public long modelid { get; set; }
        public string model_name { get; set; }
    }
}
