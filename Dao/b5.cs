namespace dao

public class Database
{
    public List<Product> productTable = new List<Product>();
    public List<Category> catagoryTable = new List<Category>();
    public List<Accessotion> accesssoryTable = new List<Accessotion>();
    public Database instants;

    public void insertTable(string name, object obj)
    {

        if (obj is Product && obj.getName() == name)
        {
            productTable.Add(obj);
        }
        else if (obj is Category && obj.getName() == name)
        {
            catagoryTable.Add(obj);
        }
        else if (obj is Accessotion && obj.getName() == name)
        {
            accesssoryTable.Add(obj);
        }
    }

    public void selectTable(string name, object obj)
    {
        if (obj is Product)
        {
            for (int i = 0; i < productTable.count; i++)
            {
                if (productTable[i].getName() == name)
                {
                    Console.WriteLine(productTable[i]);
                }
            }
        }
        else if (obj is Categor)
        {
            for (int i = 0; i < catagoryTable.count; i++)
            {
                if (catagoryTable[i].getName() == name)
                {
                    Console.WriteLine(catagoryTable[i]);
                }
            }
        }
        else if (obj is Accessotion)
        {
            for (int i = 0; i < accesssoryTable.count; i++)
            {
                if (accesssoryTable[i].getName() == name)
                {
                    Console.WriteLine(accesssoryTable[i]);
                }
            }
        }
    }

    public void updateTable(string name, object obj)
    {
        if (obj is Product)
        {
            for (int i = 0; i < productTable.count; i++)
            {
                if (productTable[i].getId() == obj.getId())
                {
                    productTable.Add(obj);
                }               
            }
        }
        else if (obj is Categor)
        {
            for (int i = 0; i < catagoryTable.count; i++)
            {
                if (catagoryTable[i].getId() == obj.getId())
                {
                    catagoryTable.Add(obj);
                }
            }
        }
        else if (obj is Accessotion)
        {
            for (int i = 0; i < accesssoryTable.count; i++)
            {
                if (accesssoryTable[i].getId() == obj.getId())
                {
                    accesssoryTable.Add(obj);
                }
            }
        }
    }

    public void deleteTable(string name, object obj)
    {
        if (obj is Product)
        {
            for (int i = 0; i < productTable.count; i++)
            {
                if (productTable[i].getId() == obj.getId())
                {
                    productTable.Remove(obj);
                }
            }
        }
        else if (obj is Categor)
        {
            for (int i = 0; i < catagoryTable.count; i++)
            {
                if (catagoryTable[i].getId() == obj.getId())
                {
                    catagoryTable.Remove(obj);
                }
            }
        }
        else if (obj is Accessotion)
        {
            for (int i = 0; i < accesssoryTable.count; i++)
            {
                if (accesssoryTable[i].getId() == obj.getId())
                {
                    accesssoryTable.Remove(obj);
                }
            }
        }

        public void truncateTable(string name)
        {
            if (name == "Product")
            {
                productTable.Clear();
            }
            else if (name == "Category")
            {
                categoryTable.Clear();
            }
            else if (name == "Accessory")
            {
                accessoryTable.Clear();
            }
        }
    }



}


