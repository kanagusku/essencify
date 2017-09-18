using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.essencify.core.interfaces;

namespace com.essencify.data.interfaces
{
    public interface IPersonRepository
    {
        void Register(IPerson personObj);
        void Modify(IPerson personObj);
       
    }
}
