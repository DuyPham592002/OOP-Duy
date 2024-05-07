using Entity.DAO;
using Entity.DAO.DAO;
using System;
using System.Collections.Generic;

namespace Entity.Demo
{
    internal class CategoryDAODemo
    {
        public Database instance = Database.GetInstance();
        static CategoryDAO categoryDao = new CategoryDAO();
        static Category row = new Category(1, "category");

        public int InsertTest()
        {
            return categoryDao.Insert(row);
        }

        public int UpdateTest()
        {
            Category row = new Category(1, "category2");
            return categoryDao.Update(row);
        }

        public bool DeleteTest()
        {
            return categoryDao.Delete(row);
        }

        public List<BaseRow> FindAllTest()
        {
            return categoryDao.FindAll(row);
        }

        public BaseRow FindByIdTest()
        {
            return categoryDao.FindById(1, row);
        }

        public static void Main(string[] args)
        {
            Database instance = Database.GetInstance();
            CategoryDAODemo categoryDAODemo = new CategoryDAODemo();
            categoryDAODemo.InsertTest();
            Console.WriteLine("Ten va id sau khi nhap : " + instance.GetCatagoryTable()[0].getName() + instance.GetCatagoryTable()[0].getId());
            categoryDAODemo.UpdateTest();
            Console.WriteLine("Ten sau update : " + instance.GetCatagoryTable()[0].getName());
            //Console.WriteLine(categoryDAODemo.DeleteTest());
            Console.WriteLine("tra ve mang : " + categoryDAODemo.FindAllTest());
            Console.WriteLine("tra ve object : " + categoryDAODemo.FindByIdTest());
            Console.WriteLine("Ten object sau khi find by id : " + categoryDAODemo.FindByIdTest().getName());
        }
    }
}
