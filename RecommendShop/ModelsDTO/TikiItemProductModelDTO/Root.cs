using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemProductModelDTO
{
    public class Root
    {
        public int id { get; set; }
        public int master_id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public string url_key { get; set; }
        public string url_path { get; set; }
        public string type { get; set; }
        public object book_cover { get; set; }
        public string short_description { get; set; }
        public int price { get; set; }
        public int list_price { get; set; }
        public int original_price { get; set; }
        public List<Badge> badges { get; set; }
        public List<BadgesNew> badges_new { get; set; }
        public int discount { get; set; }
        public int discount_rate { get; set; }
        public double rating_average { get; set; }
        public int review_count { get; set; }
        public string review_text { get; set; }
        public int favourite_count { get; set; }
        public string thumbnail_url { get; set; }
        public bool has_ebook { get; set; }
        public string inventory_status { get; set; }
        public string inventory_type { get; set; }
        public string productset_group_name { get; set; }
        public bool is_fresh { get; set; }
        public object seller { get; set; }
        public bool is_flower { get; set; }
        public bool is_gift_card { get; set; }
        public object salable_type { get; set; }
        public int data_version { get; set; }
        public int day_ago_created { get; set; }
        public int all_time_quantity_sold { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string meta_keywords { get; set; }
        public bool is_baby_milk { get; set; }
        public bool is_acoholic_drink { get; set; }
        public string description { get; set; }
        public List<Image> images { get; set; }
        public object warranty_policy { get; set; }
        public Brand brand { get; set; }
        public CurrentSeller current_seller { get; set; }
        public List<OtherSeller> other_sellers { get; set; }
        public List<SellerSpecification> seller_specifications { get; set; }
        public List<Specification> specifications { get; set; }
        public PriceComparison price_comparison { get; set; }
        public List<object> product_links { get; set; }
        public List<object> services_and_promotions { get; set; }
        public List<object> promitions { get; set; }
        public StockItem stock_item { get; set; }
        public QuantitySold quantity_sold { get; set; }
        public Categories categories { get; set; }
        public List<Breadcrumb> breadcrumbs { get; set; }
        public object installment_info { get; set; }
        public bool is_seller_in_chat_whitelist { get; set; }
        public Inventory inventory { get; set; }
        public List<WarrantyInfo> warranty_info { get; set; }
        public string return_and_exchange_policy { get; set; }
        public DealSpecs deal_specs { get; set; }
        public List<Benefit> benefits { get; set; }
    }

    public static class RootExt
    {
        public static ProductModel ToProductModel(this Root req)
        {
            return new ProductModel()
            {
                Id = req.id.ToString(),
                Name = req.name,
                BrandName = req.brand.name,
                Description = req.description,
                ImageMainUrl = req.thumbnail_url,
                PriceCurrent = req.price.ToString(),
                PriceOld = req.original_price.ToString(),
                CategoryId = req.categories.id.ToString(),
                Rating = req.rating_average,
            };
        }

        public static List<CategoryModel> ToListCategoryModel(this List<Breadcrumb> req)
        {
            var listCate = new List<CategoryModel>();
            for (int i = 0; i < req.Count; i++)
            {
                var category = new CategoryModel();
                category.Id = req[i].category_id.ToString();
                category.Name = req[i].name;
                category.Level = i;
                category.ParentId = i == 0 ? null : req[i - 1].category_id.ToString();

                if (req[i].category_id != 0)
                {
                    listCate.Add(category);
                }
            }
            return listCate;

        }
    }
}
