using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemReviewModelDTO
{
    public class Timeline
    {
        public string review_created_date { get; set; }
        public string delivery_date { get; set; }
        public string current_date { get; set; }
        public string content { get; set; }
        public string explain { get; set; }
    }
}
