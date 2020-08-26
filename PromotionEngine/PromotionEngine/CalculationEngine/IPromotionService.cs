using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.CalculationEngine
{
    interface IPromotionService
    {
        int ApplySinglePromotion(SKU item);
        int ApplyComboPromotion(SKU item1,SKU item2);
    }
}
