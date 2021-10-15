using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class ItemRating
    {
        public int rating_star { get; set; }
        public List<int> rating_count { get; set; }
    }
}
