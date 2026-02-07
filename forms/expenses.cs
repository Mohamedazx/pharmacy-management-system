using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy.forms
{
    public partial class expenses : Form
    {
        public expenses()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            serch_outs h = new serch_outs();
            h.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            all_salary n = new all_salary();
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            expebills n = new expebills();
            n.Show();
            this.Hide();

        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            profit n = new profit();
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            employes m = new employes();
            m.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void expenses_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }
    }
}
