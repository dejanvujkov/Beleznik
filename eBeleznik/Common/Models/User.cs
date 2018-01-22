using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class User
    {
	  [Key]
	  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	  public string username { get; set; }
	  public string password { get; set; }
	  public string name { get; set; }
	  public string surname { get; set; }
	  public string groups { get; set; }

	  public User() { }

	  public User(string username, string password) : this()
	  {
		this.username = username;
		this.password = password;
	  }

	  public User(string username, string password, string name, string surname, string groups) : this(username, password)
	  {
		this.name = name;
		this.surname = surname;
		this.groups = groups;
	  }
    }
}
