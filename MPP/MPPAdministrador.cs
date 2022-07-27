using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using DAL;
using Abstraccion;
using BE;

namespace MPP
{
    public class MPPAdministrador : Repositorio<BEClsAdministrador>
    {
        public MPPAdministrador()
        {
            objDatos = new DatosBD();
        }
        DatosBD objDatos;
        Hashtable Hdatos;
        public bool Crear(BEClsAdministrador Objeto)
        {
            Hdatos = new Hashtable();
            string consulta = "Crear_Adminstrativo";
            //si es diferente de cero, es para modificar el empleado.
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@idEmpleado", Objeto.Codigo);
                consulta = "Administrativo_Modificar";
            }

            Hdatos.Add("@Nom", Objeto.Nombre);
            Hdatos.Add("@Ape", Objeto.Apellido);
            Hdatos.Add("@DNI", Objeto.DNI);
            Hdatos.Add("@Puesto", Objeto.Puesto);
            Hdatos.Add("@idS", Objeto.Sucursal.Codigo);
            Hdatos.Add("@Email", Objeto.Email);
            Hdatos.Add("@Pass", Objeto.Pass);
            Hdatos.Add("@Delete", true);

            if (VerificarExistenciaXDNI(Objeto) == false)
            {
                return objDatos.Escribir(consulta, Hdatos);
            }
            else
            {
                return false;
            }
        }

        bool VerificarExistenciaXDNI(BEClsAdministrador Objeto)
        {
            Hashtable Hdatos2 = new Hashtable();
            //SqlParameter param = new SqlParameter();

            if (Objeto.Codigo == 0)
            {
                Hdatos2.Add("@DNI", Objeto.DNI);
                return objDatos.LeerScalar("Empleado_Existe_DNI", Hdatos2);
            }
            else
            {
                return false;
            }
        }

        public bool Baja(int Objeto)
        {
            Hdatos = new Hashtable();
            string Consulta = "Empleado_Baja";

            Hdatos.Add("@idEmpleado", Objeto);
            Hdatos.Add("@Delete", false);

            return objDatos.Escribir(Consulta, Hdatos);
        }
        public List<BEClsAdministrador> ListarBusquedaApellido(BEClsAdministrador Objeto)
        {
            List<BEClsAdministrador> listaAd = new List<BEClsAdministrador>();
            string Consulta = "Listar_Por_Apellido";
            Hdatos = new Hashtable();
            Hdatos.Add("@Apellido", Objeto.Apellido);

            DataTable Table = objDatos.Leer(Consulta, Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    BEClsAdministrador objAdmin = new BEClsAdministrador();
                    objAdmin.Codigo = Convert.ToInt32(fila["Codigo"]);
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
                    listaAd.Add(objAdmin);
                }
                return listaAd;
            }
            else
            {
                return null;
            }
        }

        public BEClsAdministrador LeerObjeto(int Objeto)
        {
            Hdatos = new Hashtable();
            Hdatos.Add("@DNI", Objeto);
            DataTable Table = objDatos.Leer("Buscar_X_DNI", Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
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

                    BEClsSucursal oBESuc = new BEClsSucursal();
                    oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                    oBESuc.Telefono = fila["Telefono"].ToString();
                    oBESuc.Direccion = fila["Direccion"].ToString();
                    objAdmin.Sucursal = oBESuc;
                    return objAdmin;
                }
            }
            return null;
        }
        public bool Alta(int Objeto)
        {
            Hdatos = new Hashtable();
            string Consulta = "Empleado_Alta";

            Hdatos.Add("@idEmpleado", Objeto);
            Hdatos.Add("@Delete", true);

            return objDatos.Escribir(Consulta, Hdatos);
        }
        public bool AsociarEmpleadoNC(BEClsEmpleado oBEEmp, BEClsNotaDeCredito oBENC)
        {
            string consulta = "Asociar_Empleado_NC";
            Hdatos = new Hashtable();

            Hdatos.Add("@idEmpleado", oBEEmp.Codigo);
            Hdatos.Add("@idNC", oBENC.Codigo);

            if (Existe_Empleado_Asociada(oBENC.Codigo) == false)
            {
                return objDatos.Escribir(consulta, Hdatos);
            }
            else
            {
                return false;
            }
            
        }
        public bool Existe_Empleado_Asociada(int objNC)
        {
            Hashtable Hdatos2 = new Hashtable();

            if (objNC != 0)
            {
                Hdatos2.Add("@idNC", objNC);
                return objDatos.LeerScalar("NotaCredito_Existe", Hdatos2);
            }
            else
            {
                return false;
            }
        }
    }
}
