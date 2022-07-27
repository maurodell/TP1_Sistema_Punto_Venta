using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections; //para el Hashtable y así usar el ArrayList

namespace DAL
{
    public class DatosBD
    {
        string Conector = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBTp2;Integrated Security=True";
        private SqlConnection Conexion = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBTp2;Integrated Security=True");
        private SqlTransaction Tranx;
        private SqlCommand Commd;

        public DataTable Leer(string Consulta, Hashtable HashDatos)
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da;

            Commd = new SqlCommand(Consulta, Conexion);
            Commd.CommandType = CommandType.StoredProcedure;

            try
            {
                Da = new SqlDataAdapter(Commd);
                if (HashDatos != null)
                {
                    foreach (string dato in HashDatos.Keys)
                    {
                        Commd.Parameters.AddWithValue(dato, HashDatos[dato]);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Da.Fill(Dt);
            return Dt;
        }
        public bool LeerScalar(string Consulta, Hashtable HashDatos)
        {
            Conexion.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            Commd = new SqlCommand(Consulta, Conexion);
            Commd.CommandType = CommandType.StoredProcedure;
            try
            {
                if ((HashDatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in HashDatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Commd.Parameters.AddWithValue(dato, HashDatos[dato]);
                    }
                }

                int Respuesta = Convert.ToInt32(Commd.ExecuteScalar());
                Conexion.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }
        public bool LeerScalar2(string Consulta, Hashtable HashDatos)
        {
            Conexion.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            Commd = new SqlCommand(Consulta, Conexion);
            Commd.CommandType = CommandType.StoredProcedure;
            try
            {
                if ((HashDatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in HashDatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Commd.Parameters.AddWithValue(dato, HashDatos[dato]);
                    }
                }

                int Respuesta = Convert.ToInt32(Commd.ExecuteScalar());
                Conexion.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }
        public bool Escribir(string consulta, Hashtable HashDatos)
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = Conector;
                Conexion.Open();
            }

            try
            {
                Tranx = Conexion.BeginTransaction();
                //uso el constructor del objeto command
                Commd = new SqlCommand(consulta, Conexion, Tranx);
                //Cmd.Connection = oCnn;
                //Cmd.CommandText = consulta;
                //Cmd.Transaction = Tranx;
                Commd.CommandType = CommandType.StoredProcedure;

                if ((HashDatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in HashDatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Commd.Parameters.AddWithValue(dato, HashDatos[dato]);
                    }
                }

                int respuesta = Commd.ExecuteNonQuery();
                Tranx.Commit();
                return true;

            }
            catch (SqlException ex)
            {
                Tranx.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                Tranx.Rollback();
                throw ex;
            }
            finally
            { Conexion.Close(); }
        }
        public string Get(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta, Conexion);

            Conexion.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            string pass = "";
            while (reader.Read())
            {
                pass = reader.GetString(0);
            }


            Conexion.Close();
            return pass;
        }
    }
}
