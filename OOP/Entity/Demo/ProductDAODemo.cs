using Entity.DAO;
using Entity.DAO.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Demo
{
    internal class ProductDAODemo
    {
        public Database instance = Database.GetInstance();
        static ProductDAO productDao = new ProductDAO();
        static Product row = new Product(1, "product" , 1);

        public int InsertTest()
        {
            return productDao.Insert(row);
        }

        public int UpdateTest()
        {
            Product row = new Product(1, "product2", 1);
            return productDao.Update(row);
        }

        public bool DeleteTest()
        {
            return productDao.Delete(row);
        }

        public List<BaseRow> FindAllTest()
        {
            return productDao.FindAll(row);
        }

        public BaseRow FindByIdTest()
        {
            return productDao.FindById(1, row);
        }

        public BaseRow FindByNameTest(string name)
        {
            return productDao.FindById(1, row);
        }

        //public static void Main(string[] args)
        //{
        //    Database instance = Database.GetInstance();
        //    ProductDAODemo productDAODemo = new ProductDAODemo();
        //    productDAODemo.InsertTest();
        //    Console.WriteLine("Ten va id sau khi nhap : " + instance.GetProductTable()[0].getName() +" "+ instance.GetProductTable()[0].getId());
        //    productDAODemo.UpdateTest();
        //    Console.WriteLine("Ten sau update : " + instance.GetProductTable()[0].getName());
        //    //Console.WriteLine(productDAODemo.DeleteTest());
        //    Console.WriteLine("tra ve mang : " + productDAODemo.FindAllTest());
        //    Console.WriteLine("Ten object sau khi find by id : " + productDAODemo.FindByIdTest().getName());
        //    Console.WriteLine("id object sau khi find by name : " + productDAODemo.FindByNameTest("produect2").getId());

        //}
    }
}
