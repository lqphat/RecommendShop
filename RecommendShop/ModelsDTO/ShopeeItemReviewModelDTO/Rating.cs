using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class Rating
    {
        public long orderid { get; set; }
        public long itemid { get; set; }
        public long cmtid { get; set; }
        public int ctime { get; set; }
        public int rating { get; set; }
        public int userid { get; set; }
        public int shopid { get; set; }
        public string comment { get; set; }
        public int rating_star { get; set; }
        public int status { get; set; }
        public int mtime { get; set; }
        public int editable { get; set; }
        public int opt { get; set; }
        public int filter { get; set; }
        public object mentioned { get; set; }
        public bool is_hidden { get; set; }
        public string author_username { get; set; }
        public string author_portrait { get; set; }
        public int author_shopid { get; set; }
        public bool anonymous { get; set; }
        public List<string> images { get; set; }
        public object videos { get; set; }
        public List<ProductItem> product_items { get; set; }
        public object delete_reason { get; set; }
        public object delete_operator { get; set; }
        public ItemRatingReply ItemRatingReply { get; set; }
        public object tags { get; set; }
        public int editable_date { get; set; }
        public object show_reply { get; set; }
        public object like_count { get; set; }
        public object liked { get; set; }
        public bool sync_to_social { get; set; }
        public object detailed_rating { get; set; }
        public bool exclude_scoring_due_low_logistic { get; set; }
        public object loyalty_info { get; set; }
        public object template_tags { get; set; }
        public bool has_template_tag { get; set; }
        public object sync_to_social_toggle { get; set; }
        public SipInfo sip_info { get; set; }
        public bool is_repeated_purchase { get; set; }
    }
}
