using PromotionEngine.CalculationEngine;
using PromotionEngine.Models;
using System;
using Xunit;

namespace PromotionEngine.Tests
{
    public class PromotionServiceTests
    {
        [Fact(DisplayName = "PromotionService SinglePromotion Returns Promotion Price on promotion SKU")]
        public void PromotionService_SinglePromotion_Returns_Promotion_Price_On_Promotion_SKU()
        {
            // Arrange
            var item = new SKU("A", 3, 50, 3, 130);
            // Acct
            var promotionService = new PromotionService();
            var value = promotionService.ApplySinglePromotion(item);

            // Assert
            value.Equals(130);
        }

        [Fact(DisplayName = "PromotionService SinglePromotion Returns Promotion Price On NonPromotion SKU")]
        public void PromotionService_SinglePromotion_Returns_Normal_Price_On_Nonpromotion_SKU()
        {
            // Arrange
            var item = new SKU("A", 2, 50, 3, 130);
            // Act
            var promotionService = new PromotionService();
            var value = promotionService.ApplySinglePromotion(item);

            // Assert
            value.Equals(100);
        }

        [Fact(DisplayName = "PromotionService SinglePromotion Returns Combined Price On NonPromotion And Promotion SKU")]
        public void PromotionService_SinglePromotion_Returns_Combined_Price_On_Nonpromotion_And_Promotion_SKU()
        {
            // Arrange
            var item = new SKU("A", 2, 50, 3, 130);
            // Act
            var promotionService = new PromotionService();
            var value = promotionService.ApplySinglePromotion(item);

            // Assert
            value.Equals(100);
        }

        [Fact(DisplayName = "PromotionService ComboPromotion Returns Promotion Price On Promotion SKU")]
        public void PromotionService_ComboPromotion_Returns_Promotion_Price_On_Promotion_SKU()
        {
            // Arrange
            var item1 = new SKU("D", 1, 15, 1, 30);
            var item2 = new SKU("C", 1, 20, 1, 30);

            // Act
            var promotionService = new PromotionService();
            var value = promotionService.ApplyComboPromotion(item1,item2);

            // Assert
            value.Equals(30);
        }

        [Fact(DisplayName = "Adding Empty SKU Name Throws ArgumentException")]
        public void Adding_Empty_SKU_Name_Throws_ArgumentException()
        {
            // Act
            var ex = Assert.Throws<ArgumentException>(()=> new SKU(null, 1, 15, 1, 30));

            // Assert
            Assert.Equal("Product name is must",ex.Message);
        }
    }
}
