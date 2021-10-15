using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class CoinInfo
    {
        public int spend_cash_unit { get; set; }
        public List<object> coin_earn_items { get; set; }
    }
}
