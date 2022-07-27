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
        bool Baja(int Objeto);
        bool Alta(int Objeto);
        List<T> ListarBusquedaApellido(T Objeto);
        T LeerObjeto(int Objeto);
    }
}
