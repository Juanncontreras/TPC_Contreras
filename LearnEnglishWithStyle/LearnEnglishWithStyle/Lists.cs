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

namespace LearnEnglishWithStyle
{
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void btIrregularsVerbs_Click(object sender, EventArgs e)
        {

            ListadosVocabulario listar = new ListadosVocabulario();

            try
            {

                dgvLists.DataSource = listar.ListarIrregulares();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void BtRegularVerbs_Click(object sender, EventArgs e)
        {

            ListadosVocabulario listar = new ListadosVocabulario();

            try
            {

                dgvLists.DataSource = listar.ListarRegulares();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }


}
