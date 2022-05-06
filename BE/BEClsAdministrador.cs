using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsAdministrador : BEClsEmpleado
    {
        //Random rnd = new Random();
        //public int codAuth { get; set; }

        public BEClsAdministrador()
        {
            //codAuth = rnd.Next(0,1500);
            Puesto = "Administrativo";
        }
        //public int AuthCod()
        //{
        //    return codAuth;
        //}
    }
}
