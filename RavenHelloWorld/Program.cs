using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Raven.Client;
using Raven.Client.Document;

namespace RavenHelloWorld
{
    class Program
    {
        static void Main()
        {
            var documentStore = new DocumentStore
            {
                ConnectionStringName = "Default",
            }.Initialize();

            StoreCompaniesAsync(documentStore).Wait();

            using (var session = documentStore.OpenSession())
            {
                Company entity = session.Query<Company>().FirstOrDefault(x => x.Country == "Israel");

                entity.Name = "Another Company";
                session.SaveChanges(); // will send the change to the database
            }
        }

        private static async Task StoreCompaniesAsync(IDocumentStore documentStore)
        {
            var myCompany = new Company
            {
                Name = "Hibernating Rhinos",
                Employees = new List<Employee>
                    {
                                new Employee
                                    {
                                        Name = "Ayende Rahien"
                                    }                    
                    },
                Country = "Israel"
            };

            // Store the company in our RavenDB server
            using (var session = documentStore.OpenAsyncSession())
            {
                session.Store(myCompany);
                await session.SaveChangesAsync();
            }
        }
    }

    internal class Employee
    {
        public string Name { get; set; }
    }

    internal class Company
    {
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public string Country { get; set; }
    }
}
