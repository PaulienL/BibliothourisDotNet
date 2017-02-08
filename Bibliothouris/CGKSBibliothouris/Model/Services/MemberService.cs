using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;

namespace CGKSBibliothouris.Model.Services
{
    public class MemberService
    {
        private MemberRepository memberRepository;

        public MemberService(MemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }


        public List<Member> GetAllMembers()
        {


            return memberRepository.GetAllMembers();
        }
    }
}
