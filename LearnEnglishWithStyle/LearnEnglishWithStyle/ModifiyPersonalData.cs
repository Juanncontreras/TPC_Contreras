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
    public partial class ModifiyPersonalData : Form
    {
        private string Email;
        public Usuario user = new Usuario();
        public AccesoUsuarios listar = new AccesoUsuarios();
        public RegistrarUsuarios usuarios = new RegistrarUsuarios();

        public ModifiyPersonalData(string email)
        {
            InitializeComponent();
            Email = email;
        }

        private void ModifiyPersonalData_Load(object sender, EventArgs e)
        {
            user = listar.ListarUsuarioRegistrado(Email);

            tbNombre.AppendText(user.Nombre);
            tbApellido.AppendText(user.Apellido);
            tbEmail.AppendText(user.Email);
            tbDni.AppendText(user.Dni.ToString());
            tbEdad.AppendText(user.Edad.ToString());
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                user.Nombre = tbNombre.Text.Trim().ToString();
                user.Apellido = tbApellido.Text.Trim().ToString();
                user.Email = tbEmail.Text.Trim().ToString();
                user.Dni = Convert.ToInt32( tbDni.Text.Trim().ToString());
                user.Edad = Convert.ToInt32( tbEdad.Text.Trim().ToString());

                usuarios.ModificarDatosPersonales(Email, user);

                MessageBox.Show("Datos personales modificados  correctamente");
               

            }
            catch (Exception)
            {

                throw;
            }



        }
    }

}
