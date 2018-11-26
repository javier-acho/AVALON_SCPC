using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.DAO.Interface
{
    public interface IDAO<T>
    {
        T ConsultaUno(T objectKey);
        List<T> ConsultarTodo();
        bool Agregar(T objeto);
        T Actualizar(T objectKey);
        bool Eliminar(T objectKey);
    }
}
