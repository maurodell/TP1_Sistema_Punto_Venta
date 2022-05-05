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
    public class MPPEmpleado : Repositorio<BEClsEmpleado>
    {
        Acceso oAcDatos;
        public bool Crear(BEClsEmpleado objEmp)
        {
            string consulta;
            consulta = "INSERT INTO Empleado ([Nombre], [Apellido], [Puesto], [idSuc], [Email], [Pass], [Soft_Delete]) values " +
                        "('" + objEmp.Nombre + "', '" + objEmp.Apellido + "', '" + objEmp.Puesto + "', " + objEmp.Sucursal.Codigo + ",'" + objEmp.Email + "', '" + objEmp.Pass + "', " + Convert.ToByte(objEmp.Soft_Delete) + ")";

            oAcDatos = new Acceso();
            return oAcDatos.Escribir(consulta);
        }

        public bool Eliminar(BEClsEmpleado objEmp)
        {
            if (Existe_NC_Asociada(objEmp) == false)
            {
                objEmp.Soft_Delete = false;
                string consulta = "UPDATE Empleado SET Soft_Delete = " + Convert.ToByte(objEmp.Soft_Delete) + " WHERE idEmpleado = " + objEmp.Codigo + "";
                oAcDatos = new Acceso();
                return oAcDatos.Escribir(consulta);
            }
            else
            {
                return false;
            }
        }
        public bool Alta(BEClsEmpleado objEmp)
        {
            if (Existe_NC_Asociada(objEmp) == false)
            {
                objEmp.Soft_Delete = true;
                string consulta = "UPDATE Empleado SET Soft_Delete = " + Convert.ToByte(objEmp.Soft_Delete) + " WHERE idEmpleado = " + objEmp.Codigo + "";
                oAcDatos = new Acceso();
                return oAcDatos.Escribir(consulta);
            }
            else
            {
                return false;
            }
        }

        public BEClsEmpleado Leer(BEClsEmpleado objEmp)
        {
            throw new NotImplementedException();
        }

        public List<BEClsEmpleado> ListarTodos()
        {
            DataSet Ds;
            oAcDatos = new Acceso();
            string consulta = "SELECT Empleado.idEmpleado, Empleado.Nombre, Empleado.Apellido, Empleado.Puesto, Empleado.Email, Empleado.Pass, Empleado.Soft_Delete, Sucursal.idSuc, Sucursal.Telefono, Sucursal.Direccion from Empleado, Sucursal WHERE Empleado.idSuc = Sucursal.idSuc";
            Ds = oAcDatos.Leer2(consulta);
            List<BEClsEmpleado> listEmp = new List<BEClsEmpleado>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {

                    BEClsEmpleado objEmpleado = new BEClsEmpleado();
                    objEmpleado.Codigo = Convert.ToInt32(fila[0]);
                    objEmpleado.Nombre = fila[1].ToString();
                    objEmpleado.Apellido = fila[2].ToString();
                    objEmpleado.Puesto = fila["Puesto"].ToString();
                    objEmpleado.Pass = fila["Pass"].ToString();
                    objEmpleado.Soft_Delete = Convert.ToBoolean(fila["Soft_Delete"]);

                    BEClsSucursal oBESuc = new BEClsSucursal();
                    oBESuc.Codigo = Convert.ToInt32(fila["idSuc"]);
                    oBESuc.Telefono = fila["Telefono"].ToString();
                    oBESuc.Direccion = fila["Direccion"].ToString();
                    objEmpleado.Sucursal = oBESuc;

                    listEmp.Add(objEmpleado);
                }
            }
            else
            {
                listEmp = null;
            }
            return listEmp;

        }
        public bool Modificar(BEClsEmpleado objEmp)
        {
            string consulta;
            consulta = "UPDATE Empleado SET Nombre = '" + objEmp.Nombre + "', Apellido = '" + objEmp.Apellido + "', Puesto = '" + objEmp.Puesto + "', idSuc = " + objEmp.Sucursal.Codigo + ", Email = '" + objEmp.Email + "' WHERE idEmpleado = '" + objEmp.Codigo + "'";
            oAcDatos = new Acceso();
            return oAcDatos.Escribir(consulta);
        }
        public bool Existe_NC_Asociada(BEClsEmpleado objEmp)
        {  //instancio un objeto de la clase datos para operar con la BD
            oAcDatos = new Acceso();
            return oAcDatos.LeerScalar("SELECT COUNT(idEmpleado) from NC_Empleado where idEmpleado =" + objEmp.Codigo + "");
        }
    }
}
