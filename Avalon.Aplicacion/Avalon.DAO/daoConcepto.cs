using Avalon.DAO.Base;
using Avalon.DAO.Interface;
using Avalon.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DAO
{
    class daoConcepto : daoB, IDAO<dtoConcepto>
    {
        public daoConcepto()
        {
        }
        public dtoConcepto Actualizar(dtoConcepto objectKey)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(dtoConcepto objeto)
        {
            throw new NotImplementedException();
        }

        public List<dtoConcepto> ConsultarTodo()
        {
            throw new NotImplementedException();
        }

        public dtoConcepto ConsultaUno(dtoConcepto objectKey)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(dtoConcepto objectKey)
        {
            throw new NotImplementedException();
        }
    }
}
