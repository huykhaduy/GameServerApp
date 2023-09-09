using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameServerApp.Core
{
    public class Server : Riptide.Server
    {
        // Tên hiển thị của server
        private string displayName;

        // Địa chỉ ip của server 
        private string serverHost;
 
        // Port của server
        private int serverPort;

        // Bảng route của server, nó đưa ra hành động tương ứng với yêu cầu
        private Router route;

        public Server(string host = "0.0.0.0", int port = 8000, string displayName = "Server", Router route = null) {
            this.serverHost = host;
            this.serverPort = port;
            this.displayName = displayName;
            this.route = route;
        }

        public byte[] handleClient(byte[] sendData)
        {
            return null;
        }

        public string ServerHost
        {
            get { return this.serverHost; }
            set { this.serverHost = value; }
        }

        public int ServerPort
        { 
            get { return this.serverPort; } 
            set { this.serverPort = value; } 
        }

        public string DisplayName
        { 
            get { return this.displayName; }
            set { this.displayName = value; }
        }

        public Router Route
        {
            get { return this.route;}
            set { this.route = value;}
        }
    }
}
