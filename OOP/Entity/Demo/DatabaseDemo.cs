using Entity.DAO;
using Entity.DAO.DAO;
using System;
using System.Collections.Generic;

namespace Entity.Demo
{
    internal class DatabaseDemo
    {
        public static Database database = new Database();
        public static int insertTableTest()
        {
            BaseRow row = new Product();
            string name = "Product";
            return database.InsertTable(name, row);
        }

        public static List<BaseRow> selectTableTest()
        {
            string name = "Product";
            BaseRow where = new Product();
            return database.SelectTable(name, where);
        }

        public static int UpdateTableTest()
        {
            BaseRow row = new Product();
            string name = "Product";
            int id = 1;
            database.UpdateTableById(id, row);
            return database.UpdateTable(name, row);
        }

        public static bool DeleteTableTest()
        {
            BaseRow row = new Product();
            string name = "Product";
            return database.DeleteTable(name, row);
        }

        public static void TruncateTableTest()
        {
            string name = "Product";
            database.TruncateTable(name);
        }

        public static void initDatabase()
        {
            for (int i = 1; i <= 10; i++)
            {
                Product product = new Product(1, "product", 2);
                database.productTable.Add(product);
                Category category = new Category(1, "category");
                database.catagoryTable.Add(category);
                Accesstion accessotion = new Accesstion(1, "accessotion");
                database.accesssoryTable.Add(accessotion);
            }
        }
        public static void PrintTableTest()
        {
            foreach (object row in database.productTable)
            {
                Console.WriteLine(row);
            }
            foreach (object row in database.catagoryTable)
            {
                Console.WriteLine(row);
            }
            foreach (object row in database.accesssoryTable)
            {
                Console.WriteLine(row);
            }
        }

        public static void insertTest()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            Category row = new Category();
            categoryDAO.Insert(row);
            Console.WriteLine(123);
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(insertTableTest());
        //    Console.WriteLine(selectTableTest());
        //    Console.WriteLine(UpdateTableTest());
        //    Console.WriteLine(DeleteTableTest());
        //    TruncateTableTest();
        //    initDatabase();
        //    PrintTableTest();
        //    insertTest();
        //}
    }
}
