using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace LearnEnglishWithStyle
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            AccesoUsuarios accusu = new AccesoUsuarios();
            Usuario user = new Usuario();


            user.Email = tbEmail.Text.Trim().ToString();
            user.Contraseña = tbContraseña.Text.Trim().ToString();

            if (accusu.ValidarUsuarioRegistrado(user)==true)
            {
                LearnEnglishWithStyle nuevaventana = new LearnEnglishWithStyle(user.Email);
                nuevaventana.Show();
                
            }
            else
            {
                MessageBox.Show("Ingresar un usuario registrado por favor");
            }
            
        }

        private void BtRegistrate_Click(object sender, EventArgs e)
        {
            Registration nuevaventana = new Registration();
            nuevaventana.Show();
        }
    }
}
