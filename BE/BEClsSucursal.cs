using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsSucursal : Entidad
    {
        #region "Propiedades"
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public override string ToString()
        {
            return Telefono + " " + Direccion;
        }
        #endregion
        #region "Construtores sobrecargados"
        public BEClsSucursal()
        {

        }
        public BEClsSucursal(string pDirección)
        {
            this.Direccion = pDirección;
        }
        #endregion
    }
}
