using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.CalculationEngine
{
    interface IPromotionService
    {
        int ApplySinglePromotion(int count, int price);
        int ApplyComboPromotion(int item1Count, int item1Price, int item2Count, int item2Price);
    }
}
