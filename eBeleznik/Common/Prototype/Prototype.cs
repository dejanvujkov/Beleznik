using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common.Prototype
{
    public static class Prototype
    {
	  public static T Clone<T>(this T self)
	  {
		using(var ms = new MemoryStream())
		{
		    var serializer = new XmlSerializer(typeof(T));
		    serializer.Serialize(ms, self);
		    ms.Position = 0;
		    return (T)serializer.Deserialize(ms);
		}
	  }
    }
}
