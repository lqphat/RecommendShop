using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class TierVariation
    {
        public string name { get; set; }
        public List<string> options { get; set; }
        public List<string> images { get; set; }
        public object properties { get; set; }
        public int type { get; set; }
    }
}
