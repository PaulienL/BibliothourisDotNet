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
using CGKSBibliothouris.Model.Repositories;

namespace CGKSBibliothouris.Controller
{
    public class MemberController : Controller
    {
        private MainController mainController;

        private readonly MemberView memberView;
        private readonly MemberService memberService;
        private readonly AddMember addmember;

        public MemberController()
        {
            this.memberView = new MemberView();
            this.memberService = new MemberService(new MemberRepository());
            addmember = new AddMember();
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
                    mainController.HideLoginView();
                    mainController.BookController.SetAccesRights(p);
                    mainController.BookController.ShowMainView();
                }
            }
            catch (AuthenticationException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void AddMainController()
        {
            mainController = MainController.GetInstance();
        }
    }
}