using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLUsuarios
    {
        public BLLUsuarios()
        {
            objMPPus = new MPPUsuarios();
        }
        MPPUsuarios objMPPus;
        public List<BEClsEmpleado> ListarTodos()
        {
            return objMPPus.ListarTodos();
        }
        public List<BEClsEmpleado> ListarFalse()
        {
            return objMPPus.ListarFalse();
        }
        public List<BEClsEmpleado> ListarXApellido(string Apellido)
        {
            return objMPPus.ListarXApellido(Apellido);
        }
    }
}
