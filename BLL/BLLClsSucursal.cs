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

        public bool Crear(BEClsSucursal ObjetoBE)
        {
            return sucMPP.Crear(ObjetoBE);
        }

        public bool Eliminar(BEClsSucursal ObjetoBE)
        {
            return sucMPP.Eliminar(ObjetoBE);
        }

        public BEClsSucursal Leer(BEClsSucursal ObjetoBE)
        {
            throw new NotImplementedException();
        }

        public List<BEClsSucursal> ListarTodos()
        {
            return sucMPP.ListarTodos();
        }

        public bool Modificar(BEClsSucursal ObjetoBE)
        {
            return sucMPP.Modificar(ObjetoBE);
        }
    }
}
