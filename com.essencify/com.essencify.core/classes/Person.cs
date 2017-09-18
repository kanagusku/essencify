using System;
using System.Collections.Generic;
using System.Text;
using com.essencify.core.interfaces;

namespace com.essencify.core.classes
{
    public class Person: IPerson
    {

        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime BirthDate { get; set; }
        public string OfficialPosition { get; set; }

    }
}
