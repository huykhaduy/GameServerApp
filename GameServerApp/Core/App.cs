using GameServerApp.Handle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerApp.Core
{
    public class App
    {
        public Router Routes { get; set; }
        public List<Server> Servers { get; set; }
        public App() 
        {
            Servers = new List<Server>();
            this.initServer();
        }

        public void initRoute()
        {
            // Routes.addRoute("login", LoginHandle.auth);
        }

        public void initServer()
        {
            Server server = new Server();
            Servers.Add(server);
        }

    }
}
