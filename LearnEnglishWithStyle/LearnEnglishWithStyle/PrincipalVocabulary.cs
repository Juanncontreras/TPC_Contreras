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
    public partial class PrincipalVocabulary : Form
    {
        public PrincipalVocabulary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lists list = new Lists();
            list.Show();
        }


    }



  
}
