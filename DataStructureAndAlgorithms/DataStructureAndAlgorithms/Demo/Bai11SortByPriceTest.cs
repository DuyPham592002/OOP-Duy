using DataStructureAndAlgorithms.DAO;
using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Demo
{
    internal class Bai11SortByPriceTest
    {

        Bai11SortByPrice bai11SortByPrice = new Bai11SortByPrice();
        DataBase instance = DataBase.GetIntance();

        void InsertTableTest()
        {
            instance.InsertTableProduct();
        }

        List<Product> SortByPriceTest()
        {
            return bai11SortByPrice.SortByPrice(instance.GetProductTable());
        }

        //static void Main(string[] args)
        //{
        //    Bai11SortByPriceTest bai11SortByPriceTest = new Bai11SortByPriceTest();
        //    DataBase instance = DataBase.GetIntance();

        //    bai11SortByPriceTest.InsertTableTest();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i + 1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }

        //    bai11SortByPriceTest.SortByPriceTest();

        //    Console.WriteLine("Danh sach sau khi sap xep");
        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i + 1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }
        //}
    }
}
