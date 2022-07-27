using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using BE;
using Abstraccion;
using DAL;

namespace MPP
{
    public class MPPUsuarios
    {
        public MPPUsuarios()
        {
            objDatos = new DatosBD();
        }
        DatosBD objDatos;
        Hashtable Hdatos;
        public List<BEClsEmpleado> ListarTodos()
        {
            List<BEClsEmpleado> listaEmp = new List<BEClsEmpleado>();

            string Consulta = "Listar_Empleados";

            DataTable Table = objDatos.Leer(Consulta, null);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    if (fila["NumCaja"] is DBNull)
                    {
                        BEClsAdministrador objAdmin = new BEClsAdministrador();
                        objAdmin.Codigo = Convert.ToInt32(fila[0]);
                        objAdmin.Nombre = fila["Nombre"].ToString();
                        objAdmin.Apellido = fila["Apellido"].ToString();
                        objAdmin.DNI = Convert.ToInt32(fila["DNI"]);
                        objAdmin.Puesto = fila["Puesto"].ToString();
                        objAdmin.Email = fila["Email"].ToString();
                        objAdmin.Pass = fila["Pass"].ToString();
                        objAdmin.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objAdmin.Sucursal = oBESuc;
                        listaEmp.Add(objAdmin);
                    }
                    else
                    {
                        BEClsCajero objCaj = new BEClsCajero();
                        objCaj.Codigo = Convert.ToInt32(fila[0]);
                        objCaj.Nombre = fila["Nombre"].ToString();
                        objCaj.Apellido = fila["Apellido"].ToString();
                        objCaj.DNI = Convert.ToInt32(fila["DNI"]);
                        objCaj.Puesto = fila["Puesto"].ToString();
                        objCaj.Email = fila["Email"].ToString();
                        objCaj.NumCaja = Convert.ToInt32(fila["NumCaja"]);
                        objCaj.Pass = fila["Pass"].ToString();
                        objCaj.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objCaj.Sucursal = oBESuc;
                        listaEmp.Add(objCaj);
                    }
                }
            }
            return listaEmp;
        }
        public List<BEClsEmpleado> ListarFalse()
        {
            List<BEClsEmpleado> listaEmp = new List<BEClsEmpleado>();

            string Consulta = "Listar_Empleado_Todos";

            DataTable Table = objDatos.Leer(Consulta, null);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    if (fila["NumCaja"] is DBNull)
                    {
                        BEClsAdministrador objAdmin = new BEClsAdministrador();
                        objAdmin.Codigo = Convert.ToInt32(fila[0]);
                        objAdmin.Nombre = fila["Nombre"].ToString();
                        objAdmin.Apellido = fila["Apellido"].ToString();
                        objAdmin.DNI = Convert.ToInt32(fila["DNI"]);
                        objAdmin.Puesto = fila["Puesto"].ToString();
                        objAdmin.Email = fila["Email"].ToString();
                        objAdmin.Pass = fila["Pass"].ToString();
                        objAdmin.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objAdmin.Sucursal = oBESuc;
                        listaEmp.Add(objAdmin);
                    }
                    else
                    {
                        BEClsCajero objCaj = new BEClsCajero();
                        objCaj.Codigo = Convert.ToInt32(fila[0]);
                        objCaj.Nombre = fila["Nombre"].ToString();
                        objCaj.Apellido = fila["Apellido"].ToString();
                        objCaj.DNI = Convert.ToInt32(fila["DNI"]);
                        objCaj.Puesto = fila["Puesto"].ToString();
                        objCaj.Email = fila["Email"].ToString();
                        objCaj.NumCaja = Convert.ToInt32(fila["NumCaja"]);
                        objCaj.Pass = fila["Pass"].ToString();
                        objCaj.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objCaj.Sucursal = oBESuc;
                        listaEmp.Add(objCaj);
                    }
                }
            }
            return listaEmp;
        }
        public List<BEClsEmpleado> ListarXApellido(string Apellido)
        {
            List<BEClsEmpleado> listaEmp = new List<BEClsEmpleado>();

            Hdatos = new Hashtable();
            Hdatos.Add("@Apellido", Apellido);

            string Consulta = "Listar_X_Apellido";

            DataTable Table = objDatos.Leer(Consulta, Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    if (fila["NumCaja"] is DBNull)
                    {
                        BEClsAdministrador objAdmin = new BEClsAdministrador();
                        objAdmin.Codigo = Convert.ToInt32(fila[0]);
                        objAdmin.Nombre = fila["Nombre"].ToString();
                        objAdmin.Apellido = fila["Apellido"].ToString();
                        objAdmin.DNI = Convert.ToInt32(fila["DNI"]);
                        objAdmin.Puesto = fila["Puesto"].ToString();
                        objAdmin.Email = fila["Email"].ToString();
                        objAdmin.Pass = fila["Pass"].ToString();
                        objAdmin.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objAdmin.Sucursal = oBESuc;
                        listaEmp.Add(objAdmin);
                    }
                    else
                    {
                        BEClsCajero objCaj = new BEClsCajero();
                        objCaj.Codigo = Convert.ToInt32(fila[0]);
                        objCaj.Nombre = fila["Nombre"].ToString();
                        objCaj.Apellido = fila["Apellido"].ToString();
                        objCaj.DNI = Convert.ToInt32(fila["DNI"]);
                        objCaj.Puesto = fila["Puesto"].ToString();
                        objCaj.Email = fila["Email"].ToString();
                        objCaj.NumCaja = Convert.ToInt32(fila["NumCaja"]);
                        objCaj.Pass = fila["Pass"].ToString();
                        objCaj.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                        BEClsSucursal oBESuc = new BEClsSucursal();
                        oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                        oBESuc.Telefono = fila["Telefono"].ToString();
                        oBESuc.Direccion = fila["Direccion"].ToString();
                        objCaj.Sucursal = oBESuc;
                        listaEmp.Add(objCaj);
                    }
                }
            }
            return listaEmp;
        }
    }
}
