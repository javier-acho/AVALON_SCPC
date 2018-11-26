using Avalon.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Avalon.Aplicacion.Administracion
{
    public partial class frmMantBase : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmMantBase()
        {
            InitializeComponent();
            this.buttonSpecAny1.Image = new Utiles.ImagenesMenu().Imagenes.Images["Cerrar"];
            this.buttonSpecAny1.Click += ButtonSpecAny1_Click;
        }

        protected virtual void ButtonSpecAny1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnCrear_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnExportar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void frmMantBase_Load(object sender, EventArgs e)
        {
        }

        protected virtual void CrearColumnas(KryptonDataGridView gridDetalle)
        {

        }
    }
}
