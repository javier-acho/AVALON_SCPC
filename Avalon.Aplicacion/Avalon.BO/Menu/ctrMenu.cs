using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalon.DTO;
using ComponentFactory.Krypton.Navigator;
using Avalon.Utiles;

namespace Avalon.BO.Menu
{
    public class ctrMenu
    {
        List<boMenu> menuPerfil;
        public ctrMenu(/*List<boMenu> menu*/)
        {
            //menuPerfil = menu;
            CrearMenuDemo(ref menuPerfil);
        }

        private void CrearMenuDemo(ref List<boMenu> menuPerfil)
        {
            menuPerfil = new List<boMenu>();
            boMenu oMenu = new boMenu();
            oMenu.CodMenu = "02";
            oMenu.ImageIndex = 0;
            oMenu.NomMenu = "Cobros";
            oMenu.Estado = true;
            menuPerfil.Add(oMenu);
            /**********************************************/
            boMenu oSubMenu1 = new boMenu();
            oSubMenu1.CodMenu = "0201";
            oSubMenu1.ImageIndex = 0;
            oSubMenu1.NomMenu = "Cobro de Conceptos";
            oSubMenu1.Estado = true;
            menuPerfil.Add(oSubMenu1);

            boMenu oSubMenu1A = new boMenu();
            oSubMenu1A.CodMenu = "020101";
            oSubMenu1A.ImageIndex = 0;
            oSubMenu1A.NomMenu = "Crear Conceptos";
            oSubMenu1A.Estado = true;
            menuPerfil.Add(oSubMenu1A);
        
            boMenu oSubMenu1B = new boMenu();
            oSubMenu1B.CodMenu = "020102";
            oSubMenu1B.ImageIndex = 0;
            oSubMenu1B.NomMenu = "Configurar Conceptos";
            oSubMenu1B.Estado = true;
            menuPerfil.Add(oSubMenu1B);

            boMenu oSubMenu1C = new boMenu();
            oSubMenu1C.CodMenu = "020103";
            oSubMenu1C.ImageIndex = 0;
            oSubMenu1C.NomMenu = "Cobro Conceptos";
            oSubMenu1C.Estado = true;
            menuPerfil.Add(oSubMenu1C);
            /**********************************************/
            boMenu oSubMenu2 = new boMenu();
            oSubMenu2.CodMenu = "0202";
            oSubMenu2.ImageIndex = 0;
            oSubMenu2.NomMenu = "Cobro de Otros Ingresos";
            oSubMenu2.Estado = true;
            menuPerfil.Add(oSubMenu2);
            /***********************************************/

            boMenu oMenu2 = new boMenu();
            oMenu2.CodMenu = "03";
            oMenu2.ImageIndex = 0;
            oMenu2.NomMenu = "Pagos";
            oMenu2.Estado = true;
            menuPerfil.Add(oMenu2);

            boMenu oSubMenu3 = new boMenu();
            oSubMenu3.CodMenu = "0301";
            oSubMenu3.ImageIndex = 0;
            oSubMenu3.NomMenu = "Creacion de Proveedores";
            oSubMenu3.Estado = true;
            menuPerfil.Add(oSubMenu3);

            boMenu oSubMenu4 = new boMenu();
            oSubMenu4.CodMenu = "0302";
            oSubMenu4.ImageIndex = 0;
            oSubMenu4.NomMenu = "Documentos Pago";
            oSubMenu4.Estado = true;
            menuPerfil.Add(oSubMenu4);

            boMenu oSubMenu5 = new boMenu();
            oSubMenu5.CodMenu = "030201";
            oSubMenu5.ImageIndex = 0;
            oSubMenu5.NomMenu = "Crear Items";
            oSubMenu5.Estado = true;
            menuPerfil.Add(oSubMenu5);

            boMenu oSubMenu6 = new boMenu();
            oSubMenu6.CodMenu = "030202";
            oSubMenu6.ImageIndex = 0;
            oSubMenu6.NomMenu = "Crear Documento";
            oSubMenu6.Estado = true;
            menuPerfil.Add(oSubMenu6);

        }

        public void CrearMenu(ref KryptonNavigator navigator/*, List<boMenu> menuPerfil*/)
        {
            //navigator.Pages.Add(new KryptonPage());
            foreach (var oMenu in menuPerfil.Where(x=>x.CodMenu.Length==2).ToList())
            {
                KryptonPage pagina = new KryptonPage();
                pagina.Text = oMenu.NomMenu;
                pagina.Name = oMenu.CodMenu;
                pagina.TextTitle = oMenu.NomMenu;
                pagina.LastVisibleSet = true;
                pagina.ToolTipTitle = oMenu.NomMenu;

                KryptonTreeView treeMenu = new KryptonTreeView();
                ImagenesMenu imagenList = new ImagenesMenu();
                treeMenu.Dock = DockStyle.Fill;
                treeMenu.Name = "tree" + oMenu.CodMenu;
                treeMenu.ImageList = imagenList.Imagenes;
                treeMenu.TabIndex = oMenu.CodMenu.Length / 2;

                ArmarMenuTree(treeMenu, menuPerfil.Where(x => x.CodMenu.StartsWith(oMenu.CodMenu)));


                pagina.Controls.Add(treeMenu);

                navigator.Pages.Add(pagina);

            }
        }

        private void ArmarMenuTree(KryptonTreeView treeMenu, IEnumerable<boMenu> enumerable)
        {
            foreach (var oSubMenu in enumerable.Where(x=>x.CodMenu.Length>2).OrderBy(x=> x.CodMenu))
            {
                AgregarNodo(treeMenu.Nodes, oSubMenu, oSubMenu.CodMenu, 2);
            }
        }

        private void AgregarNodo(TreeNodeCollection nodes, boMenu oSubMenu, string codMenu, int nivel)
        {
            string padre = oSubMenu.CodMenu.Substring(0, nivel * 2);
            if (oSubMenu.CodMenu.Length.Equals(nivel * 2) || !nodes.ContainsKey(padre))
            {
                KryptonTreeNode hijo = new KryptonTreeNode();
                hijo.Name = oSubMenu.CodMenu;
                hijo.Text = oSubMenu.NomMenu;
                hijo.ImageIndex = 0;
                nodes.Add(hijo);
            }
            else
                AgregarNodo(nodes[padre].Nodes, oSubMenu, padre, nivel + 1);
        }

        private KryptonTreeNode CreateNewItem(string texto)
        {
            KryptonTreeNode item = new KryptonTreeNode();
            item.Text = texto;
            item.ImageIndex = 0;
            item.SelectedImageIndex = item.ImageIndex;
            return item;
        }
    }
}
