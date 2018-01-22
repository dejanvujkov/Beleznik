using Common.Models;
using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Server.Repositories
{
    public class UsersRepository : Repository<User>, IUsersRepository
    {
	  public UsersRepository(DbContext context) : base(context)
	  {
	  }

	  public bool DeleteUserByUsernme(string username)
	  {
		throw new NotImplementedException();
	  }

	  public User GetUserByUsername(string username)
	  {
		throw new NotImplementedException();
	  }

	  public User Login(string username, string password)
	  {
		throw new NotImplementedException();
	  }

	  public bool UpdateUser(User updatedUser)
	  {
		throw new NotImplementedException();
	  }
    }
}
