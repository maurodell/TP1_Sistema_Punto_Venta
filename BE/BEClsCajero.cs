using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsCajero : BEClsEmpleado
    {
        #region"Propiedad"
        public int NumCaja { get; set; }
        public BEClsCajero()
        {
            Puesto = "Cajero";
        }
        #endregion
    }
}
