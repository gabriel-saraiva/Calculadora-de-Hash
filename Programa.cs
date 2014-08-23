using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora_de_Hash
{
    static class Programa
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }
    }
}
