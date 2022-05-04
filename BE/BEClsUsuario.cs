using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsUsuario
    {
        private static BEClsUsuario instancia;
        public static BEClsUsuario Instanciar()
        {
            if (instancia == null)
            {
                instancia = new BEClsUsuario();
            }
            return instancia;
        }
        private BEClsUsuario()
        {
            listaEmpleados = new List<BEClsEmpleado>();
        }

        public List<BEClsEmpleado> listaEmpleados { get; set; }
    }
}
