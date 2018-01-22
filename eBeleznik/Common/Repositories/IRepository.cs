using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
	  IEnumerable<TEntity> GetAll();
	  bool Add(TEntity entity);
	  bool Remove(TEntity entity);

    }
}
