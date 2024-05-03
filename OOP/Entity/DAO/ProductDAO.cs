using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class ProductDAO
    {
        Database db = new Database();

        public bool Insert(Product row)
        {
            db.InsertTable("product", row);
            return db.productTable.Contains(row);
        }

        public void Update(Product row)
        {
            db.UpdateTable("product", row);
        }

        void Delete(Product row)
        {
            db.DeleteTable("product", row);
        }

        public List<object> FindAll(Product row)
        {
            return db.SelectTable("product", row);
        }

        object FindById(int id)
        {
            for (int i = 0; i < db.productTable.Count; i++)
            {
                if (db.productTable[i].getId() == id)
                {
                    return db.catagoryTable[i];
                }
            }
            return null;
        }

        object FindByName(string name)
        {
            for (int i = 0; i < db.productTable.Count; i++)
            {
                if (db.productTable[i].getName() == name)
                {
                    return db.productTable[i];
                }
            }
            return null;
        }
    }
}
