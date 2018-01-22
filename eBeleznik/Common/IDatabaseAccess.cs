using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IDatabaseAccess
    {
	  #region Users
	  [OperationContract]
	  IEnumerable<User> GetAllUsers();

	  [OperationContract]
	  bool AddUser(User user);

	  [OperationContract]
	  bool RemoveUser(User user);

	  [OperationContract]
	  User Login(string username, string password);

	  [OperationContract]
	  bool UpdateUser(User updatedUser);

	  [OperationContract]
	  User GetUserByUsername(string username);

	  [OperationContract]
	  bool DeleteUserByUsernme(string username);
	  #endregion

	  #region Notes
	  [OperationContract]
	  IEnumerable<Note> GetAllNotes();

	  [OperationContract]
	  bool AddNote(Note note);

	  [OperationContract]
	  bool RemoveNote(Note note);

	  [OperationContract]
	  bool DeleteNoteById(int id);

	  [OperationContract]
	  Note GetNoteById(int id);

	  [OperationContract]
	  List<Note> GetNoteByUser(User user);

	  [OperationContract]
	  bool ChangeNote(Note note, string text);
	  #endregion
    }
}
