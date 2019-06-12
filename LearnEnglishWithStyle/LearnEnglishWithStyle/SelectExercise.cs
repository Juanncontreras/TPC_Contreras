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
    public partial class SelectExercise : Form
    {
        public SelectExercise()
        {
            InitializeComponent();
        }

        private void BtCards_Click(object sender, EventArgs e)
        {
            CardExercise nueva = new CardExercise();
            nueva.Show();
        }
    }
}
