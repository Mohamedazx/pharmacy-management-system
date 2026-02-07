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
    public partial class allbills : Form
    {
        public allbills()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            billing_form n = new billing_form();
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            show_billing m = new show_billing();
            m.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            customers n = new customers();
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            expebills n = new expebills();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }
    }
}
