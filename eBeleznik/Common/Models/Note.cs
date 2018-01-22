using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Note
    {
	  [Key]
	  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	  public int id { get; set; }
	  public string title { get; set; }
	  public string text { get; set; }
	  public string groups { get; set; }

	  public Note() { }
    }
}
