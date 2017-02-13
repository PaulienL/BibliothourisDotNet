using CGKSBibliothouris.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGKSBibliothouris.View
{
    public partial class AddMember : Form
    {
        private MemberController membercontroller; 

        public AddMember()
        {
            InitializeComponent();
        }

        internal void AddController(MemberController membercontroller)
        {
            this.membercontroller = membercontroller;
        }

        private void saveMember_Click(object sender, EventArgs e)
        {
        membercontroller.CreateNewMember(firstName.Text, lastName.Text, street.Text, int.Parse(number.Text), int.Parse(zipcode.Text), city.Text, inss.Text, password.Text);
        }

        public void Clear()
        {
            firstName.Clear();
            lastName.Clear();
            street.Clear();
            number.Clear();
            zipcode.Clear();
            city.Clear();
            inss.Clear(); 
        }
    }
}
