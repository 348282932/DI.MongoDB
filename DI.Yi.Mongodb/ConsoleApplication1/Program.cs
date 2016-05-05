using DI.Yi.Mongodb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var mongoDbServer = new MongoDBServer();

			mongoDbServer.Init();
		}
	}
}
