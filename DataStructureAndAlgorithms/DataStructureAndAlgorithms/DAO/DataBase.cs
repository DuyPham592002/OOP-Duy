using DataStructureAndAlgorithms.Enity;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms
{
    internal class DataBase
    {
        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private static DataBase intance;

        public static DataBase GetIntance()
        {
            if(intance == null)
            {
                intance = new DataBase();
            }
            return intance;
        }

        public List<Product> GetProductTable()
        {
            return productTable;
        }

        public List<Category> GetCategoryTable()
        {
            return categoryTable;
        }

        public void InsertTableProduct()
        {
            productTable.Add(new Product("CPU", 750, 10, 1));
            productTable.Add(new Product("RAM", 50, 2, 2));
            productTable.Add(new Product("HHD", 70, 1, 2));
            productTable.Add(new Product("Main", 400, 3, 1));
            productTable.Add(new Product("Keybroad", 30, 8, 4));
            productTable.Add(new Product("Mouse", 25, 50, 4));
            productTable.Add(new Product("VGA", 60, 35, 3));
            productTable.Add(new Product("Monitor", 120, 28, 2));
            productTable.Add(new Product("Case", 120, 28, 5));
        } 

        public void InsertCategory()
        {
            categoryTable[0] = new Category(1, "Computer");
            categoryTable[1] = new Category(2, "Memory");
            categoryTable[2] = new Category(3, "Card");
            categoryTable[3] = new Category(4, "Acsesory");
        }
    }
}
