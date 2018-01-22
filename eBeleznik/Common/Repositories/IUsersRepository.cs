using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {
	  User Login(string username, string password);
	  bool UpdateUser(User updatedUser);
	  User GetUserByUsername(string username);
	  bool DeleteUserByUsernme(string username);
    }
}
