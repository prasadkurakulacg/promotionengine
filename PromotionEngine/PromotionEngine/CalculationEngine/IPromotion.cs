using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.CalculationEngine
{
    interface IPromotion<T> where T : List<SKU>
    {
        int ApplyPromotion();
    }
}
