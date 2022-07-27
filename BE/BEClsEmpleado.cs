using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEClsEmpleado : Entidad
    {
        #region "Propiedades"
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Puesto { get; set; }
        //Agregación
        public BEClsSucursal Sucursal { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        private bool softDelete = true;
        public bool Soft_Delete
        {
            get { return softDelete; }
            set { softDelete = value; }
        }
        #endregion
    }
}
