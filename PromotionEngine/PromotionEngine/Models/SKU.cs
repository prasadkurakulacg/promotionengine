using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class SKU
    {
        public string Id { get; set; }
        public int Count { get; set; }

        public int ActualPrice { get; set; }
        public int OfferPrice { get; set; }
        public int OfferCount { get; set; }


        public SKU(string input)
        {
            var itemDetails = input.Split('*');
            Id = itemDetails[1];
            Count = Convert.ToInt32(itemDetails[0]);
        }

        public SKU(Tuple<string, int> input)
        {
            Id = input.Item1;
            Count = input.Item2;
        }

        public SKU(string productId, int count)
        {
            Id = productId;
            Count = count;
        }

        public SKU(string id,int count,int actualPrice,int offerCount,int offerPrice)
        {
            Id = id;
            Count = count;
            ActualPrice = actualPrice;
            OfferCount = offerCount;
            OfferPrice = offerPrice;
        }
    }
}
