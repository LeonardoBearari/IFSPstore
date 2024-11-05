using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreRepository.Context;
namespace IFSPStoreRepository.Repository
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity
        : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlCotext;

        void IBaseRepository<TEntity>.AtachObject(object obj)
        {
            _mySqlCotext.Attach(obj);
        }

        void IBaseRepository<TEntity>.ClearChangeTracker()
        {
            _mySqlCotext.ChangeTracker.Clear();
        }

        void IBaseRepository<TEntity>.Delete(object id)
        {
            
        }

        void IBaseRepository<TEntity>.Insert(TEntity entity)
        {
            _mySqlCotext.Set<TEntity>().Add(entity);
            _mySqlCotext.SaveChanges();
        }

        void IBaseRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
