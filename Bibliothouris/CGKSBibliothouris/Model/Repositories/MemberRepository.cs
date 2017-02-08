using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.Model.Repositories
{
    class MemberRepository
    {
        private List<Member> members = new List<Member>();

        public List<Member> GetAllMembers()
        {
            return members;
        }
    }
}
