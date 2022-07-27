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
    public class MPPNotaDeCredito : Repositorio<BEClsNotaDeCredito>
    {
        public MPPNotaDeCredito()
        {
            objDatos = new DatosBD();
        }
        DatosBD objDatos;
        Hashtable Hdatos;

        public bool Crear(BEClsNotaDeCredito Objeto)
        {
            string consulta = "Alta_NC";
            Hdatos = new Hashtable();

            //si es diferente de cero, es para modificar el empleado.
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@idEmpleado", Objeto.Codigo);
                consulta = "NC_Modificar";
            }

            Hdatos.Add("@Numero_doc", Objeto.Numero_doc);
            Hdatos.Add("@Fecha", Objeto.Fecha);
            Hdatos.Add("@Monto", Objeto.Monto);

            return objDatos.Escribir(consulta, Hdatos);
        }

        public bool Baja(BEClsNotaDeCredito Objeto)
        {
            Hdatos = new Hashtable();
            string Consulta = "NC_Baja";

            Hdatos.Add("@idNotaCredito", Objeto.Codigo);

            if (Existe_Empleado_Asociada(Objeto) == false)
            {
                return objDatos.Escribir(Consulta, Hdatos);
            }
            else
            {
                return false;
            }
        }

        public List<BEClsNotaDeCredito> ListarBusquedaApellido(BEClsNotaDeCredito Objeto)
        {
            throw new NotImplementedException();
        }

        public BEClsNotaDeCredito LeerObjeto(int Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Existe_Empleado_Asociada(BEClsNotaDeCredito objNC)
        {
            Hashtable Hdatos2 = new Hashtable();

            if (objNC.Codigo != 0)
            {
                Hdatos2.Add("@idNC", objNC.Codigo);
                return objDatos.LeerScalar("NotaCredito_Existe", Hdatos2);
            }
            else
            {
                return false;
            }
        }
        public List<BEClsNotaDeCredito> ListarTodos()
        {
            List<BEClsNotaDeCredito> listaNC = new List<BEClsNotaDeCredito>();

            string Consulta = "Listar_Todas_NC";

            DataTable Table = objDatos.Leer(Consulta, null);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    BEClsNotaDeCredito objNC = new BEClsNotaDeCredito();
                    objNC.Codigo = Convert.ToInt32(fila[0]);
                    objNC.Numero_doc = Convert.ToInt32(fila[1].ToString());
                    objNC.Fecha = Convert.ToDateTime(fila[2].ToString());
                    objNC.Monto = Convert.ToDouble(fila[3].ToString());

                    listaNC.Add(objNC);
                }
            }
            return listaNC;
        }
        public List<BEClsNotaDeCredito> ListarNC_Empleado(BEClsEmpleado Objeto)
        {
            List<BEClsNotaDeCredito> listaNC = new List<BEClsNotaDeCredito>();
            Hashtable Hdatos3 = new Hashtable();
            string Consulta = "Listar_NC_X_Empleado";
            Hdatos3.Add("@idEmpleado", Objeto.Codigo);
            DataTable Table = objDatos.Leer(Consulta, Hdatos3);

            if (Table.Rows.Count > 0)
            {
                foreach (DataRow fila in Table.Rows)
                {
                    BEClsNotaDeCredito objNC = new BEClsNotaDeCredito();
                    objNC.Codigo = Convert.ToInt32(fila[0]);
                    objNC.Numero_doc = Convert.ToInt32(fila[1].ToString());
                    objNC.Fecha = Convert.ToDateTime(fila[2].ToString());
                    objNC.Monto = Convert.ToDouble(fila[3].ToString());

                    listaNC.Add(objNC);
                }
            }
            return listaNC;
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
