using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class ItemRating
    {
        public double rating_star { get; set; }
        public List<double> rating_count { get; set; }
    }
}
