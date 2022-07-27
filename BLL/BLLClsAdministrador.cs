using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
using MPP;

namespace BLL
{
    public class BLLClsAdministrador : BLLClsEmpleado, Repositorio<BEClsAdministrador>
    {
        public BLLClsAdministrador()
        {
            objMPPadm = new MPPAdministrador();
        }
        MPPAdministrador objMPPadm;
        public bool Crear(BEClsAdministrador Objeto)
        {
            return objMPPadm.Crear(Objeto);
        }
        //el empleado de tipo administrativo puede agregar descuentos de 30%
        public override double DescuentoEmpleado(double monto)
        {
            return monto * 0.70;
        }

        public bool Baja(int Objeto)
        {
            return objMPPadm.Baja(Objeto);
        }
        public List<BEClsAdministrador> ListarBusquedaApellido(BEClsAdministrador Objeto)
        {
            return objMPPadm.ListarBusquedaApellido(Objeto);
        }

        public BEClsAdministrador LeerObjeto(int Objeto)
        {
            return objMPPadm.LeerObjeto(Objeto);
        }
        public bool Alta(int Objeto)
        {
            return objMPPadm.Alta(Objeto);
        }
        public bool AsociarEmpleadoNC(BEClsEmpleado oBEEmp, BEClsNotaDeCredito oBENC)
        {
            return objMPPadm.AsociarEmpleadoNC(oBEEmp, oBENC);
        }
    }
}
