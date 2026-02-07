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
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            allbills n = new allbills();
            n.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            medicinform med = new medicinform();
            med.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            medicine_manufacturer n = new medicine_manufacturer();
            n.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            employes n = new employes();
            n.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            comingform h = new comingform();
            h.Show();
            this.Hide();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {   DataTable dt = new DataTable();
            PL.userspl ob = new PL.userspl();
            dt = ob.cutsh_type();
           string typee = dt.Rows[0][0].ToString();

            if (typee == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                expenses h = new expenses();
                h.Show();
                this.Hide();
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            login h = new login();
            h.Show();
            this.Hide();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {

        }

        private void homeform_Load(object sender, EventArgs e)
        {
            Font f = new Font("splart - h - amana", 28, FontStyle.Bold);
            label1.Font = f;
            label2.Font = f;
            label4.Font = f;
            label5.Font = f;
            label7.Font = f;
            
        }
    }
}
