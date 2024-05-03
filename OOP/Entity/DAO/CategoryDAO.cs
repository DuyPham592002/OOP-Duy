using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class CategoryDAO
    {
        Database db = new Database();

        public bool Insert(Category row)
        {
            db.InsertTable("category", row);
            return db.catagoryTable.Contains(row);
        }

        public void Update(Category row)
        {
            db.UpdateTable("category", row);
        }

        void Delete(Category row)
        {
            db.DeleteTable("category", row);
        }

        public List<object> FindAll(Category row)
        {
            return db.SelectTable("category", row);
        }

        object FindById(int id)
        {
            for (int i = 0; i < db.catagoryTable.Count; i++)
            {
                if (db.catagoryTable[i].getId() == id)
                {
                    return db.catagoryTable[i];
                }
            }
            return null;
        }
    }
}
