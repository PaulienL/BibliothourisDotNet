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
        private readonly List<Member> members = new List<Member>() {new Member("William", "Alegria","12345", new Address("Interleuvenlaan", "Leuven", 20, 3000)),new Member("Seppe", "Gielen","12345", new Address("Interleuvenlaan", "Leuven", 20, 3000)) };

        public List<Member> GetAllMembers()
        {
            return members;
        }

        public void AddMember(string firstName, string lastName, string inss, Address address)
        {
            members.Add(new Member(firstName, lastName, inss, address)); 
        }
    }
}
