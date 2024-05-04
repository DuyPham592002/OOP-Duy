using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal abstract class BaseDAO
    {
        public Database db = new Database();
        public int Insert(BaseRow row)
        {
            if (row is Product)
            {
                db.InsertTable("Product", row);
                return 1;
            }
            if (row is Category)
            {
                db.InsertTable("Categoty", row);
                return 1;
            }
            return 0;
        }
        public int Update(BaseRow row)
        {
            if (row is Product)
            {
                db.UpdateTable("Product", row);
                return 1;
            }
            if (row is Category)
            {
                db.UpdateTable("Category", row);
                return 1;
            }
            return 0;
        }

        public bool Delete(BaseRow row)
        {
            if (row is Product)
            {
                db.DeleteTable("Product", row);
                return true;
            }
            if (row is Category)
            {
                db.DeleteTable("Category", row);
                return true;
            }
            return false;
        }
        public List<BaseRow> FindAll(BaseRow row)
        {
            if (row is Product)
            {
                return db.SelectTable("Product", row);
            }
            if (row is Category)
            {
                return db.SelectTable("Category", row);
            }
            return null;
        }
    }
}
