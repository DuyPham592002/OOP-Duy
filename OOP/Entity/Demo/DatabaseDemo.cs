using Entity.DAO.DAO;
using System;
using System.Collections.Generic;

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
            return instance.SelectTable(name);
        }

        public int UpdateTableTest()
        {
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
            BaseRow row = new Product(1,"product",1);
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
        //    Database instance = Database.GetInstance();
        //    DatabaseDemo databaseDemo = new DatabaseDemo();
        //    databaseDemo.InsertTableTest();
        //    Console.WriteLine("Ten va id sau khi nhap : " + instance.GetProductTable()[0].getName() + instance.GetProductTable()[0].getId());
        //    Console.WriteLine("tra về mang theo tên : " + databaseDemo.SelectTableTest());
        //    Console.Write("update theo name la 1 , id la 2 :");
        //    Console.WriteLine(databaseDemo.UpdateTableTest());
        //    Console.WriteLine("Name sau update la : " + instance.GetProductTable()[0].getName());
        //    Console.WriteLine("da delete chua :" + databaseDemo.DeleteTableTest());
        //    //databaseDemo.TruncateTableTest();
        //    //Console.WriteLine(instance.GetProductTable()[0].getName());
        //    databaseDemo.InitDatabase();
        //    Console.WriteLine("danh sach : ");
        //    databaseDemo.PrintTableTest();
        //}
    }
}
