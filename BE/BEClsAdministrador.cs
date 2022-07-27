using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsAdministrador : BEClsEmpleado
    {
        #region"Propiedad"
        //Composición
        public List<BEClsNotaDeCredito> ListaNC = new List<BEClsNotaDeCredito>();
        public BEClsAdministrador()
        {
            Puesto = "Administrativo";
        }
        #endregion
    }
}
