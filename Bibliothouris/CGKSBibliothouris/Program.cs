using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.Repositories;
using CGKSBibliothouris.Model.Services;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBookView());
        }
    }
}
