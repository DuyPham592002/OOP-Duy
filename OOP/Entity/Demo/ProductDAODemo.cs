using Entity.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Demo
{
    internal class ProductDAODemo
    {
        static ProductDAO productDAO = new ProductDAO();
        static Product row = new Product(1, "Product" , 2);

        static int InsertTest()
        {
            return productDAO.Insert(row);
        }

        static int UpdateTest()
        {
            return productDAO.Update(row);
        }

        static bool DeleteTest()
        {
            return productDAO.Delete(row);
        }

        static List<BaseRow> FindAllTest()
        {
            return productDAO.FindAll(row);
        }

        static BaseRow FindByIdTest()
        {
            return productDAO.FindById(1);
        }

        static BaseRow FindByNameTest()
        {
            return productDAO.FindByName("Product");
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(InsertTest());
        //    Console.WriteLine(UpdateTest());
        //    Console.WriteLine(DeleteTest());
        //    Console.WriteLine(FindAllTest());
        //    Console.WriteLine(FindByIdTest());
        //    Console.WriteLine(FindByNameTest());
        //}
    }
}
