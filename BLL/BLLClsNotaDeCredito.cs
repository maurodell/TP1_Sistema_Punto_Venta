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
        public bool Crear(BEClsNotaDeCredito objNC)
        {
            return oMPPNotaCred.Crear(objNC);
        }

        public bool Eliminar(BEClsNotaDeCredito objNC)
        {
            return oMPPNotaCred.Eliminar(objNC);
        }

        public BEClsNotaDeCredito Leer(BEClsNotaDeCredito objNC)
        {
            return oMPPNotaCred.Leer(objNC);
        }

        public List<BEClsNotaDeCredito> ListarTodos()
        {
            return oMPPNotaCred.ListarTodos();
        }

        public bool Modificar(BEClsNotaDeCredito objNC)
        {
            return oMPPNotaCred.Modificar(objNC);
        }
    }
}
