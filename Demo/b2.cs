namespace demo

public class ProductDemo
{
    public Product CreateProductTest()
    {
        Product product = new Product();
        product.SetId(1);
        product.SetName("Test Product");
        product.SetCategoryId(100);
        return product;
    }
    public void PrintProduct(Product product)
    {
        if (product != null) { Console.WriteLine("Product not null ."); }
        Console.WriteLine("Product is null.");
    }
}
}

