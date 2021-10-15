using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Categories
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_leaf { get; set; }
    }
}
