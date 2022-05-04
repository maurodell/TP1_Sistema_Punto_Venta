using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Acceso
    {
        //Declaro el objeto que me conecta con la bd
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());

        private SqlTransaction Transax;

        //Declaro el método que me abre la connection
        //public void abrirConexion()
        //{
        //    conexion = new SqlConnection();

        //    conexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBTp;Integrated Security=True";
        //    conexion.Open();
        //}
        public void cerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }
        public DataTable Leer(string consulta)
        {
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta, conexion);
                Da.Fill(table);
            }
            catch (SqlException ex)
            {
                throw ex;
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
            return table;
        }
        public bool Escribir(string consulta)
        {
            conexion.Open();
            Transax = conexion.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = consulta;

            cmd.Transaction = Transax;
            try
            {
                int respuesta = cmd.ExecuteNonQuery();
                Transax.Commit();
                return true;
            }
            catch(SqlException ex)
            {
                Transax.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                Transax.Rollback();
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public bool LeerScalar(string consulta)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                if (respuesta > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataSet Leer2(string consulta)
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(consulta, conexion);
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return Ds;
        }
    }
}
