using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalon.DTO;
using System.IO;
using System.Xml;
using System.Net;
using System.Net.NetworkInformation;

namespace Avalon.DAO.Base
{
    public class daoConexion
    {
        public static bool EsConexionLocal { get; private set; }
        public static string IpServer { get; private set; }
        public static string PassBD { get; private set; }
        public static string NomBD { get; set; }
        public static string UserBD { get; set; }

        public string StringCon { get; set; }
        public daoConexion()
        {
            CrearConexion();
            StringCon = "Data Source=" + IpServer + ";Initial Catalog=" + NomBD + "; User Id=" + UserBD+ "; Password=" + PassBD + ";";
        }

        private void CrearConexion()
        {
            dtoConexion dto = new dtoConexion();
            LeeConfiguracionConexion(dto);

            IpServer = dto.IpLocal;
            EsConexionLocal = true;

            if (ValidaIP(dto.IpLocal))
            {
                IpServer = dto.IpLocal;
                EsConexionLocal = true;
            }
            else
            {
                IpServer = dto.IpPublico;
                EsConexionLocal = false;
            }
            UserBD = dto.UserBD;
            NomBD = dto.NomBD;
            PassBD = dto.PassBD;
        }

        private bool ValidaIP(string ip)
        {
            bool ping_out = false;
            try
            {
                IPAddress ip_address;
                Ping ping_ip = new Ping();
                PingReply pr;
                string status;
                if (ip.Contains(","))
                {
                    int i = ip.IndexOf(",");
                    ip = ip.Substring(0, i);
                }
                ip_address = IPAddress.Parse(ip);

                pr = ping_ip.Send(ip);
                status = pr.Status.ToString();
                if (status == IPStatus.Success.ToString())
                {
                    ping_out = true;
                }
            }
            catch (Exception)
            {
                ping_out = false;
            }
            return ping_out;
        }

        private void LeeConfiguracionConexion(dtoConexion dto)
        {
            StringReader _Reader = new StringReader(Properties.Resources.Configuraciones);
            XmlTextReader _xmlReader = new XmlTextReader(_Reader);

            XmlDocument xDoc = new XmlDocument();
            //La ruta del documento XML permite rutas relativas 
            //respecto del ejecutable!
            xDoc.Load(_xmlReader);

            XmlNodeList configuraciones = xDoc.GetElementsByTagName("Configuraciones");
            XmlNodeList lista = ((XmlElement)configuraciones[0]).GetElementsByTagName("Configuracion");

            foreach (XmlElement nodo in lista)
            {
                dto.Estado = Convert.ToBoolean(nodo.GetAttribute("Estado"));

                if (dto.Estado)
                {
                    dto.Nombre = nodo.GetAttribute("Nombre");
                    dto.IpLocal = nodo.GetAttribute("IpLocal");
                    dto.IpPublico = nodo.GetAttribute("IpPublico");
                    dto.NomBD = nodo.GetAttribute("NomBD");
                    dto.UserBD = nodo.GetAttribute("UserBD");
                    dto.PassBD = nodo.GetAttribute("PassBD");
                    break;
                }
            }
        }
    }
}
