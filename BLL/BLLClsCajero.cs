using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using MPP;
using BE;

namespace BLL
{
    public class BLLClsCajero : BLLClsEmpleado, Repositorio<BEClsCajero>
    {
        public BLLClsCajero()
        {
            objMPPcaj = new MPPCajero();
        }
        MPPCajero objMPPcaj;
        public bool Crear(BEClsCajero Objeto)
        {
            return objMPPcaj.Crear(Objeto);
        }
        //el empleado de tipo cajero puede hacer descuentos de 10%
        public override double DescuentoEmpleado(double monto)
        {
            return monto * 0.90;
        }

        public bool Baja(int Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BEClsCajero> ListarBusquedaApellido(BEClsCajero Objeto)
        {
            return objMPPcaj.ListarBusquedaApellido(Objeto);
        }

        public BEClsCajero LeerObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
        }
        public bool AsociarEmpleadoNC(BEClsEmpleado oBEEmp, BEClsNotaDeCredito oBENC)
        {
            return objMPPcaj.AsociarEmpleadoNC(oBEEmp, oBENC);
        }
        public bool QuitarEmpleadoNC(BEClsNotaDeCredito oBENC)
        {
            return objMPPcaj.QuitarEmpleadoNC(oBENC);
        }
    }
}
