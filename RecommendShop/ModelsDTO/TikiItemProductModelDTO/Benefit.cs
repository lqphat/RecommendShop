using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Benefit
    {
        public string icon { get; set; }
        public string text { get; set; }
        public string extra_text { get; set; }
        public string extra_header { get; set; }
        public List<Extra> extra { get; set; }
    }
}
