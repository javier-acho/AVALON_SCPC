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
    public partial class frmMantConceptos : frmMantBase
    {
       
        public frmMantConceptos()
        {
            InitializeComponent();
        }

        protected override void btnCrear_Click(object sender, EventArgs e)
        {
            base.btnCrear_Click(sender, e);
            MessageBox.Show("Este es del particular");
            
        }
        protected override void CrearColumnas(KryptonDataGridView gridDetalle)
        {
            base.CrearColumnas(gridDetalle);
            gridDetalle.Columns.Add("Col1", "Columna1");
        }
    }
}
