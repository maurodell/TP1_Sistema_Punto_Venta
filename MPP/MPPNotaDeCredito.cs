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

        public bool Eliminar(BEClsNotaDeCredito oBENC)
        {
            throw new NotImplementedException();
        }

        public BEClsNotaDeCredito Leer(BEClsNotaDeCredito oBENC)
        {
            throw new NotImplementedException();
        }

        public List<BEClsNotaDeCredito> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEClsNotaDeCredito oBENC)
        {
            throw new NotImplementedException();
        }
    }
}
