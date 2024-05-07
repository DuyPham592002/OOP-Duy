using DataStructureAndAlgorithms.DAO;
using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms.Demo
{
    internal class Bai5FindProductByCategoryTest
    {
        Bai5FindProductByCategory Bai5FindProductByCategory = new Bai5FindProductByCategory();
        DataBase instance = DataBase.GetIntance();

        void InsertTableTest()
        {
            instance.InsertTableProduct();
        }

        List<Product> FindProductByCategotyTest()
        {
            return Bai5FindProductByCategory.FindProductByCategoty(instance.GetProductTable(), 1);
        }

        //static void Main(string[] args)
        //{
        //    Bai5FindProductByCategoryTest bai5FindProductByCategoryTest = new Bai5FindProductByCategoryTest();
        //    DataBase instance = DataBase.GetIntance();

        //    bai5FindProductByCategoryTest.InsertTableTest();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i+1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }

        //    for (int i = 0; i < bai5FindProductByCategoryTest.FindProductByCategotyTest().Count; i++)
        //    {
        //        Console.Write("Name Product tim thay ung voi CategoryId la : ");
        //        Console.WriteLine(bai5FindProductByCategoryTest.FindProductByCategotyTest()[i].Name);
        //    }
        //}
    }
}
