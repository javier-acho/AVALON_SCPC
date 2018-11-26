using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalon.Utiles.Properties;

namespace Avalon.Utiles
{
    public class ImagenesMenu
    {
        public ImageList Imagenes { get; set; }

        public ImagenesMenu()
        {
            ImageList imagenesMenu = new ImageList();
            imagenesMenu.Images.Add("IconoCerrado", Utiles.Properties.Resources.MenuCerrado);
            imagenesMenu.Images.Add("IconoAbierto", Utiles.Properties.Resources.MenuAbierto);
            imagenesMenu.Images.Add("IconoItem", Utiles.Properties.Resources.MenuItem);
            imagenesMenu.Images.Add("IconApp", Utiles.Properties.Resources.IconApp);
            imagenesMenu.Images.Add("LogoApp", Utiles.Properties.Resources.LogoApp);
            imagenesMenu.Images.Add("Cerrar", Utiles.Properties.Resources.cross);

            Imagenes = imagenesMenu;
        }
    }
}
