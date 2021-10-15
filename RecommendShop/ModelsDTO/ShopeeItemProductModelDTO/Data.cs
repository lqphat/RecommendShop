using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemProductModelDTO
{
    public class Data
    {
        public long itemid { get; set; }
        public int shopid { get; set; }
        public int userid { get; set; }
        public long price_max_before_discount { get; set; }
        public bool has_lowest_price_guarantee { get; set; }
        public long price_before_discount { get; set; }
        public long price_min_before_discount { get; set; }
        public object exclusive_price_info { get; set; }
        public object hidden_price_display { get; set; }
        public long price_min { get; set; }
        public long price_max { get; set; }
        public long price { get; set; }
        public int stock { get; set; }
        public string discount { get; set; }
        public int historical_sold { get; set; }
        public int sold { get; set; }
        public int show_discount { get; set; }
        public int raw_discount { get; set; }
        public int min_purchase_limit { get; set; }
        public OverallPurchaseLimit overall_purchase_limit { get; set; }
        public object pack_size { get; set; }
        public object is_live_streaming_price { get; set; }
        public string name { get; set; }
        public int ctime { get; set; }
        public string item_status { get; set; }
        public int status { get; set; }
        public int condition { get; set; }
        public int catid { get; set; }
        public string description { get; set; }
        public bool is_mart { get; set; }
        public bool show_shopee_verified_label { get; set; }
        public object size_chart { get; set; }
        public string reference_item_id { get; set; }
        public object brand { get; set; }
        public ItemRating item_rating { get; set; }
        public List<int> label_ids { get; set; }
        public List<Attribute> attributes { get; set; }
        public bool liked { get; set; }
        public int liked_count { get; set; }
        public int cmt_count { get; set; }
        public int flag { get; set; }
        public bool shopee_verified { get; set; }
        public bool is_adult { get; set; }
        public bool is_preferred_plus_seller { get; set; }
        public List<TierVariation> tier_variations { get; set; }
        public int bundle_deal_id { get; set; }
        public bool can_use_bundle_deal { get; set; }
        public AddOnDealInfo add_on_deal_info { get; set; }
        public object bundle_deal_info { get; set; }
        public bool can_use_wholesale { get; set; }
        public List<object> wholesale_tier_list { get; set; }
        public object is_group_buy_item { get; set; }
        public object group_buy_info { get; set; }
        public int welcome_package_type { get; set; }
        public object welcome_package_info { get; set; }
        public List<string> images { get; set; }
        public string image { get; set; }
        public object video_info_list { get; set; }
        public int item_type { get; set; }
        public bool is_official_shop { get; set; }
        public bool show_official_shop_label_in_title { get; set; }
        public string shop_location { get; set; }
        public object coin_earn_label { get; set; }
        public int cb_option { get; set; }
        public bool is_pre_order { get; set; }
        public int estimated_days { get; set; }
        public int badge_icon_type { get; set; }
        public bool show_free_shipping { get; set; }
        public int shipping_icon_type { get; set; }
        public int cod_flag { get; set; }
        public bool show_original_guarantee { get; set; }
        public List<Category> categories { get; set; }
        public int other_stock { get; set; }
        public bool item_has_post { get; set; }
        public int discount_stock { get; set; }
        public bool current_promotion_has_reserve_stock { get; set; }
        public int current_promotion_reserved_stock { get; set; }
        public int normal_stock { get; set; }
        public int brand_id { get; set; }
        public bool is_alcohol_product { get; set; }
        public bool show_recycling_info { get; set; }
        public CoinInfo coin_info { get; set; }
        public List<Model> models { get; set; }
        public object spl_info { get; set; }
        public object preview_info { get; set; }
        public List<FeCategory> fe_categories { get; set; }
        public object presale_info { get; set; }
        public bool is_cc_installment_payment_eligible { get; set; }
        public bool is_non_cc_installment_payment_eligible { get; set; }
        public object flash_sale { get; set; }
        public object upcoming_flash_sale { get; set; }
        public object deep_discount { get; set; }
        public bool has_low_fulfillment_rate { get; set; }
        public bool is_partial_fulfilled { get; set; }
        public object makeups { get; set; }
        public object shop_vouchers { get; set; }
    }
}
