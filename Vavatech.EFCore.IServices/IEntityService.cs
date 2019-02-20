using System.Collections.Generic;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.IServices
{
    public interface IEntityService<TEntity>
        where TEntity : Base
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
