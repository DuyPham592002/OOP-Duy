using System.Collections.Generic;
using System.Linq;

namespace Entity.DAO
{
    namespace DAO
    {
        internal class Database
        {
            public List<Product> productTable = new List<Product>();
            public List<Category> catagoryTable = new List<Category>();
            public List<Accesstion> accesssoryTable = new List<Accesstion>();
            public Database instants;

            public void InsertTable(string name, object row)
            {

                if (name == "product")
                {
                    productTable.Add((Product)row);
                    return;
                }
                if (name == "category")
                {
                    catagoryTable.Add((Category)row);
                    return;
                }
                if (name == "accessotion")
                {
                    accesssoryTable.Add((Accesstion)row);
                    return;
                }
            }

            public List<object> SelectTable(string name, object where)
            {
                if (name == "product")
                {
                    return productTable.Cast<object>().ToList();
                }
                if (name == "category")
                {
                    return catagoryTable.Cast<object>().ToList();
                }
                if (name == "accessotion")
                {
                    return accesssoryTable.Cast<object>().ToList();
                }
                return null;
            }

            public void UpdateTable(string name, object row)
            {
                if (name == "category")
                {
                    Category updatedcategory = (Category)row;
                    int idToUpdate = updatedcategory.getId();
                    foreach (Category category in catagoryTable)
                    {
                        if (category.getId() == idToUpdate)
                        {
                            category.setName(category.getName());
                        }
                    }
                    return;
                }
                if (name == "accessotion")
                {
                    Product updatedAccessotion = (Product)row;
                    int idToUpdate = updatedAccessotion.getId();

                    foreach (Accesstion accessotion in accesssoryTable)
                    {
                        if (accessotion.getId() == idToUpdate)
                        {
                            accessotion.setName(accessotion.getName());
                        }
                    }
                    return;
                }
                if (name == "product")
                {
                    Product updatedProduct = (Product)row;
                    int idToUpdate = updatedProduct.getId();

                    foreach (Product product in productTable)
                    {
                        if (product.getId() == idToUpdate)
                        {
                            product.setName(updatedProduct.getName());
                        }
                    }
                    return;
                }
            }

            public void DeleteTable(string name, object row)
            {
                if (name == "category")
                {
                    Category updatedcategory = (Category)row;
                    int idToUpdate = updatedcategory.getId();
                    foreach (Category category in catagoryTable)
                    {
                        if (category.getId() == idToUpdate)
                        {
                            catagoryTable.Remove(category);
                        }
                    }
                    return;
                }
                if (name == "accessotion")
                {
                    Product updatedAccessotion = (Product)row;
                    int idToUpdate = updatedAccessotion.getId();

                    foreach (Accesstion accessotion in accesssoryTable)
                    {
                        if (accessotion.getId() == idToUpdate)
                        {
                            accesssoryTable.Remove(accessotion);
                        }
                    }
                    return;
                }
                if (name == "product")
                {
                    Product updatedProduct = (Product)row;
                    int idToUpdate = updatedProduct.getId();

                    foreach (Product product in productTable)
                    {
                        if (product.getId() == idToUpdate)
                        {
                            productTable.Remove(product);
                        }
                    }
                    return;
                }
            }

            public void TruncateTable(string name)
            {
                if (name == "Product")
                {
                    productTable.Clear();
                }
                else if (name == "Category")
                {
                    catagoryTable.Clear();
                }
                else if (name == "Accessory")
                {
                    accesssoryTable.Clear();
                }
            }
            public void UpdateTableById(int id, object row)
            {
                if (row is Product)
                {
                    for (int i = 0; i < productTable.Count; i++)
                    {
                        if (productTable[i].getId() == id)
                        {
                            productTable[i] = (Product)row;
                            break;
                        }
                    }
                }
                else if (row is Category)
                {
                    for (int i = 0; i < catagoryTable.Count; i++)
                    {
                        if (catagoryTable[i].getId() == id)
                        {
                            catagoryTable[i] = (Category)row;
                            break;
                        }
                    }
                }
                else if (row is Product)
                {
                    for (int i = 0; i < accesssoryTable.Count; i++)
                    {
                        if (accesssoryTable[i].getId() == id)
                        {
                            accesssoryTable[i] = (Accesstion)row;
                            break;
                        }
                    }
                }
            }
        }
    }
}

