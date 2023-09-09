using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerApp.Core
{
    public class Router
    {
        private Dictionary<string, Func<object[], object>> routes;
        
        public Dictionary<string, Func<object[], object>> Routes { 
            get { return routes; }
            set { routes = value; }
        }

        public Router() { 
            routes = new Dictionary<string, Func<object[], object>>();
        }

        public void addRoute(string name, Func<object[], object> action)
        {
            routes[name] = action;
        }

        public void removeRoute(string name)
        {
            routes.Remove(name);
        }

        public Func<object[], object> resolve(string name)
        {
            return routes[name];
        }
    }
}
