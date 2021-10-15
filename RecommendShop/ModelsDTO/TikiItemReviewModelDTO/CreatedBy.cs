using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemReviewModelDTO
{
    public class CreatedBy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public object region { get; set; }
        public string avatar_url { get; set; }
        public string created_time { get; set; }
        public bool purchased { get; set; }
        public int purchased_at { get; set; }
    }
}
