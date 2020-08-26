using PromotionEngine.CalculationEngine;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        public static void Main(string[] args)
        {
            var promotionService = new PromotionService();
            var cartValue = 0;
            cartValue += promotionService.ApplySinglePromotion(new SKU(null, 3, 50, 3, 130));
            cartValue += promotionService.ApplySinglePromotion(new SKU("B", 5, 30, 2, 45));
            cartValue += promotionService.ApplyComboPromotion(new SKU("C", 1, 20, 1, 30), new SKU("D", 1, 15, 1, 30));
            Console.WriteLine(cartValue);
            Console.ReadLine();
        }
    }
}
