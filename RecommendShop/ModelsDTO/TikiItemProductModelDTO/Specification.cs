using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Specification
    {
        public string name { get; set; }
        public List<Attribute> attributes { get; set; }
    }

    public static class SpecificationExt
    {
        public static List<Models.AttributeModel> ToModelConfiguration(this Root req)
        {
            var listConfiguration = new List<Models.AttributeModel>();
            var attributes = req.specifications[0].attributes;
            foreach (var item in attributes)
            {
                var attribute = new Models.AttributeModel();
                attribute.id = item.code;
                attribute.name = item.name;
                attribute.value = item.value;
                attribute.ProductId = req.id.ToString();
                listConfiguration.Add(attribute);
            }
            return listConfiguration;
        }
    }
}
