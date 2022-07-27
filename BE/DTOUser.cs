using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DTOUser
    {
        static string vNombre;
        static string vPuesto;

        private string Puesto;

        public string VPU
        {
            get { return vPuesto; }
            set 
            { 
                Puesto = value;
                vPuesto = Puesto;
            }
        }

        private string Nombre;

        public string VNN
        {
            get { return vNombre; }
            set 
            {
                Nombre = value;
                vNombre = Nombre;
            }
        }
    }
}
