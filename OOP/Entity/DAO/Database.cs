using System;
using System.Collections.Generic;

namespace Entity.DAO
{
    namespace DAO
    {
        public class Database
        {
            private List<BaseRow> productTable = new List<BaseRow>();
            private List<BaseRow> catagoryTable = new List<BaseRow>();
            private List<BaseRow> accesssoryTable = new List<BaseRow>();
            private static Database instance;

            /// <summary>
            /// no parameters
            /// </summary>
            private Database() { }

            /// <summary>
            /// singleton
            /// </summary>
            /// <returns>Database</returns>
            public static Database GetInstance()
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }

            /// <summary>
            /// get list productTable
            /// </summary>
            /// <returns>List<BaseRow></returns>
            public List<BaseRow> GetProductTable()
            {
                return productTable;
            }

            /// <summary>
            /// get list catagoryTable
            /// </summary>
            /// <returns>List<BaseRow></returns>
            public List<BaseRow> GetCatagoryTable()
            {
                return catagoryTable;
            }

            /// <summary>
            /// get list accesssoryTable
            /// </summary>
            /// <returns>List<BaseRow></returns>
            public List<BaseRow> GetAccesssoryTable()
            {
                return accesssoryTable;
            }

            /// <summary>
            /// insert row to table 
            /// </summary>
            /// <param name="name">string</param>
            /// <param name="row">BaseRow</param>
            /// <returns>int</returns>
            public int InsertTable(string name, BaseRow row)
            {
                if (name == StringCache.NAME_PRODUCT)
                {
                    productTable.Add((Product)row);
                    return 1;
                }

                if (name == StringCache.NAME_CATEGORY)
                {
                    catagoryTable.Add((Category)row);
                    return 1;
                }

                if (name == StringCache.NAME_ACCESSTION)
                {
                    accesssoryTable.Add((Accesstion)row);
                    return 1;
                }
                return 0;
            }

            /// <summary>
            /// Select table with name
            /// </summary>
            /// <param name="name">string</param>
            /// <returns>List<BaseRow></returns>
            public List<BaseRow> SelectTable(string name)
            {
                if (name == StringCache.NAME_PRODUCT)
                {
                    return productTable;
                }
                if (name == StringCache.NAME_CATEGORY)
                {
                    return catagoryTable;
                }
                if (name == StringCache.NAME_ACCESSTION)
                {
                    return accesssoryTable;
                }
                return null;
            }

            /// <summary>
            /// update row in table with name
            /// </summary>
            /// <param name="name">string</param>
            /// <param name="row">BaseRow</param>
            /// <returns>int</returns>
            public int UpdateTable(string name, BaseRow row)
            {
                if (name == StringCache.NAME_CATEGORY)
                {
                    Category updatedcategory = (Category)row;
                    int idCategory = updatedcategory.getId();
                    foreach (Category category in catagoryTable)
                    {
                        if (category.getId() == idCategory)
                        {
                            category.setName(updatedcategory.getName());
                            return 1;
                        }
                    }
                }

                if (name == StringCache.NAME_ACCESSTION)
                {
                    Product updatedAccessotion = (Product)row;
                    int idAccesstion = updatedAccessotion.getId();

                    foreach (Accesstion accessotion in accesssoryTable)
                    {
                        if (accessotion.getId() == idAccesstion)
                        {
                            accessotion.setName(updatedAccessotion.getName());
                            return 1;
                        }
                    }
                }

                if (name == StringCache.NAME_PRODUCT)
                {
                    Product updatedProduct = (Product)row;
                    int idProduct = updatedProduct.getId();

                    foreach (Product product in productTable)
                    {
                        if (product.getId() == idProduct)
                        {
                            product.setName(updatedProduct.getName());
                            return 1;
                        }
                    }
                }
                return 0;
            }

            /// <summary>
            /// delete row in table with name
            /// </summary>
            /// <param name="name">string</param>
            /// <param name="row">BaseRow</param>
            /// <returns>bool</returns>
            public bool DeleteTable(string name, BaseRow row)
            {
                if (name == StringCache.NAME_CATEGORY)
                {
                    Category updatedcategory = (Category)row;
                    int idCategory = updatedcategory.getId();
                    for (int i = 0; i < catagoryTable.Count; i++)
                    {
                        if (catagoryTable[i].getId() == idCategory)
                        {
                            catagoryTable.RemoveAt(i);
                        }
                    }
                    return true;
                }
                if (name == StringCache.NAME_ACCESSTION)
                {
                    Product updatedAccessotion = (Product)row;
                    int idAccesstion = updatedAccessotion.getId();
                    for (int i = 0; i < accesssoryTable.Count; i++)
                    {
                        if (accesssoryTable[i].getId() == idAccesstion)
                        {
                            accesssoryTable.RemoveAt(i);
                        }
                    }
                    return true;
                }
                if (name == StringCache.NAME_PRODUCT)
                {
                    Product updatedProduct = (Product)row;
                    int idProduct = updatedProduct.getId();
                    for (int i = 0; i < productTable.Count; i++)
                    {
                        if (productTable[i].getId() == idProduct)
                        {
                            productTable.RemoveAt(i);
                        }
                    }
                    return true;
                }

                return false;
            }
            
            /// <summary>
            /// delete table with name
            /// </summary>
            /// <param name="name">string</param>
            public void TruncateTable(string name)
            {
                if (name == StringCache.NAME_PRODUCT)
                {
                    productTable.Clear();
                }
                else if (name == StringCache.NAME_CATEGORY)
                {
                    catagoryTable.Clear();
                }
                else if (name == StringCache.NAME_ACCESSTION)
                {
                    accesssoryTable.Clear();
                }
            }

            /// <summary>
            /// update row to table with id
            /// </summary>
            /// <param name="id">int</param>
            /// <param name="row">BaseRow</param>
            /// <returns>int</returns>
            public int UpdateTableById(int id, BaseRow row)
            {
                if (row is Product)
                {
                    for (int i = 0; i < productTable.Count; i++)
                    {
                        if (productTable[i].getId() == id)
                        {
                            productTable[i] = (Product)row;
                        }
                    }
                    return 1;
                }

                if (row is Category)
                {
                    for (int i = 0; i < catagoryTable.Count; i++)
                    {
                        if (catagoryTable[i].getId() == id)
                        {
                            catagoryTable[i] = (Category)row;
                            break;
                        }
                    }
                    return 1;
                }

                if (row is Accesstion)
                {
                    for (int i = 0; i < accesssoryTable.Count; i++)
                    {
                        if (accesssoryTable[i].getId() == id)
                        {
                            accesssoryTable[i] = (Accesstion)row;
                            break;
                        }
                    }
                    return 1;
                }
                return 0;
            }      
        }

        public static class StringCache
        {
            public const string NAME_PRODUCT = "Product";
            public const string NAME_CATEGORY = "Category";
            public const string NAME_ACCESSTION = "Accesstion";
        }
    }
}
