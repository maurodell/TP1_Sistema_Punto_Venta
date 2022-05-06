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
            return eMPP.Eliminar(objEmp);
        }
        public bool Alta(BEClsEmpleado objEmp)
        {
            return eMPP.Alta(objEmp);
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
            return eMPP.Modificar(objEmp);
        }
        public bool AsignarNC_Empleado(BEClsEmpleado objEmp, BEClsNotaDeCredito objNC)
        {
            return eMPP.AsignarNC_Empleado(objEmp, objNC);
        }
        public bool QuitarNC_Empleado(BEClsEmpleado objEmp, BEClsNotaDeCredito objNC)
        {
            return eMPP.QuitarNC_Empleado(objEmp, objNC);
        }
        public void ListarNC_Empleado(BEClsEmpleado objEmp)
        {
            eMPP.ListarNC_Empleado(objEmp);
        }
    }
}
