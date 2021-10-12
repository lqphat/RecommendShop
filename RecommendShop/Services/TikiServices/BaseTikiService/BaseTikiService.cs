using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.Services.TikiServices.BaseTikiService
{
    public class BaseTikiService : IBaseTikiService
    {
        private string _baseApi;

        public BaseTikiService()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var baseApi = configuration.GetSection("BaseTikiApi").Value;

            _baseApi = baseApi;
        }
        public async Task<IRestResponse> Get(string path)
        {
            var client = new RestClient(_baseApi + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
