using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface INotesReporsitory : IRepository<Note>
    {
	  bool DeleteNoteById(int id);

	  Note GetNoteById(int id);

	  List<Note> GetNoteByUser(User user);

	  bool ChangeNote(Note note, string text);
    }
}
