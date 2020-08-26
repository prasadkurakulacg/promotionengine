using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.CalculationEngine
{
    public class PromotionService : IPromotionService
    {
        public int ApplyComboPromotion(SKU item1, SKU item2)
        {
            if (item1.Count == item2.Count)
            {
                return item2.Count * item1.OfferPrice;
            }
            else if (item1.Count > item2.Count)
            {
                return ((item1.Count - item2.Count) * item1.ActualPrice) + item2.Count * item2.ActualPrice;
            }
            else
            {
                return item1.Count * item1.OfferPrice + ((item2.Count - item1.Count) * item2.ActualPrice);
            }
        }

        public int ApplySinglePromotion(SKU item)
        {
            return (item.Count / item.OfferCount) * item.OfferPrice + (item.Count % item.OfferCount * item.ActualPrice);
        }
    }
}
