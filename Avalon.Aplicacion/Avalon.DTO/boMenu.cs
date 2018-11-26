using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DTO
{
    public class boMenu: dtoBase
    {
        public string CodMenu { get; set; }
        public int ImageIndex { get; set; }
        public string NomMenu { get; set; }
        public bool Estado { get; set; }
    }
}
