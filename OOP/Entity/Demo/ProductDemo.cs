using System;

namespace Entity.Demo
{
    internal class ProductDemo
    {
        public Product CreateProductTest()
        {
            Product product = new Product();
            product.setId(1);
            product.setName("Test Product");
            product.setCategoryId(100);
            return product;
        }
        public void PrintProduct(Product product)
        {
            if (product != null)
            {
                Console.WriteLine("Product not null .");
                return;
            }
            Console.WriteLine("Product is null.");
        }

        //public static void Main(string[] args)
        //{
        //    ProductDemo demo = new ProductDemo();
        //    demo.PrintProduct(demo.CreateProductTest());
        //}
    }
}
