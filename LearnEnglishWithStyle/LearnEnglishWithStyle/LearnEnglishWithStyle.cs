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
    public partial class LearnEnglishWithStyle : Form
    {

        private string Email;
        
        public LearnEnglishWithStyle(string email )
        {
            InitializeComponent();
           Email = email;
        }


        private void gpMenuPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void btVocabulary_Click(object sender, EventArgs e)
        {
            PrincipalVocabulary prinVoca = new PrincipalVocabulary();
            prinVoca.Show();
        }

        private void LearnEnglishWithStyle_Load(object sender, EventArgs e)
        {

        }

        private void EditarDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ModifiyPersonalData nueva = new ModifiyPersonalData(Email);
            nueva.Show();
            

        }

        private void DatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiyPersonalData nueva = new ModifiyPersonalData(Email);
            nueva.Show();
        }

        private void ContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPassword nueva = new ModifyPassword();
            nueva.Show();
        }
    }
}
