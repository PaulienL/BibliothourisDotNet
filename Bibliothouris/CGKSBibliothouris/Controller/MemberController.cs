using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Services;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris.Controller
{
    class MemberController : Controller
    {
        private MemberView memberView;
        private MemberService memberService;

        public MemberController(MemberView memberView, MemberService memberService)
        {
            this.memberView = memberView;
            this.memberService = memberService;
            memberView.AddMemberController(this);
          }

        public void ShowView()
        {
            LoadAllMembers();
            memberView.ShowDialog();
        }

        private void LoadAllMembers()
        {
            memberView.AddMembers(memberService.GetAllMembers());
        }

        
    }
}
