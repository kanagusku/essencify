using System;
using System.Collections.Generic;
using System.Text;
using Gremlin.Net;

namespace com.essencify.data.classes
{


    public abstract class Repository
    {
        private GremlinServer _server;


        protected void Initialize(String endPoint, Int32 port, String userName, string password)
        {
            _server = new GremlinServer(endPoint, port, false, userName, password);
        }

        protected GremlinServer GetServer() { return _server; }
    }
}
