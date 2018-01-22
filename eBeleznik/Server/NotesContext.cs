using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class NotesContext : DbContext
    {
	  public NotesContext() :base("name=Db") { }

	  public DbSet<Note> Notes { get; set; }
	  public DbSet<User> Users { get; set; }
    }
}
