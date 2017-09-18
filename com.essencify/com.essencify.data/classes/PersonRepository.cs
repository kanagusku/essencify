using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.essencify.data.interfaces;
using com.essencify.core.interfaces;
using com.essencify.core.classes;
using Gremlin.Net;

namespace com.essencify.data.classes
{
    public class PersonRepository : Repository, IPersonRepository
    {
        public PersonRepository()
        {
            this.Initialize("",8080,"","");
        }

        public void Modify(IPerson personObj)
        {
            using (var gremlinClient = new GremlinClient(this.GetServer()))
            {
                var result =
                    await gremlinClient.SubmitWithSingleResultAsync<bool>("g.V().has('name', 'gremlin').hasNext()");
            }
        }

        void IPersonRepository.Register(IPerson personObj)
        {
            throw new NotImplementedException();
        }
    }
}
