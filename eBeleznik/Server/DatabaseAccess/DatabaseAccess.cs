using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Server.Repositories;

namespace Server.DatabaseAccess
{
    public class DatabaseAccess : IDatabaseAccess
    {
	  public bool AddNote(Note note)
	  {
		lock (Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine("Dodavanje nove beleske");
			  unit.Notes.Add(note);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool AddUser(User user)
	  {
		lock (Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine("Dodavanje novog usera");
			  unit.Users.Add(user);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool ChangeNote(Note note, string text)
	  {
		lock (Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Beleska sa ideom {note.id}, je promenjena");
			  unit.Notes.ChangeNote(note, text);
			  int i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool DeleteNoteById(int id)
	  {
		lock (Locker.lockNote)
		{
		    using (var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Brisanje beleske sa id-om {id}");
			  unit.Notes.DeleteNoteById(id);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool DeleteUserByUsernme(string username)
	  {
		lock (Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Brisanje korisnika sa korisnickim imenom {username}");
			  unit.Users.DeleteUserByUsernme(username);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public IEnumerable<Note> GetAllNotes()
	  {
		lock (Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine("Uzimanje svih beleski iz baze..");
			  return unit.Notes.GetAll();
		    }
		}
	  }

	  public IEnumerable<User> GetAllUsers()
	  {
		lock (Locker.lockUser)
		{
		    using (var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine("Uzimanje svih korisnika iz baze..");
			  return unit.Users.GetAll();
		    }
		}
	  }

	  public Note GetNoteById(int id)
	  {
		lock (Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Uzimanje beleski sa id-om {id}");
			  return unit.Notes.GetNoteById(id);
		    }
		}
	  }

	  public List<Note> GetNoteByUser(User user)
	  {
		lock (Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Uzimanje beleski za korisnika {user.username}");
			  return unit.Notes.GetNoteByUser(user);
		    }
		}
	  }

	  public User GetUserByUsername(string username)
	  {
		lock (Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Uzimanje korisnika sa korisnickim imenom {username}");
			  return unit.Users.GetUserByUsername(username);
		    }
		}
	  }

	  public User Login(string username, string password)
	  {
		lock(Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Pokusaj logovanja za kredencijalima {username} i {password}");
			  return unit.Users.Login(username, password);
		    }
		}
	  }

	  public bool RemoveNote(Note note)
	  {
		lock(Locker.lockNote)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Brisanje beleske sa id-om {note.id}");
			  unit.Notes.Remove(note);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool RemoveUser(User user)
	  {
		lock (Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Brisanje korisnika sa korisnickim imenom {user.username}");
			  unit.Users.Remove(user);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }

	  public bool UpdateUser(User updatedUser)
	  {
		lock(Locker.lockUser)
		{
		    using(var unit = new UnitOfWork(new NotesContext()))
		    {
			  Console.WriteLine($"Updejtovanje korisnika sa korisnickim imenom {updatedUser.username}");
			  unit.Users.UpdateUser(updatedUser);
			  var i = unit.Complete();
			  return (i > 0 ? true : false);
		    }
		}
	  }
    }
}
