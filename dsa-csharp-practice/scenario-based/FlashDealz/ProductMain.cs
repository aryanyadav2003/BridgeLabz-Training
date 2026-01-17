//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Text;

//namespace ProductDiscountSort.FlashDealz
//{
//    internal class ProductMain
//    {
//        static void Main(string[] args)
//        {
//            int size = 1000;
//            Product[] products = new Product[size];
//            Random random = new Random();
//            for(int i = 0; i < size; i++)
//            {
//                int discount = random.Next(5, 41);
//                products[i] = new Product("Product " + (i + 1), discount);
//            }
//            Console.WriteLine("Sorting products by highest discount...");
//            QuickSortProduct.QuickSort(products, 0, products.Length - 1);
//            Console.WriteLine("Top 20 discounted products :");
//            for(int i = 0; i < 20; i++)
//            {
//                Console.WriteLine(products[i].Name + ":" + products[i].Discount + "%OFF");
//            }
//        }
//    }
//}
