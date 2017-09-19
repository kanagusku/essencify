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


        public PersonRepository(GraphOptions opts)
        {
            this.Initialize(opts.GraphHostName, opts.GraphPort,opts.GraphUserName,opts.GraphPassword);
        }

        public async void RegisterAsync(IPerson personObj)
        {
            using (var Client = new DBClient(this.GetServer()))
            {
                var result = await Client.SubmitWithSingleResultAsync<bool>("g.addV('" + personObj.Name + "').property('" + nameof(personObj.Name) + "','" + personObj.Name + "')" +
                                                                                      ".property('" + nameof(personObj.BirthDate) + "','" + personObj.BirthDate + "')" +
                                                                                      ".property('" + nameof(personObj.OfficialPosition) + "','" + personObj.OfficialPosition + "')" +
                                                                                      ".property('" + nameof(personObj.Role) + "','" + personObj.Role + "')" +
                                                                                      ".next()");
            }
        }

        void IPersonRepository.Modify(IPerson personObj)
        {
            throw new NotImplementedException();
        }
    }
}
