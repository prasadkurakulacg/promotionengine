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
            throw new NotImplementedException();
        }

        public int ApplySinglePromotion(SKU item)
        {
            return (item.Count / item.OfferCount) * item.OfferPrice + (item.Count % item.OfferCount * item.ActualPrice);
        }
    }
}
