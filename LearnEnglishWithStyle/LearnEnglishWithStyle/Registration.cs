using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace LearnEnglishWithStyle
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            RegistrarUsuarios Agregar = new RegistrarUsuarios();
            

            try
            {
                
                usuario.Nombre = tbAddNombre.Text.Trim().ToString();
                usuario.Apellido = tbAddApellido.Text.Trim().ToString();
                usuario.Dni = this.CadenaAEntero(tbAddDni.Text.ToString(), 0);
                usuario.Edad = this.CadenaAEntero(tbAddEdad.Text.ToString(), 0);
                usuario.Contraseña = tbAddContraseña.Text.Trim().ToString();
                usuario.Email = tbAddEmail.Text.Trim().ToString();
               if ( rbMasculino.Checked==true)
                {
                    usuario.Genero = true;


                }
                else
                {
                    usuario.Genero = false;
                }

                if (cmbAlumProf.SelectedItem.ToString() == "ALUMNO")
                {
                    usuario.Tipo = false;


                }
                else
                {
                    usuario.Tipo = true;
                }
                Agregar.AgregarNuevoUsuario(usuario);


                MessageBox.Show("Usuario registrado correctamente");
                this.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, vuelva a intentarlo");
                throw ex;
            }

        }
            private int CadenaAEntero (string cadena,int dfl)
            {
            int n = 0;

                try
                {

                n = int.Parse(cadena);

                }
                catch (Exception)
                {

                    n=dfl;
                }
            return n;
            }
       

        private void Registration_Load(object sender, EventArgs e)
        {
            rbMasculino.Checked = true;
            cmbAlumProf.SelectedItem = "ALUMNO";
        }
    }
}
