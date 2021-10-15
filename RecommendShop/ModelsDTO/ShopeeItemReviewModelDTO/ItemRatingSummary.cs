using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class ItemRatingSummary
    {
        public int rating_total { get; set; }
        public List<int> rating_count { get; set; }
        public int rcount_with_context { get; set; }
        public int rcount_with_image { get; set; }
        public int rcount_with_media { get; set; }
        public int rcount_local_review { get; set; }
        public int rcount_repeat_purchase { get; set; }
    }
}
