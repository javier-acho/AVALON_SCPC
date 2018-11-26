using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Avalon.Utiles;

namespace Avalon.DTO
{
    public class dtoBase: ICloneable
    {
        public bool HuboError { get; set; }
        public string MensajeError { get; set; }

        public object Clone()
        {
            return Utiles.Utiles.Copia(this);
        }
    }
}
