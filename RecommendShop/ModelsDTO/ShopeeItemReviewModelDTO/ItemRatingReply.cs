using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class ItemRatingReply
    {
        public long orderid { get; set; }
        public object itemid { get; set; }
        public long cmtid { get; set; }
        public int ctime { get; set; }
        public object rating { get; set; }
        public int userid { get; set; }
        public object shopid { get; set; }
        public string comment { get; set; }
        public object rating_star { get; set; }
        public object status { get; set; }
        public int mtime { get; set; }
        public object editable { get; set; }
        public object opt { get; set; }
        public object filter { get; set; }
        public object mentioned { get; set; }
        public bool is_hidden { get; set; }
    }
}
