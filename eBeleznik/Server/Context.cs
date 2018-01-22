using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Context : DbContext
    {
	  public Context() :base("name=Db") { }

	  public DbSet<Note> NoteContext { get; set; }
	  public DbSet<User> UserContext { get; set; }
    }
}
