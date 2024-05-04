using Entity.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Demo
{
    internal class CategoryDAODemo
    {
        static CategoryDAO categoryDao = new CategoryDAO();
        static Category row = new Category(1 , "category");

        static int InsertTest()
        {
            return categoryDao.Insert(row);
        }

        static int UpdateTest()
        {
           return categoryDao.Update(row);
        }

        static bool DeleteTest()
        {
            return categoryDao.Delete(row);
        }

        static List<BaseRow> FindAllTest()
        {
            return categoryDao.FindAll(row);           
        }

        static BaseRow FindByIdTest()
        {
            return categoryDao.FindById(1);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(InsertTest());
            Console.WriteLine(UpdateTest());
            Console.WriteLine(DeleteTest());
            Console.WriteLine(FindAllTest());
            Console.WriteLine(FindByIdTest());
        }
    }
}
