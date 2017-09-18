using System;
using System.Collections.Generic;
using System.Text;
using Gremlin.Net;

namespace com.essencify.data.classes
{
    public class DBClient: GremlinClient
    {
        public DBClient(GremlinServer gremlinServer) :base(gremlinServer)
        {
        }

  
    }
}
