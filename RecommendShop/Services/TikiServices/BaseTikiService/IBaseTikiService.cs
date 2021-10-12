using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Services.TikiServices.BaseTikiService
{
    public interface IBaseTikiService
    {
        public Task<IRestResponse> Get(string path);
    }
}
