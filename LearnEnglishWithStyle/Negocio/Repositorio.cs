using System;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class Repositorio
    {
        public String Table = null;
        public SqlConnection SqlConnection { set; get; }
        public SqlCommand SqlCommand { set; get; }
        public SqlDataReader SqlDataReader { set; get; }

        public Repositorio()
        {
            this.SqlConnection = new SqlConnection();
            this.SqlCommand = new SqlCommand();
        }

        private void PrepararParaEjecutar(String Query)
        {
            this.SqlConnection.ConnectionString = AccesoDatosManager.cadenaConexion;
            this.SqlCommand.CommandType = System.Data.CommandType.Text;
            this.SqlCommand.CommandText = Query;
            this.SqlCommand.Connection = this.SqlConnection;
            this.SqlConnection.Open();
        }

        public void EjecutarSelect(String Query)
        {
            this.PrepararParaEjecutar(Query);
            this.SqlDataReader = this.SqlCommand.ExecuteReader();
        }

        public int EjecutarInsert(String Query)
        {
            this.PrepararParaEjecutar(Query);
            return this.GetOrElse(this.SqlCommand.ExecuteScalar(), 0);
        }

        public void EjecutarUpdate(String Query)
        {
            this.PrepararParaEjecutar(Query);
            this.SqlCommand.ExecuteNonQuery();
        }

        private int GetOrElse(object ToConvert, int Default)
        {
            try
            {
                return int.Parse(ToConvert.ToString());
            }
            catch (Exception)
            {
                return Default;
            }
        }
    }
}
