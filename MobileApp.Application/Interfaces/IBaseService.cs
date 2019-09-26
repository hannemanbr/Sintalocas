using System.Collections.Generic;

namespace MobileApp.Application.Interfaces
{
    public interface IBaseService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
