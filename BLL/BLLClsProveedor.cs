using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;
using Abstraccion;

namespace BLL
{
    public class BLLClsProveedor : Repositorio<BEClsProveedor>
    {
        public BLLClsProveedor()
        {
            MPPProveedor = new MPPProveedor();
        }
        MPPProveedor MPPProveedor;
        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int Objeto)
        {
            return MPPProveedor.Baja(Objeto);
        }

        public bool Crear(BEClsProveedor Objeto)
        {
            return MPPProveedor.Crear(Objeto);
        }
        public bool Modificar(BEClsProveedor Objeto)
        {
            return MPPProveedor.Modificar(Objeto);
        }
        public BEClsProveedor LeerObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEClsProveedor> BuscarXNombre(string Objeto)
        {
            return MPPProveedor.BuscarXNombre(Objeto);
        }
        public List<BEClsProveedor> ListarBusquedaApellido(BEClsProveedor Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEClsProveedor> ListarTodos()
        {
            return MPPProveedor.ListarTodos();
        }
    }
}
