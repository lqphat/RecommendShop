using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Image
    {
        public string base_url { get; set; }
        public bool is_gallery { get; set; }
        public object label { get; set; }
        public string large_url { get; set; }
        public string medium_url { get; set; }
        public object position { get; set; }
        public string small_url { get; set; }
        public string thumbnail_url { get; set; }
    }
}
