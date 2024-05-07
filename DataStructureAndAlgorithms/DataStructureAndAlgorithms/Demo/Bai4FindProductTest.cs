using DataStructureAndAlgorithms.DAO;
using DataStructureAndAlgorithms.Enity;
using System;

namespace DataStructureAndAlgorithms.Demo
{
    internal class Bai4FindProductTest
    {
        Bai4FindProduct bai4FindProduct = new Bai4FindProduct();
        DataBase instance = DataBase.GetIntance();

        void InsertTableProductTest()
        {
            instance.InsertTableProduct();
        }

        Product FindProductTest()
        {
            return bai4FindProduct.FindProduct(instance.GetProductTable(), "CPU");
        }

        //static void Main(string[] args)
        //{
        //    Bai4FindProductTest bai4FindProductTest = new Bai4FindProductTest();
        //    DataBase instance = DataBase.GetIntance();

        //    bai4FindProductTest.InsertTableProductTest();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i + 1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }

        //    if (bai4FindProductTest.FindProductTest() == null)
        //    {
        //        Console.WriteLine("Khong tim thay");
        //    }
        //    else
        //    {
        //        Console.WriteLine("so categotyId ung voi name product la : " + bai4FindProductTest.FindProductTest().CategoryId);
        //    }
        //}
    }
}
