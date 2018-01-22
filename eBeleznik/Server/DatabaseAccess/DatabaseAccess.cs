using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Server.DatabaseAccess
{
    public class DatabaseAccess : IDatabaseAccess
    {
	  public bool AddNote(Note note)
	  {
		throw new NotImplementedException();
	  }

	  public bool AddUser(User user)
	  {
		throw new NotImplementedException();
	  }

	  public bool ChangeNote(Note note, string text)
	  {
		throw new NotImplementedException();
	  }

	  public bool DeleteNoteById(int id)
	  {
		throw new NotImplementedException();
	  }

	  public bool DeleteUserByUsernme(string username)
	  {
		throw new NotImplementedException();
	  }

	  public IEnumerable<Note> GetAllNotes()
	  {
		throw new NotImplementedException();
	  }

	  public IEnumerable<User> GetAllUsers()
	  {
		throw new NotImplementedException();
	  }

	  public Note GetNoteById(int id)
	  {
		throw new NotImplementedException();
	  }

	  public List<Note> GetNoteByUser(User user)
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

	  public bool RemoveNote(Note note)
	  {
		throw new NotImplementedException();
	  }

	  public bool RemoveUser(User user)
	  {
		throw new NotImplementedException();
	  }

	  public bool UpdateUser(User updatedUser)
	  {
		throw new NotImplementedException();
	  }
    }
}
