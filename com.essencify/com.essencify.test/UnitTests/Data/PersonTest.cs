using System;
using System.Collections.Generic;
using System.Text;
using com.essencify.core.interfaces;

namespace com.essencify.test.UnitTests.Data
{
    public class PersonTest : IPerson
    {
        string IPerson.Name
        {
            get
            {
                return "John Smith3";
            }
            set => throw new NotImplementedException();
        }
        string IPerson.Role
        {
            get { return "Software Developer2"; }
            set => throw new NotImplementedException();
        }
        DateTime IPerson.BirthDate
        {
            get
            {
                return new DateTime(1990, 01, 01);
            }
            set => throw new NotImplementedException();
        }
        string IPerson.OfficialPosition
        {
            get
            {
                return "Software developer";
            }
            set => throw new NotImplementedException(); }
    }
}
