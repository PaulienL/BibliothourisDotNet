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

namespace CGKSBibliothouris.View {
    public partial class Login : Form {
        private readonly MainController controller;

        public Login(MainController controller) {
            this.controller = controller;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            controller.MemberController.AddMemberView();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controller.Login(txtInss.Text, txtPassword.Text);
        }
    }
}
