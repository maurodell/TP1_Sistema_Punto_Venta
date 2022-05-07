using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Seguridad;


namespace MPP
{
    public class MPPLogin
    {
        public MPPLogin()
        {
            seg = new ClsEncriptar();
        }
        Acceso oDatos;
        ClsEncriptar seg;
        public bool ConsultarUsuario(string email, string pass)
        {
            DataTable Dt;
            bool flag = false;
            //string password = seg.Encriptar(pass);
            string passBD = "";
            string consulta = "SELECT Pass FROM Empleado WHERE Email = '" + email + "'";
            Dt = oDatos.Leer(consulta);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow fila in Dt.Rows)
                {
                    passBD = fila[0].ToString();
                }
            }
            if (passBD.Equals(seg.Encriptar(pass)))
            {
                return flag = true;
            }
            //return oDatos.Escribir(consulta);
            return flag;
        }
        public string Get(string email, string pass)
        {
            oDatos = new Acceso();
            string consulta = "SELECT Pass FROM Empleado WHERE Email = '" + email + "'";
            return oDatos.Get(consulta);
        }
    }
}
