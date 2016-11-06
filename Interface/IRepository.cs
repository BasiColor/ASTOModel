using Asto.Models.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models.Interface
{
    public interface IRepository<TEntity>
         where TEntity : class
    {
        IUnitOfWork _UnitOfWork { get; set; }

        void Create(TEntity instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();
    }
}
