using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class Data
    {
        public List<Rating> ratings { get; set; }
        public ItemRatingSummary item_rating_summary { get; set; }
        public bool is_sip_item { get; set; }
        public string rcmd_algo { get; set; }
    }
}
