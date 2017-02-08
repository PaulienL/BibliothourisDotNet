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
        private readonly List<Member> members = new List<Member>() {new Member("William", "Alegria"),new Member("Seppe", "Gielen")};

        public List<Member> GetAllMembers()
        {
            return members;
        }
    }
}
