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

        public SKU(string id, int count, int actualPrice, int offerCount, int offerPrice)
        {
            Id = id ?? throw new ArgumentException("Product name is must");
            Count = count;
            ActualPrice = actualPrice;
            OfferCount = offerCount;
            OfferPrice = offerPrice;
        }
    }
}
