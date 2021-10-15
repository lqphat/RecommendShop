using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Rank
    {
        public int category_id { get; set; }
        public string name { get; set; }
        public DateTime period { get; set; }
        public int rank { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
