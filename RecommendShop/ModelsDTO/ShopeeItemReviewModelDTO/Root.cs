using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendShop.ModelsDTO.ShopeeItemReviewModelDTO
{
    public class Root
    {
        public Data data { get; set; }
        public int error { get; set; }
        public object error_msg { get; set; }
    }

    public static class RootExt
    {
        public static List<ReviewModel> ToReviewModel(this List<Rating> req) 
        {
            var listReview = new List<ReviewModel>();
            //foreach (var item in req)
            //{
            //    var review = new ReviewModel();
            //    review.Id = item.cmtid.ToString();
            //    review.Content = item.comment;
            //    review.Rank = item.rating_star;
            //    switch (item.rating_star)
            //    {
            //        case 5:
            //            review.Title = "Cực kì hài lòng";
            //            break;
            //        case 4:
            //            review.Title = "Hài lòng";
            //            break;
            //        case 3:
            //            review.Title = "Bình thường";
            //            break;
            //        case 2:
            //            review.Title = "Không hài lòng";
            //            break;
            //        case 1:
            //            review.Title = "Rất tệ";
            //            break;
            //        default:
            //            break;
            //    }
            //    review.ProductId = item.itemid.ToString();
            //    listReview.Add(review); 
            //}
            return listReview;
        }
    }
}
