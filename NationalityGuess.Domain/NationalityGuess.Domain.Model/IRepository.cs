using System;
using System.Collections.Generic;

namespace NationalityGuess.Domain.Model
{
    public interface IRepository<TEntity> where TEntity : DomainBase
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Guid id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
