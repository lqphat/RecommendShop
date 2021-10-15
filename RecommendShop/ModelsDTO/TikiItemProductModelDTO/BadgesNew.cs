using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class BadgesNew
    {
        public string placement { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string icon { get; set; }
        public int icon_width { get; set; }
        public int icon_height { get; set; }
        public object text_color { get; set; }
        public object background_color { get; set; }
        public string href { get; set; }
        public string text { get; set; }
    }
}
