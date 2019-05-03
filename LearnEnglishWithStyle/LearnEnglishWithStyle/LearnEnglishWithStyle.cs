using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LearnEnglishWithStyle
{
    public partial class LearnEnglishWithStyle : Form
    {
        public LearnEnglishWithStyle()
        {
            InitializeComponent();
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
    }
}
