using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
    public class AccesoUsuarios : Repositorio
    {
        private string tabla = "Usuarios";
        public bool ValidarUsuarioRegistrado (Usuario nuevo)
        {
            try
            {
                String Query = String.Format("select top 1 Email,Contraseña from {0} where Email= '{1}' and Contraseña= '{2}' ", tabla, nuevo.Email, nuevo.Contraseña);
                this.EjecutarSelect(Query);

                return this.SqlDataReader.HasRows;
            }
            catch (Exception ex)
            {
             
               throw ex;
            }
            finally
            {
                this.SqlConnection.Close();
            }

            

        }

        public bool ValidarContraseña (string pass)
        {

            try
            {
                String Query = String.Format("select top 1 Contraseña from {0} where Contraseña= '{1}' ", tabla, pass);
                this.EjecutarSelect(Query);

                return this.SqlDataReader.HasRows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.SqlConnection.Close();
            }
        }

        public Usuario ListarUsuarioRegistrado(string email)
        {
            Usuario user = new Usuario();
            try
            {
                String Query = String.Format("select * from {0} where Email= '{1}' ", tabla, email);
                this.EjecutarSelect(Query);

                while (this.SqlDataReader.Read())
                {
                    user.Apellido = this.SqlDataReader["Apellido"].ToString();
                    user.Nombre = this.SqlDataReader["Nombre"].ToString();
                    user.Email = this.SqlDataReader["Email"].ToString();
                    user.Dni = Convert.ToInt32(this.SqlDataReader["Dni"].ToString());
                    user.Edad = Convert.ToInt32(this.SqlDataReader["Edad"].ToString());
                    user.Genero = Convert.ToBoolean(this.SqlDataReader["Genero"].ToString());
                    user.Tipo = Convert.ToBoolean(this.SqlDataReader["Tipo"].ToString());
                    user.Contraseña = this.SqlDataReader["Contraseña"].ToString();
                    

                }
                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.SqlConnection.Close();
            }


        }

    }
}
