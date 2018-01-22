using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseAccess
{
    public class DatabaseAccessServer
    {
	  private static DatabaseAccessServer _server;
	  private readonly ServiceHost _host;

	  public DatabaseAccessServer()
	  {
		_host = new ServiceHost(typeof(DatabaseAccess));
		_host.AddServiceEndpoint(typeof(IDatabaseAccess), new NetTcpBinding(), "net.tcp://localhost:10010/IDatabaseAccess");
		_host.Open();
		Console.WriteLine("Server started!");
	  }

	  public void Close()
	  {
		_host.Close();
		Console.WriteLine("Server stopped!");
	  }

	  public static DatabaseAccessServer Instance => _server ?? (_server = new DatabaseAccessServer());
    }
}
