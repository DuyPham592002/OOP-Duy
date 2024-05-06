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

        public  int UpdateTest()
        {
            return categoryDao.Update(row);
        }

        public bool DeleteTest()
        {
            return categoryDao.Delete(row);
        }

        public List<BaseRow> FindAllTest()
        {
            Console.WriteLine("ten la " + instance.GetCatagoryTable()[0].getName());
            return categoryDao.FindAll(row);
        }

        public BaseRow FindByIdTest()
        {
            return categoryDao.FindById( 1 , row);
        }

        //public static void Main(string[] args)
        //{
        //    CategoryDAODemo categoryDAODemo = new CategoryDAODemo();
        //    Console.WriteLine(categoryDAODemo.InsertTest());
        //    Console.WriteLine(categoryDAODemo.UpdateTest());
        //    //Console.WriteLine(categoryDAODemo.DeleteTest());
        //    Console.WriteLine(categoryDAODemo.FindAllTest());
        //    Console.WriteLine(categoryDAODemo.FindByIdTest());
        //}
    }
}
