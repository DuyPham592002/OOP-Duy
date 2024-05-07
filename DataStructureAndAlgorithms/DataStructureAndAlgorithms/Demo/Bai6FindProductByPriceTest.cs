using DataStructureAndAlgorithms.DAO;
using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Demo
{
    internal class Bai6FindProductByPriceTest
    {
        Bai6FindProductByPrice Bai6FindProductByPrice = new Bai6FindProductByPrice();
        DataBase instance = DataBase.GetIntance();

        void InsertTableTest()
        {
            instance.InsertTableProduct();
        }

        List<Product> FindProductByPriceTest()
        {
            return Bai6FindProductByPrice.FindProductByPrice(instance.GetProductTable(), 100);
        }

        //static void Main(string[] args)
        //{
        //    Bai6FindProductByPriceTest bai6FindProductByPriceTest = new Bai6FindProductByPriceTest();
        //    DataBase instance = DataBase.GetIntance();

        //    bai6FindProductByPriceTest.InsertTableTest();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i+1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }

        //    for (int i = 0; i < bai6FindProductByPriceTest.FindProductByPriceTest().Count; i++)
        //    {
        //        Console.Write("Name Prodcut tim thay ung voi Price la : ");
        //        Console.WriteLine(bai6FindProductByPriceTest.FindProductByPriceTest()[i].Name);
        //    }
        //}
    }
}
