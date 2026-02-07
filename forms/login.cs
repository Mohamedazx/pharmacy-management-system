using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy;
using pharmacy.PL;

namespace pharmacy.forms
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
            password.isPassword = true;

        }
        pharmacy.PL.userspl log = new pharmacy.PL.userspl();
        string type;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (cb.Checked == true)
            {
                password.isPassword = false;
            }
            else
            {
                password.isPassword = true;

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Admin.Checked)
            {
                type = "admin";
            }
            else
            {
                type = "user";


            }
            /*  try
              {
            */
            DataTable dt = log.s_login(user_name.Text, password.Text, type);
            if (dt.Rows.Count > 0)
            {
                log.set_user(user_name.Text, type);
                homeform f = new homeform();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pleas Enter Correct User Name Or Password ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* }

             catch
             {
                 MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
