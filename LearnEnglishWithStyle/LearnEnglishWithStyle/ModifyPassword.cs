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
    public partial class ModifyPassword : Form
    {
        public ModifyPassword()
        {
            InitializeComponent();

        }
        public Usuario user = new Usuario();
        public AccesoUsuarios validar = new AccesoUsuarios();
        public RegistrarUsuarios registrar = new RegistrarUsuarios();
        public string contraseña;
        public string contraseña1;

        public object Messagebox { get; private set; }

        private void BtAceppt_Click(object sender, EventArgs e)
        {

             bool ValidatePass = true;

            while (ValidatePass==true)
            {
                contraseña = tbOldPass.Text.Trim().ToString();
                user.Contraseña = tbNewPass.Text.Trim().ToString();
                contraseña1 = tbConfirmNewPass.Text.Trim().ToString();
                while (string.Equals(user.Contraseña, contraseña1))
                {

                    if (validar.ValidarContraseña(contraseña) == false)
                    {
                        MessageBox.Show("Error de contraseña actual!!");
                        ValidatePass = false;
                    }



                }
             
                    MessageBox.Show("las contraseñas ingresadas no coinciden");
                    ValidatePass = false;
                

            }

                

            try
            {


                registrar.ModificarContraseña(contraseña, user);
                MessageBox.Show("Contraseña modificada correctamente");


            }
            catch (Exception)
            {

                throw ;
            }

        }
    }

}
