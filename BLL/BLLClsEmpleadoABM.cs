using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstraccion;

namespace BLL
{
    public class BLLClsEmpleadoABM : Repositorio<BEClsEmpleado>
    {
        public BLLClsEmpleadoABM()
        {
            eMPP = new MPPEmpleado();
        }
        MPPEmpleado eMPP;
        public bool Crear(BEClsEmpleado objEmp)
        {
            return eMPP.Crear(objEmp);
        }

        public bool Eliminar(BEClsEmpleado objEmp)
        {
            throw new NotImplementedException();
        }

        public BEClsEmpleado Leer(BEClsEmpleado objEmp)
        {
            throw new NotImplementedException();
        }

        public List<BEClsEmpleado> ListarTodos()
        {
            return eMPP.ListarTodos();
        }

        public bool Modificar(BEClsEmpleado objEmp)
        {
            throw new NotImplementedException();
        }
    }
}
