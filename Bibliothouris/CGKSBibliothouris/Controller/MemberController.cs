using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Services;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris.Controller
{
    public class MemberController : Controller
    {
        private MemberView memberView;
        private MemberService memberService;
        private AddMember addmember; 

        public MemberController(MemberView memberView, MemberService memberService, AddMember addmember)
        {
            this.memberView = memberView;
            this.memberService = memberService;
            this.addmember = addmember; 
            memberView.AddMemberController(this);
            addmember.AddController(this);
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

        internal void AddMemberView()
        {
            addmember.ShowDialog(); 
        }

        internal void CreateNewMember(string firstName, string lastName, string street, int number, int zipcode, string city, string inss)
        {
            memberService.CreateAndAddMember(firstName, lastName, street, number, zipcode ,city,inss);
            memberView.AddMember(getLastMember());
            addmember.Close();
            addmember.Clear();
        }

        internal Member getLastMember()
        {
            List<Member> memberlist = memberService.GetAllMembers();
            return memberlist.Last();
        }
    }
}
