using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModuloAlmacen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Formularios.login login = Formularios.login.Instancia();
            Application.Run(login);
        }
    }
}
