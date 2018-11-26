using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DTO
{
    [Serializable]
    public class dtoConcepto : dtoBase
    {
        public dtoConcepto()
        {
        }
        
        public string Propiedad { get; set; }
    }
}
