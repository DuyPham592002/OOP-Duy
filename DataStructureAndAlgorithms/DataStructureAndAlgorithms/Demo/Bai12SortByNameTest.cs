using DataStructureAndAlgorithms.DAO;
using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Demo
{
    internal class Bai12SortByNameTest
    {
        Bai12SortByName Bai12SortByName = new Bai12SortByName();
        DataBase instance = DataBase.GetIntance();

        void InsertTableTest()
        {
            instance.InsertTableProduct();
        }

        List<Product> SortByNameTest()
        {
            return Bai12SortByName.SortByName(instance.GetProductTable());
        }

        //static void Main(string[] args)
        //{
        //    Bai12SortByNameTest bai12SortByNameTest = new Bai12SortByNameTest();
        //    DataBase instance = DataBase.GetIntance();

        //    bai12SortByNameTest.InsertTableTest();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i+1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }

        //    bai12SortByNameTest.SortByNameTest();

        //    Console.WriteLine("Danh sach sau khi sap xep");
        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write("Ten product thu " + (i+1) + " : " + instance.GetProductTable()[i].Name);
        //        Console.Write("   so price : " + instance.GetProductTable()[i].Price);
        //        Console.Write("   so quality : " + instance.GetProductTable()[i].Quality);
        //        Console.WriteLine("   so categotyId : " + instance.GetProductTable()[i].CategoryId);
        //    }
        //}
    }
}
