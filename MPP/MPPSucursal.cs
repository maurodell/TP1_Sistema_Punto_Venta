using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Abstraccion;
using System.Data;

namespace MPP
{
    public class MPPSucursal : Repositorio<BEClsSucursal>
    {
        Acceso oAcDatos;
        
        public bool Crear(BEClsSucursal ObjetoBE)
        {
            string consulta;
            consulta = "INSERT INTO Sucursal ([Telefono], [Direccion]) values ('" + ObjetoBE.Telefono + "', '" + ObjetoBE.Direccion + "')";
            oAcDatos = new Acceso();
            return oAcDatos.Escribir(consulta);
        }

        public bool Eliminar(BEClsSucursal ObjetoBE)
        {
            if (ExisteSucAsociada(ObjetoBE) == false)
            {
                string consulta = "DELETE FROM Sucursal WHERE idSuc = '"+ ObjetoBE.Codigo +"'";
                oAcDatos = new Acceso();
                return oAcDatos.Escribir(consulta);
            }
            else
            {
                return false;
            }
        }

        public BEClsSucursal Leer(BEClsSucursal Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEClsSucursal> ListarTodos()
        {
            DataTable table;
            oAcDatos = new Acceso();
            table = oAcDatos.Leer("SELECT idSuc, Telefono, Direccion FROM Sucursal");
            List<BEClsSucursal> listaSuc = new List<BEClsSucursal>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow item in table.Rows)
                {
                    BEClsSucursal sucObj = new BEClsSucursal();
                    sucObj.Codigo = Convert.ToInt32(item[0]);
                    sucObj.Telefono = item[1].ToString();
                    sucObj.Direccion = item[2].ToString();
                    listaSuc.Add(sucObj);
                }
            }
            else
            {
                listaSuc = null;
            }
            return listaSuc;
        }

        public bool Modificar(BEClsSucursal ObjetoBE)
        {
            string consulta;
            consulta = "UPDATE Sucursal SET Telefono = '" + ObjetoBE.Telefono + "', Direccion = '" + ObjetoBE.Direccion + "' WHERE idSuc = '" + ObjetoBE.Codigo + "'";
            oAcDatos = new Acceso();
            return oAcDatos.Escribir(consulta);
        }
        public bool ExisteSucAsociada(BEClsSucursal ObjetoBE)
        {
            oAcDatos = new Acceso();
            return oAcDatos.LeerScalar("SELECT COUNT(idSuc) FROM Empleado WHERE idSuc = '" + ObjetoBE.Codigo + "'");
        }
    }
}
