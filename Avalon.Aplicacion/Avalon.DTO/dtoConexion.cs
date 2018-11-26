using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DTO
{
    public class dtoConexion
    {
        public string Nombre { get; set; }
        public string IpLocal { get; set; }
        public string IpPublico { get; set; }
        public string NomBD { get; set; }
        public string UserBD { get; set; }
        public string PassBD { get; set; }
        public bool Estado { get; set; }
        public bool UsaRemoto { get; set; }
        public bool EsConexionLocal { get; set; }
        public bool Lcn { get; set; }
    }
}
