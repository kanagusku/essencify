using System;
using System.Collections.Generic;
using System.Text;

namespace com.essencify.core.interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string Role { get; set; }
        DateTime BirthDate { get; set; }
        string OfficialPosition { get; set; }


    }
}
