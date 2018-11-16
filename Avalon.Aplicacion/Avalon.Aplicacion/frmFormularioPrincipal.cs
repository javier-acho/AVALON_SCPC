using Avalon.Aplicacion.Seguridad;
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

        private void frmFormularioPrincipal_Load(object sender, EventArgs e)
        {
            KryptonTreeNode nodo = CreateNewItem("Menu1");
            tvMenu.Nodes.Add(nodo);

            KryptonTreeNode nodoAux1 = CreateNewItem("SubMenu1");
            nodo.Nodes.Add(nodoAux1);

            KryptonTreeNode nodo1 = CreateNewItem("Menu2");
            tvMenu.Nodes.Add(nodo1);

            KryptonTreeNode nodo2 = CreateNewItem("Menu3");
            tvMenu.Nodes.Add(nodo2);

            KryptonTreeNode nodo3 = CreateNewItem("Menu4");
            tvMenu.Nodes.Add(nodo3);

            KryptonTreeNode nodo4 = CreateNewItem("Menu5");
            tvMenu.Nodes.Add(nodo4);

            if (tvMenu.SelectedNode == null)
                tvMenu.SelectedNode = nodo;
        }
        private KryptonTreeNode CreateNewItem(string texto)
        {
            KryptonTreeNode item = new KryptonTreeNode();
            item.Text = texto;
            //item.ImageIndex = _rand.Next(imageList.Images.Count - 1);
            //item.SelectedImageIndex = item.ImageIndex;
            return item;
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string texto = e.Node.Text;
            KryptonMessageBox.Show(e.Node.NextNode == null && e.Node.Level != 0 ? "Es Hoja" : "es del menu");
        }
    }
}
