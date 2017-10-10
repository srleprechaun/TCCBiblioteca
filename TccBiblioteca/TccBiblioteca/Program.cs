using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TccBiblioteca
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

            Login login = new Login();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
                Application.Run(new TelaPrincipal(login.funcionario));
            
        }
    }
}
