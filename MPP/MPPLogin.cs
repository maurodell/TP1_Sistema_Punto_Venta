using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Seguridad;
using System.Collections;
using BE;


namespace MPP
{
    public class MPPLogin
    {
        public MPPLogin()
        {
            objDatos = new DatosBD();
            seg = new ClsEncriptar();
        }
        DatosBD objDatos;
        Hashtable Hdatos;
        ClsEncriptar seg;
        public bool ConsultarUsuario(string email, string pass)
        {
            DataTable Dt;
            bool flag = false;
            //string password = seg.Encriptar(pass);
            string passBD = "";
            string consulta = "Login_Email";
            Dt = objDatos.Leer(consulta, null);
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
        public BEClsEmpleado Get(string email)
        {
            Hdatos = new Hashtable();
            Hdatos.Add("@Email", email);
            DataTable Table = objDatos.Leer("Seleccionar_Usuario", Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    if (fila["NumCaja"] is DBNull)
                    {
                        BEClsAdministrador objAdmin = new BEClsAdministrador();
                        objAdmin.Codigo = Convert.ToInt32(fila["idEmpleado"]);
                        objAdmin.Nombre = fila["Nombre"].ToString();
                        objAdmin.Apellido = fila["Apellido"].ToString();
                        objAdmin.DNI = Convert.ToInt32(fila["DNI"]);
                        objAdmin.Puesto = fila["Puesto"].ToString();
                        objAdmin.Email = fila["Email"].ToString();
                        objAdmin.Pass = fila["Pass"].ToString();
                        objAdmin.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        return objAdmin;
                    }
                    else
                    {
                        BEClsCajero objCajero = new BEClsCajero();
                        objCajero.Codigo = Convert.ToInt32(fila["idEmpleado"]);
                        objCajero.Nombre = fila["Nombre"].ToString();
                        objCajero.Apellido = fila["Apellido"].ToString();
                        objCajero.DNI = Convert.ToInt32(fila["DNI"]);
                        objCajero.Puesto = fila["Puesto"].ToString();
                        objCajero.Email = fila["Email"].ToString();
                        objCajero.Pass = fila["Pass"].ToString();
                        objCajero.NumCaja = Convert.ToInt32(fila["NumCaja"]);
                        objCajero.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        return objCajero;
                    }
                }
            }
            return null;
        }
    }
}
