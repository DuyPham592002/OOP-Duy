using Entity.DAO;
using Entity.DAO.DAO;
using System;
using System.Collections.Generic;

namespace Entity.Demo
{
    internal class DatabaseDemo
    {
        Database database = new Database();
        void insertTableTest()
        {
            object row = new object();
            string name = "product";
            database.InsertTable(name, row);
        }

        List<object> selectTableTest()
        {
            string name = "product";
            object where = new object();
            return database.SelectTable(name, where);
        }

        public void UpdateTableTest()
        {
            object row = new object();
            string name = "product";
            database.UpdateTable(name, row);
        }

        public void DeleteTableTest()
        {
            object row = new object();
            string name = "product";
            database.DeleteTable(name, row);
        }

        public void TruncateTableTest()
        {
            string name = "product";
            database.TruncateTable(name);
        }

        public void UpdateTableByIdTest()
        {
            Product product = new Product();
            int id = 1;
            database.UpdateTableById(id, product);
        }

        void initDatabase()
        {
            for (int i = 1; i <= 10; i++)
            {
                Database database = new Database();

                Product product = new Product(1, "product", 2);
                database.productTable.Add(product);
                Category category = new Category(1, "category");
                database.catagoryTable.Add(category);
                Accesstion accessotion = new Accesstion(1, "accessotion");
                database.accesssoryTable.Add(accessotion);
            }
        }
        void PrintTableTest()
        {
            Database database = new Database();
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

        public void insertTest()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            Category row = new Category();
            categoryDAO.Insert(row);
        }
    }
}
