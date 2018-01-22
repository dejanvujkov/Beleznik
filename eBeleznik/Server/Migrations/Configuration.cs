namespace Server.Migrations
{
    using Common.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Server.NotesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Server.NotesContext context)
        {
		//  This method will be called after migrating to the latest version.

		//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
		//  to avoid creating duplicate seed data.

		context.UserContext.AddOrUpdate(u => u.username, new User
		{
		    groups = "admin",
		    username = "admin",
		    password = "admin",
		    name = "Dejan",
		    surname = "Vujkov"
		});
        }
    }
}
