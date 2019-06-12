using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
     public class RegistrarUsuarios : Repositorio 
    {
        public string Tabla = "Usuarios";
        public void AgregarNuevoUsuario(Usuario nuevo)
        {

           

            try
            {
                String Query = String.Format("insert into {0} (Nombre,Apellido,Email,Dni,Edad,Contraseña,Tipo,Genero) values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Tabla, nuevo.Nombre, nuevo.Apellido,nuevo.Email, nuevo.Dni, nuevo.Edad, nuevo.Contraseña, nuevo.Tipo, nuevo.Genero);
                EjecutarInsert(Query);
                      
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

        public void ModificarDatosPersonales (string email, Usuario modificar)
        {
            try
            {
                String Query = String.Format("Update Usuarios set Nombre=@Nombre, Apellido=@Apellido, Email=@Email, Dni=@Dni, Edad=@Edad where Email = '{0}' ",email);
                this.SqlCommand.Parameters.Clear();
                this.SqlCommand.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                this.SqlCommand.Parameters.AddWithValue("@Apellido", modificar.Apellido);
                this.SqlCommand.Parameters.AddWithValue("@Email", modificar.Email);
                this.SqlCommand.Parameters.AddWithValue("@Dni", modificar.Dni);
                this.SqlCommand.Parameters.AddWithValue("@Edad", modificar.Edad);
                this.EjecutarUpdate(Query);


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

        public void ModificarContraseña(string pass, Usuario modificar)
        {
            try
            {
                String Query = String.Format("Update Usuarios set Contraseña=@Contraseña where Contraseña = '{0}' ", pass);
                this.SqlCommand.Parameters.Clear();
                this.SqlCommand.Parameters.AddWithValue("@Contraseña", modificar.Contraseña);
                this.EjecutarUpdate(Query);


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

