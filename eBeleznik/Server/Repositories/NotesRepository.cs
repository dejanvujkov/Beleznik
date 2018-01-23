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
    public class NotesRepository : Repository<Note>, INotesReporsitory
    {
	  public NotesRepository(DbContext context) : base(context)
	  {
	  }

	  public bool ChangeNote(Note note, string text)
	  {
		note.text = text;
		Context.Notes.Attach(note);
		Context.Entry(note).Property(p => p.text).IsModified = true;
		Console.WriteLine($"Beleska [{note.id}] promenjena.");
		return true;
	  }

	  public bool DeleteNoteById(int id)
	  {
		Console.WriteLine($"Beleska [{id}] obrisana");
		return Remove(GetNoteById(id));
	  }

	  public Note GetNoteById(int id)
	  {
		Console.WriteLine($"Beleska [{id}] uzeta");
		return Context.Notes.FirstOrDefault(n => n.id.Equals(id));
	  }

	  public List<Note> GetNoteByUser(User user)
	  {
		List<Note> returnNote = new List<Note>();
		var beleske = Context.Notes;
		var groups = user.groups.Split(';');
		foreach(var beleska in beleske)
		{
		    foreach(var group in groups)
		    {
			  if(beleska.groups.Contains(group))
			  {
				returnNote.Add(beleska);
				break;
			  }
		    }
		}
		Console.WriteLine($"Beleske za korisnika [{user.username}] uzete.");
		return returnNote;

	  }

	  public NotesContext Context => context as NotesContext;
    }
}
