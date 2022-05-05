using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;
using Abstraccion;

namespace MPP
{
    public class MPPNotaDeCredito : Repositorio<BEClsNotaDeCredito>
    {
        Acceso oAcDatos;
        public bool Crear(BEClsNotaDeCredito oBENC)
        {
            string consulta = string.Format("INSERT INTO NotaDeCredito (Numero_Doc, Fecha, Monto) values (" + oBENC.Numero_doc + ",'" + (oBENC.Fecha).ToString("MM/dd/yyyy") + "'," + oBENC.Monto + ")");
            oAcDatos = new Acceso();
            return oAcDatos.Escribir(consulta);
        }

        public bool Eliminar(BEClsNotaDeCredito objNC)
        {
            if (Existe_Empleado_Asociada(objNC) == false)
            {
                string consulta = "DELETE FROM NotaDeCredito WHERE idNC = '" + objNC.Codigo + "'";
                oAcDatos = new Acceso();
                return oAcDatos.Escribir(consulta);
            }
            else
            {
                return false;
            }
        }

        public BEClsNotaDeCredito Leer(BEClsNotaDeCredito oBENC)
        {
            throw new NotImplementedException();
        }

        public List<BEClsNotaDeCredito> ListarTodos()
        {
            DataTable table;
            oAcDatos = new Acceso();
            table = oAcDatos.Leer("SELECT idNC, Numero_Doc, Fecha, Monto FROM NotaDeCredito");
            List<BEClsNotaDeCredito> listaSuc = new List<BEClsNotaDeCredito>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow item in table.Rows)
                {
                    BEClsNotaDeCredito ncObj = new BEClsNotaDeCredito();
                    ncObj.Codigo = Convert.ToInt32(item[0]);
                    ncObj.Numero_doc = Convert.ToInt32(item[1].ToString());
                    ncObj.Fecha = Convert.ToDateTime(item[2].ToString());
                    ncObj.Monto = Convert.ToDouble(item[3].ToString());
                    listaSuc.Add(ncObj);
                }
            }
            else
            {
                listaSuc = null;
            }
            return listaSuc;
        }

        public bool Modificar(BEClsNotaDeCredito oBENC)
        {
            throw new NotImplementedException();
        }
        public bool Existe_Empleado_Asociada(BEClsNotaDeCredito objNC)
        {  
            oAcDatos = new Acceso();
            return oAcDatos.LeerScalar("SELECT COUNT(idNotaCredito) from NC_Empleado where idNotaCredito =" + objNC.Codigo + "");
        }
    }
}
