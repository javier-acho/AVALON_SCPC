using Avalon.Aplicacion.Seguridad;
using Avalon.BO.Menu;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion
{
    public partial class frmFormularioPrincipal : frmBase
    {
        public bool InicioAutorizado { get; set; }
        public frmFormularioPrincipal()
        {
            ProcesarInicio(false);
        }

        private void ProcesarInicio(bool reprocesar)
        {
            while ((InicioAutorizado = Logear()))
            {
                if (!reprocesar)
                {
                    InitializeComponent();
                    ctrMenu menu = new ctrMenu();
                    menu.CrearMenu(ref kryptonNavigator1);
                }
                return;
            }
        }

        private bool Logear()
        {
            frmLogin obj = new frmLogin();
            DialogResult resul = obj.ShowDialog();
            if (resul == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private void kryptonRibbon1_ShowRibbonContextMenu(object sender, ComponentFactory.Krypton.Toolkit.ContextMenuArgs e)
        {
            e.Cancel = false;
            
        }
    }
}
