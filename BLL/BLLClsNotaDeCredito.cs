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
    public class BLLClsNotaDeCredito : Repositorio<BEClsNotaDeCredito>
    {
        public BLLClsNotaDeCredito()
        {
            oMPPNotaCred = new MPPNotaDeCredito();
        }
        MPPNotaDeCredito oMPPNotaCred;

        public bool Crear(BEClsNotaDeCredito Objeto)
        {
            return oMPPNotaCred.Crear(Objeto);
        }

        public bool Baja(BEClsNotaDeCredito Objeto)
        {
            return oMPPNotaCred.Baja(Objeto);
        }

        public List<BEClsNotaDeCredito> ListarBusquedaApellido(BEClsNotaDeCredito Objeto)
        {
            throw new NotImplementedException();
        }

        public BEClsNotaDeCredito LeerObjeto(int Objeto)
        {
            return oMPPNotaCred.LeerObjeto(Objeto);
        }
        public List<BEClsNotaDeCredito> ListarTodos()
        {
            return oMPPNotaCred.ListarTodos();
        }
        public List<BEClsNotaDeCredito> ListarNC_Empleado(BEClsEmpleado Objeto)
        {
            return oMPPNotaCred.ListarNC_Empleado(Objeto);
        }
        public bool Existe_Empleado_Asociada(BEClsNotaDeCredito objNC)
        {
            return oMPPNotaCred.Existe_Empleado_Asociada(objNC);
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
