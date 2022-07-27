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
    public class BLLClsSucursal : Repositorio<BEClsSucursal>
    {
        MPPSucursal sucMPP;

        public BLLClsSucursal()
        {
            sucMPP = new MPPSucursal();
        }

        public bool Baja(BEClsSucursal Objeto)
        {
            return sucMPP.Baja(Objeto);
        }

        public bool Crear(BEClsSucursal Objeto)
        {
            return sucMPP.Crear(Objeto);
        }

        public BEClsSucursal LeerObjeto(int Objeto)
        {
            return sucMPP.LeerObjeto(Objeto);
        }

        public List<BEClsSucursal> ListarTodos()
        {
            return sucMPP.ListarTodos();
        }

        public List<BEClsSucursal> ListarBusquedaApellido(BEClsSucursal Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
