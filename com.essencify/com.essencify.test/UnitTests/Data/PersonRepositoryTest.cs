using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.essencify.core.interfaces;
using com.essencify.core.classes;
using com.essencify.data.interfaces;
using com.essencify.data.classes;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace com.essencify.test.UnitTests.Data
{
    [TestClass]
    public class PersonRepositoryTest
    {

        public static IConfigurationRoot Configuration { get; set; }
        public static GraphOptions options { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {

            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            options = new GraphOptions();
            Configuration.Bind(options);
        }


        [TestMethod]
        public void InsertUser()
        {
            IPerson personTest = new PersonTest();

            IPersonRepository repo = new PersonRepository(options);

            repo.RegisterAsync(personTest);
           

        }
    }
}
