using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static Dictionary<string, int> cart = new Dictionary<string, int>();
        public static void Main(string[] args)
        {
            Console.WriteLine("total number of items");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the type of product:A,B,C or D along with quantity Example: 3*A");
            for (int i = 0; i < a; i++)
            {
                string input = Console.ReadLine();
                SKU product = new SKU(input);
                if (cart.ContainsKey(product.Id))
                    cart[product.Id] += product.Count;
                else
                    cart.Add(product.Id, product.Count);
            }
            var cartItems = (from item in cart select new SKU(item.Key, item.Value)).ToList();
            Console.ReadLine();
        }
    }
}
