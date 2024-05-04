using System.Collections.Generic;

namespace Entity.DAO
{
    public interface IDao
    {
        BaseRow FindById(int id);
    }
}