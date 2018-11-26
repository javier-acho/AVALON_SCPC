using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion
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
            //frmFormularioPrincipal obj = new frmFormularioPrincipal();
            //if (obj.InicioAutorizado)
                //Application.Run(obj);
                Application.Run(new Administracion.frmMantConceptos());

        }
    }
}
