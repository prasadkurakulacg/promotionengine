using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.CalculationEngine
{
    public interface ICalculationService<T> where T : List<SKU>
    {
        int CalculateCart();
    }
}