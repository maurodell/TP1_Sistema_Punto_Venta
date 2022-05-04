using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface Repositorio<T> where T : IEntidad
    {
        bool Crear(T Objeto);
        T Leer(T Objeto);
        bool Modificar(T Objeto);
        bool Eliminar(T Objeto);
        List<T> ListarTodos();
    }
}
