using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class Category
    {
        public int catid { get; set; }
        public string display_name { get; set; }
        public bool no_sub { get; set; }
        public bool is_default_subcat { get; set; }
    }
}
