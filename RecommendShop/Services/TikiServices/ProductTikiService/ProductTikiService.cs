using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RecommendShop.Models;
using RecommendShop.ModelsDTO;
using RecommendShop.Services.TikiServices.BaseTikiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Services.TikiServices.ProductTiKiService
{
    public class ProductTikiService : IProductTikiService
    {
        private string _apiName;
        private string _path;
        private readonly IBaseTikiService _baseTikiService;

        public ProductTikiService(IBaseTikiService baseTikiService)
        {
            _baseTikiService = baseTikiService;
            _apiName = "products";
        }

        public async Task<ProductModel> Get(int apiProductId, int? apiSpId)
        {
            _path = $"{_apiName}/{apiProductId}?platform=web&spid={apiSpId}";

            var respone = await _baseTikiService.Get(_path);

            var dataDTO = JsonConvert.DeserializeObject<ProductModelDTO>(respone.Content);

            return null;
        }




    }
}
