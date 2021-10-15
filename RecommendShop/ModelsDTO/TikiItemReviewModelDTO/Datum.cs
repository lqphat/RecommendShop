using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemReviewModelDTO
{
    public class Datum
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string status { get; set; }
        public int thank_count { get; set; }
        public double score { get; set; }
        public double new_score { get; set; }
        public int customer_id { get; set; }
        public int comment_count { get; set; }
        public int rating { get; set; }
        public List<object> images { get; set; }
        public bool thanked { get; set; }
        public int created_at { get; set; }
        public CreatedBy created_by { get; set; }
        public List<object> suggestions { get; set; }
        public List<string> attributes { get; set; }
        public List<object> product_attributes { get; set; }
        public int spid { get; set; }
        public bool is_photo { get; set; }
        public Seller seller { get; set; }
        public int product_id { get; set; }
        public Timeline timeline { get; set; }
    }
}
