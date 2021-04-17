using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalityGuess.Domain.Model
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : DomainBase
    {
        private bool disposed;
        private readonly List<TEntity> entities;
        public Repository()
        {
            entities = new List<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return entities;
        }

        public TEntity Get(Guid id)
        {
            return entities.SingleOrDefault(t => t.Id == id);
        }

        public TEntity Add(TEntity entity)
        {
            entities.ToList()
                .Add(entity);

            return entity;
        }

        public void Update(TEntity entity)
        {
            Delete(entity);
            entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            var oldEntity = entities
                  .SingleOrDefault(t => t.Id == entity.Id);

            entities.Remove(oldEntity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
