using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.View
{
    public partial class MemberView : Form
    {
        private MemberController memberController;
        public MemberView()
        {
            InitializeComponent();
        }

        internal void AddMembers(List<Person> members)
        {
            foreach (var member in members)
            {
                ListViewItem memberItem = new ListViewItem(member.Id.ToString());
                memberItem.SubItems.Add(member.FirstName);
                memberItem.SubItems.Add(member.LastName);
                memberList.Items.Add(memberItem);
            }
            
        }

        internal void AddMember(Member member)
        {
            {
                ListViewItem memberItem = new ListViewItem(member.Id.ToString());
                memberItem.SubItems.Add(member.FirstName);
                memberItem.SubItems.Add(member.LastName);
                memberList.Items.Add(memberItem);
            }
        }

        internal void AddMemberController(MemberController memberController)
        {
            this.memberController = memberController;
        }

        private void addMember_Click_1(object sender, EventArgs e)
        {
            memberController.AddMemberView();

        }

        internal void UpdateList()
        {
            memberList.Refresh();
        }
    }
}
