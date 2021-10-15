using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.TikiItemReviewModelDTO
{
    public class Root
    {
        public Stars stars { get; set; }
        public double rating_average { get; set; }
        public int reviews_count { get; set; }
        public ReviewPhoto review_photo { get; set; }
        public List<Datum> data { get; set; }
        public Paging paging { get; set; }
        public List<List<Object>> sort_options { get; set; }
        public bool exclude_image { get; set; }
    }

    public static class RootExt
    {
        public static List<ReviewModel> ToListReviewModel(this List<Datum> req)
        {
            var listReview = new List<ReviewModel>();
            foreach (var item in req)
            {
                var review = new ReviewModel();
                review.Id = item.id.ToString();
                review.Title = item.title;
                review.Content = item.content;
                review.Rank = item.rating;
                review.ProductId = item.product_id.ToString();
                listReview.Add(review);
            }
            return listReview;
        }
    }
}
