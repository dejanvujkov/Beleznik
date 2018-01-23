using Server.DatabaseAccess;
using Server.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
	  private static DatabaseAccessServer _dbserver;
	  static void Main(string[] args)
	  {
		Database.SetInitializer(new MigrateDatabaseToLatestVersion<NotesContext, Configuration>());

		using (var context = new NotesContext())
		{
		    context.Users.Add(new Common.Models.User()
		    {
			  username = "admin",
			  password = "admin",
			  groups = "admin",
			  name = "Dejan",
			  surname = "Vujkov"
		    });
		}

		_dbserver = DatabaseAccessServer.Instance;

		Console.WriteLine($"Pritisnite bilo sta da zaustavite server");
		Console.ReadLine();
		_dbserver.Close();
		Console.ReadKey(true);
	  }
    }
}
