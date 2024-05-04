using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity.DAO
{
    namespace DAO
    {
        internal class Database
        {
            public List<BaseRow> productTable = new List<BaseRow>();
            public List<BaseRow> catagoryTable = new List<BaseRow>();
            public List<BaseRow> accesssoryTable = new List<BaseRow>();
            public static Database instants;

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

            public List<BaseRow> SelectTable(string name, BaseRow where)
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

            public bool DeleteTable(string name, BaseRow row)
            {
                if (name == StringCache.NAME_CATEGORY)
                {
                    Category updatedcategory = (Category)row;
                    int idCategory = updatedcategory.getId();
                    for (int i = 0; i<catagoryTable.Count; i++)
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
            public void UpdateTableById(int id, BaseRow row)
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
                    return;
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
                    return;
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
                    return;
                }
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

