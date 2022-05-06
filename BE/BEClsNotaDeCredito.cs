using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsNotaDeCredito : Entidad
    {
        public int Numero_doc { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public BEClsNotaDeCredito()
        {

        }
    }
}
