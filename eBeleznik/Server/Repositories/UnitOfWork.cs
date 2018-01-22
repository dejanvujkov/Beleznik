using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
	  private readonly NotesContext _context;

	  public UnitOfWork(NotesContext context)
	  {
		_context = context;
		Users = new UsersRepository(context);
		Notes = new NotesRepository(context);
	  }

	  public INotesReporsitory Notes { get; } 

	  public IUsersRepository Users { get; }

	  public int Complete()
	  {
		return _context.SaveChanges();
	  }

	  public void Dispose()
	  {
		_context.Dispose();
	  }
    }
}
