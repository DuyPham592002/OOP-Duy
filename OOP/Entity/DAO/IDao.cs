using System.Collections.Generic;

namespace Entity.DAO
{
    public interface IDao
    {
        int Insert(BaseRow row);
        int Update(BaseRow row);
        bool Delete(BaseRow row);
        List<BaseRow> FindAll(BaseRow row);
        BaseRow FindById(int id , BaseRow row);
    }
}
