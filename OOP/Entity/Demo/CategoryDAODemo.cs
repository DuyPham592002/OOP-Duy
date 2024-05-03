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
        CategoryDAO categoryDao = new CategoryDAO();
        Category row = new Category(1 , "category");

        void InsertTest()
        {
            categoryDao.Insert(row);
        }

        void UpdateTest()
        {
            categoryDao.Update(row);
        }

        void FindAllTest()
        {
            categoryDao.FindAll(row);
        }
    }
}
