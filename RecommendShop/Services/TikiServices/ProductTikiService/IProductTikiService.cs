using RecommendShop.Models;
using RecommendShop.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Services.TikiServices.ProductTiKiService
{
    public interface IProductTikiService
    {
        public Task<ProductModel> Get(int apiProductId, int? apiSpId);

    }
}
