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
		Console.WriteLine($"Korisnik [{username}] obrisan");
		return Remove(GetUserByUsername(username));
	  }

	  public User GetUserByUsername(string username)
	  {
		Console.WriteLine($"Korisnik [{username}] uzet iz baze");
		return Context.Users.FirstOrDefault(u => u.username.Equals(username));
	  }

	  public User Login(string username, string password)
	  {
		var user = GetUserByUsername(username);
		if (user != null && user.password.Equals(password))
		{
		    Console.WriteLine($"Logovanje uspesno");
		    return user;
		}
		Console.WriteLine($"Ne postoji korisnik sa kredencijalima {username} i {password}");
		return null;
	  }

	  public bool UpdateUser(User updatedUser)
	  {
		var user = GetUserByUsername(updatedUser.username);
		if (user == null)
		{
		    Console.WriteLine($"Ne postoji korisnik sa korisnickim imenom {updatedUser.username}");
		    return false;
		}

		if (user.password != updatedUser.password)
		{
		    Console.WriteLine($"Lozinka za korisnika {updatedUser.username} uspesno promenjena");
		    user.password = updatedUser.password;
		    Context.Entry(updatedUser).Property(u => u.password).IsModified = true;
		}

		if(user.name != updatedUser.name)
		{
		    Console.WriteLine($"Ime za korisnika {updatedUser.surname} uspesno promenjena");
		    user.name = updatedUser.name;
		    Context.Entry(updatedUser).Property(u => u.name).IsModified = true;
		}

		if (user.surname != updatedUser.surname)
		{
		    Console.WriteLine($"Prezime za korisnika {updatedUser.username} uspesno promenjeno");
		    user.surname = updatedUser.surname;
		    Context.Entry(updatedUser).Property(u => u.surname).IsModified = true;
		}

		if(user.groups != updatedUser.groups)
		{
		    Console.WriteLine($"Grupe za korisnika {updatedUser.username} uspesno su promenjene");
		    user.groups = updatedUser.groups;
		    Context.Entry(updatedUser).Property(u => u.groups).IsModified = true;
		}

		return true;
	  }

	  public NotesContext Context => context as NotesContext;
    }
}
