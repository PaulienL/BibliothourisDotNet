using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Services;
using CGKSBibliothouris.View;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
using System.Security.Cryptography;

namespace CGKSBibliothouris.Controller
{
    public class MemberController : Controller
    {
        private MemberView memberView;
        private MemberService memberService;
        private AddMember addmember;
        private Login login;

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

        internal void CreateNewMember(string firstName, string lastName, string street, int number, int zipcode,
            string city, string inss, string password)
        {
            try
            {
                memberService.CreateAndAddMember(firstName, lastName, street, number, zipcode, city, inss, password);
                memberView.AddMember(new Member(firstName, lastName, inss, new Address(street, city, number, zipcode),
                    password));
                addmember.Close();
                addmember.Clear();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal Person getLastMember()
        {
            List<Person> memberlist = memberService.GetAllMembers();
            return memberlist.Last();
        }

        public void Login(string inss, string password)
        {
            try
            {
                if (memberService.Login(inss, password))
                {
                    Person p = memberService.GetMember(inss);
                    BookView bv = new BookView();
                    BookController bc = new BookController(new BookView(), this, new BookDetails());
                    bv.AddController(bc);
                    
                    bc.SetAccesRights(p);
                    bv.ShowDialog();
                    login.Hide();
                    
                    
                }
            }
            catch (AuthenticationException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void ShowLogin()
        {
            login = new Login(this);
            login.ShowDialog();
        }
    }
}