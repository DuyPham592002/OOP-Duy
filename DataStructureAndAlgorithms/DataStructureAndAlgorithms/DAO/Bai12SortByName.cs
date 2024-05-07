using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.DAO
{
    internal class Bai12SortByName
    {
        DataBase instance = DataBase.GetIntance();

        public List<Product> SortByName(List<Product> products)
        {
            for (int i = 1; i< products.Count; i++)
            {
                Product product = products[i];
                int key = instance.GetProductTable()[i].Name.Length;
                int j = i -1;

                while (j >= 0 && products[j].Name.Length < key) 
                {
                    products[j+1] = products[j];
                    j--;
                }

                products[j + 1] = product;
            }

            return products;
        }
    }
}
