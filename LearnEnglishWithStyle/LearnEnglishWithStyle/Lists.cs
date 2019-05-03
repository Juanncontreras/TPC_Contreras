using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessData;
using Dominio;

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
            OpenConenct listar = new OpenConenct();
            try
            {

                dgvLists.DataSource = listar.OpenConnection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void BtRegularVerbs_Click(object sender, EventArgs e)
        {
            OpenConenct listar = new OpenConenct();
            try
            {

                dgvLists.DataSource = listar.OpenConnection1();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }


}
