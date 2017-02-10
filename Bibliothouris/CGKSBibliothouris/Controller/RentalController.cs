namespace CGKSBibliothouris.Controller
{
    public class RentalController
    {
        public MainController MainController { get; private set; }

        public void AddMainController()
        {
            MainController = MainController.GetInstance();
        }
    }
}