using System;

public class DatabaseDemo
{
    public void insertTableTest()
    {
        Database database = new Database();
        Product product = new Product();
        product.setName = "Product";
        database.insertTable(Product , product)
    }
}
