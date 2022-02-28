using System;

namespace SecondDayHomework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.ProductPrice = 10000;
            product1.ProductQuantity = "300";
            product1.ProductDiscount = 15;

            Product product2 = new Product();
            product2.ProductName = "TV";
            product2.ProductPrice = 4000;
            product2.ProductQuantity = "500";
            product2.ProductDiscount = 8;

            Product product3 = new Product();
            product3.ProductName = "Telefon";
            product3.ProductPrice = 7000;
            product3.ProductQuantity = "150";
            product3.ProductDiscount = 30;
                        
            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductPrice + " " + product.ProductQuantity + " " + product.ProductDiscount);
            }

        }                  

    }
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public int ProductDiscount { get; set; }
    }
}
