using Entity.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Entity.Demo
{
    internal class DatabaseDemo
    {
        public Database instance = Database.GetInstance();
        public int InsertTableTest()
        {
            BaseRow row = new Product(1, "Product", 1);
            string name = "Product";
            return instance.InsertTable(name, row);
        }

        public List<BaseRow> SelectTableTest()
        {
            string name = "Product";
            BaseRow where = new Product();
            Console.WriteLine("ID la : " + instance.GetProductTable()[0].getId());
            Console.WriteLine("Name la : " + instance.GetProductTable()[0].getName());
            return instance.SelectTable(name);
        }

        public int UpdateTableTest()
        {
            Console.Write("update theo name la 1 , id la 2 :");
            string choseNumber = Console.ReadLine();
            switch (choseNumber)
            {
                case "1":
                    BaseRow rowName = new Product(1, "Product2", 2);
                    string name = "Product";
                    return instance.UpdateTable(name, rowName);
                case "2":
                    BaseRow rowId = new Product(1, "Product3", 2);
                    int id = 1;
                    return instance.UpdateTableById(id, rowId);
                default:
                    return 3;
            }
        }

        public bool DeleteTableTest()
        {
            Console.WriteLine("Name la : " + instance.GetProductTable()[0].getName());
            BaseRow row = new Product();
            string name = "Product";
            return instance.DeleteTable(name, row);
        }

        public void TruncateTableTest()
        {
            string name = "Product";
            instance.TruncateTable(name);
        }

        public void InitDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product(1, "product", 2);
                instance.InsertTable("Product", product);
                Category category = new Category(1, "category");
                instance.InsertTable("Category", category);
                Accesstion accessotion = new Accesstion(1, "accessotion");
                instance.InsertTable("Accesstion", accessotion);
            }
        }
        public void PrintTableTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(instance.GetProductTable()[i].getName());
                Console.WriteLine(instance.GetCatagoryTable()[i].getName());
                Console.WriteLine(instance.GetAccesssoryTable()[i].getName());
            }
        }

        //public static void Main(string[] args)
        //{
        //    DatabaseDemo databaseDemo = new DatabaseDemo();
        //    Console.WriteLine(databaseDemo.InsertTableTest());
        //    Console.WriteLine(databaseDemo.SelectTableTest());
        //    Console.WriteLine(databaseDemo.UpdateTableTest());
        //    Console.WriteLine(databaseDemo.DeleteTableTest());
        //    databaseDemo.TruncateTableTest();
        //    databaseDemo.InitDatabase();
        //    databaseDemo.PrintTableTest();
        //}
    }
}
