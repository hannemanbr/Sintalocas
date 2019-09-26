using System.Collections.Generic;

namespace MobileApp.Infra.Common.DomainServices
{
    public interface IBaseDomainService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
