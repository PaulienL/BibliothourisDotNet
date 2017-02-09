using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.Model.Repositories
{
    public class MemberRepository
    {
        private readonly List<Person> members = new List<Person>()
        {
            new Member("William", "Alegria","12345", new Address("Interleuvenlaan", "Leuven", 20, 3000), "william"),
            new Member("Seppe", "Gielen","123456", new Address("Interleuvenlaan", "Leuven", 20, 3000), "seppeg"),
            new Administrator("987654", "Ad", "Min", "azerty", new Address("Interleuvenlaan", "Leuven", 20, 3000))
        };

        public List<Person> GetAllMembers()
        {
            return members;
        }

        public void AddMember(string firstName, string lastName, string inss, Address address, string password)
        {
            members.Add(new Member(firstName, lastName, inss, address, password)); 
        }

        public Person GetUser(string inss)
        {
            return members.FirstOrDefault(m => m.Inss.Equals(inss));
        }
    }
}
