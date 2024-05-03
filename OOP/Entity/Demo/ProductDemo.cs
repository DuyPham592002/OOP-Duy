using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (product != null) { Console.WriteLine("Product not null ."); }
            Console.WriteLine("Product is null.");
        }
        static void Main(string[] args)
        {
            ProductDemo demo = new ProductDemo();
            demo.PrintProduct(demo.CreateProductTest());
        }
    }
}
