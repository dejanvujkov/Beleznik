using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
	  protected DbContext context;

	  public Repository(DbContext context)
	  {
		this.context = context;
	  }

	  public bool Add(TEntity entity)
	  {
		context.Set<TEntity>().Add(entity);
		return true;
	  }

	  public IEnumerable<TEntity> GetAll()
	  {
		return context.Set<TEntity>().ToList();
	  }

	  public bool Remove(TEntity entity)
	  {
		context.Set<TEntity>().Remove(entity);
		return true;
	  }
    }
}
