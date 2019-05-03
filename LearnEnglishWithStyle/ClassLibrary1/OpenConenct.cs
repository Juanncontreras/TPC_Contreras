using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;



namespace AccessData

{
    public class OpenConenct

    {
        
        public List<Dominio.Palabra> OpenConnection ()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Dominio.Palabra> listado = new List<Dominio.Palabra>();
            Dominio.Palabra nuevo;

            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog = Contreras_DB ; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select English,Spanish from IrregularVerbs";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Dominio.Palabra();
                    nuevo.English = lector.GetString(0);
                    nuevo.Spanish = lector.GetString(1);

                    listado.Add(nuevo);


                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }


        }

        public List<Dominio.Palabra> OpenConnection1()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Dominio.Palabra> listado = new List<Dominio.Palabra>();
            Dominio.Palabra nuevo;

            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog = Contreras_DB ; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select English,Spanish from RegularVerbs";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Dominio.Palabra();
                    nuevo.English = lector.GetString(0);
                    nuevo.Spanish = lector.GetString(1);

                    listado.Add(nuevo);


                }
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }


        }
    }
}
