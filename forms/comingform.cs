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
    public partial class comingform : Form
    {
        public comingform()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            user_com h = new user_com();
            h.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            usersgo h = new usersgo();
            h.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            homeform h = new homeform();
            h.Show();
            this.Hide();
        }
    }
}
