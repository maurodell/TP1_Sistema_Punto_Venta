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
    public class MPPCajero : Repositorio<BEClsCajero>
    {
        public MPPCajero()
        {
            objDatos = new DatosBD();
        }
        DatosBD objDatos;
        Hashtable Hdatos;
        public bool Crear(BEClsCajero Objeto)
        {
            string consulta = "Crear_Cajero";
            Hdatos = new Hashtable();

            //si es diferente de cero, es para modificar el empleado.
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@idEmpleado", Objeto.Codigo);
                consulta = "Cajero_Modificar";
            }
            Hdatos.Add("@Nom", Objeto.Nombre);
            Hdatos.Add("@Ape", Objeto.Apellido);
            Hdatos.Add("@DNI", Objeto.DNI);
            Hdatos.Add("@Puesto", Objeto.Puesto);
            Hdatos.Add("@idS", Objeto.Sucursal.Codigo);
            Hdatos.Add("@Email", Objeto.Email);
            Hdatos.Add("@Pass", Objeto.Pass);
            Hdatos.Add("@NumC", Objeto.NumCaja);
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
        bool VerificarExistenciaXDNI(BEClsCajero Objeto)
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
            throw new NotImplementedException();
        }

        public List<BEClsCajero> ListarBusquedaApellido(BEClsCajero Objeto)
        {
            List<BEClsCajero> listaCaj = new List<BEClsCajero>();
            string Consulta = "Listar_Por_Apellido";
            Hdatos = new Hashtable();
            Hdatos.Add("@Apellido", Objeto.Apellido);

            DataTable Table = objDatos.Leer(Consulta, Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
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

                    BEClsSucursal oBESuc = new BEClsSucursal();
                    oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                    oBESuc.Telefono = fila["Telefono"].ToString();
                    oBESuc.Direccion = fila["Direccion"].ToString();
                    objCajero.Sucursal = oBESuc;
                    listaCaj.Add(objCajero);
                }
                return listaCaj;
            }
            else
            {
                return null;
            }
        }

        public BEClsCajero LeerObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
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
        public bool QuitarEmpleadoNC(BEClsNotaDeCredito oBENC)
        {
            string consulta = "Quitar_Empleado_NC";
            Hdatos = new Hashtable();

            Hdatos.Add("@idNC", oBENC.Codigo);

            return objDatos.Escribir(consulta, Hdatos);
        }
    }
}
