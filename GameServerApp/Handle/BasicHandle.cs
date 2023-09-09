using Riptide;
using Riptide.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerApp.Handle
{
    public interface BasicHandle
    {
        public void OnHandleRequest(Riptide.Message message, MessageHeader header);
    }
}
