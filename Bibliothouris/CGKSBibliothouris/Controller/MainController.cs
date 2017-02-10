using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.Repositories;
using CGKSBibliothouris.Model.Services;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris.Controller {
    //This class is a Singleton. If not we could possibly have memory issues.
    public class MainController : Controller
    {
        private static MainController mainController;

        private Login loginView;

        public BookController BookController { get; private set; }
        public MemberController MemberController { get; private set; }
        public RentalController RentalController { get; private set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private MainController()
        {
            MemberController = new MemberController();
            BookController = new BookController();
            RentalController = new RentalController();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MainController GetInstance()
        {
            if (mainController == null)
            {
                mainController = new MainController();
                mainController.AddMainControllerToAllControllers();
            }
            return mainController;
        }

        private void AddMainControllerToAllControllers()
        {
            BookController.AddMainController();
            MemberController.AddMainController();
            RentalController.AddMainController();
        }

        public void ShowView()
        {
            loginView = new Login(this);
            loginView.ShowDialog();
        }

        public void ShowMemberView()
        {
            MemberController.ShowView();
        }

        public void Login(string inss, string password)
        {
            MemberController.Login(inss, password);
        }


        public void HideLoginView()
        {
            loginView.Hide();
        }
    }
}
