using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Abstraccion;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace MPP
{
    public class MPPSucursal : Repositorio<BEClsSucursal>
    {
        public MPPSucursal()
        {
            objDatos = new DatosBD();
        }
        DatosBD objDatos;
        Hashtable Hdatos;

        public bool Crear(BEClsSucursal Objeto)
        {
            string consulta = "Alta_Sucursal";
            Hdatos = new Hashtable();

            //si es diferente de cero, es para modificar el empleado.
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@idSuc", Objeto.Codigo);
                consulta = "Sucursal_Modificar";
            }

            Hdatos.Add("@Tel", Objeto.Telefono);
            Hdatos.Add("@Dir", Objeto.Direccion);

            return objDatos.Escribir(consulta, Hdatos);
        }

        public bool Baja(BEClsSucursal Objeto)
        {
            if (ExisteSucAsociada(Objeto) == false)
            {
                Hdatos = new Hashtable();
                Hdatos.Add("@idSuc", Objeto.Codigo);

                return objDatos.Escribir("Sucursal_Baja", Hdatos);
            }
            else
            {
                return false;
            }

        }

        public List<BEClsSucursal> ListarBusquedaApellido(BEClsSucursal Objeto)
        {
            throw new NotImplementedException();
        }

        public BEClsSucursal LeerObjeto(int Objeto)
        {
            Hdatos = new Hashtable();
            Hdatos.Add("@idSuc", Objeto);
            DataTable Table = objDatos.Leer("Buscar_X_DNI", Hdatos);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    BEClsSucursal sucObj = new BEClsSucursal();
                    sucObj.Codigo = Convert.ToInt32(fila[0]);
                    sucObj.Telefono = fila[1].ToString();
                    sucObj.Direccion = fila[2].ToString();

                    return sucObj;
                }
            }
            return null;
        }
        public List<BEClsSucursal> ListarTodos()
        {
            List<BEClsSucursal> listaSuc = new List<BEClsSucursal>();

            DataTable tabla = objDatos.Leer("Listar_Sucursal", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow Item in tabla.Rows)
                {
                    BEClsSucursal objSuc = new BEClsSucursal();
                    objSuc.Codigo = Convert.ToInt32(Item["IdSuc"]);
                    objSuc.Telefono = Item["Telefono"].ToString();
                    objSuc.Direccion = Item["Direccion"].ToString();
                    listaSuc.Add(objSuc);
                }
                return listaSuc;
            }
            else
            {
                return null;
            }
        }
        public bool ExisteSucAsociada(BEClsSucursal Objeto)
        {
            Hdatos = new Hashtable();
            Hdatos.Add("@idSuc", Objeto.Codigo);

            return objDatos.LeerScalar("ExisteSucAsociada", Hdatos);
        }

        public bool Baja(int Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Alta(int Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
