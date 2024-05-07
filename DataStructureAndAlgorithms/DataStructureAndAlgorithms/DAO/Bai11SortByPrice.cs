using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureAndAlgorithms.Enity;

namespace DataStructureAndAlgorithms.DAO
{
    internal class Bai11SortByPrice
    {
        DataBase instance = DataBase.GetIntance();

        public List<Product> SortByPrice(List<Product> products)
        {
            for(int i = 0; i < products.Count - 1; i++)
            {
                for(int j = 0; j < products.Count -i -1; j++)
                {
                    if (instance.GetProductTable()[j].Price > instance.GetProductTable()[j + 1].Price)
                    {
                        int temp = instance.GetProductTable()[j].Price;
                        instance.GetProductTable()[j].Price = instance.GetProductTable()[j + 1].Price;
                        instance.GetProductTable()[j + 1].Price = temp;
                    }
                }
            }
            return products;
        }
    }
}
