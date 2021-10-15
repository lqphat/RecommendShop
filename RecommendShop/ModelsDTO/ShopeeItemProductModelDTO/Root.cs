using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class Root
    {
        public Data data { get; set; }
        public object error { get; set; }
        public object error_msg { get; set; }
    }
}
