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
        ProductDAO productDAO = new ProductDAO();
        Product row = new Product(1, "category" , 2);

        void InsertTest()
        {
            productDAO.Insert(row);
        }

        void UpdateTest()
        {
            productDAO.Update(row);
        }

        void FindAllTest()
        {
            productDAO.FindAll(row);
        }
    }
}
