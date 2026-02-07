using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy.forms
{
    public partial class user_com : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");


        PL.userspl ob = new PL.userspl();
        public void show_employes()
        {
            con.Open();
            string sql = "select name from [employees]";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            //SqlDataAdapter dataadp;
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            comboBox_state.ValueMember = "name";
            comboBox_state.DataSource = dt;
            con.Close();

        }
        public user_com()
        {
            InitializeComponent();
            show_employes();
          /*  comboBox_state.DataSource = ob.view_name_come();
            comboBox_state.DisplayMember = "UserFullName";
            comboBox_state.ValueMember = "UserFullName";*/
        }

        private void user_com_Load(object sender, EventArgs e)
        {
            dt = ob.show_come_id();
            id.Text = dt.Rows[0][0].ToString();

             datecome.Text = DateTime.Now.ToShortDateString();
            time_com.Text = DateTime.Now.ToShortTimeString();
            comboBox_state.Text = "الموظف";
        }


        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            /* con.Open();
             string sql = "set identity_insert coming on insert into [coming] ([id],[name],[date],[time_com],[nottocome])VALUES('" + id.Text+"','"+comboBox_state.Text+"','"+Convert.ToDateTime( datecome.Text)+"','"+Convert.ToDateTime( time_com.Text)+"','"+note.Text+ "')set identity_insert coming on";
             SqlCommand cmd = new SqlCommand(sql, con);
             cmd.ExecuteNonQuery();
             con.Close();*/
            try
            {
                ob.addcome(Convert.ToInt32(id.Text), comboBox_state.Text,Convert.ToDateTime( DateTime.Now.ToShortDateString()), Convert.ToDateTime(DateTime.Now.ToShortTimeString()), note.Text);

                MessageBox.Show("تم تسجيل الحضور");

            }
            catch
            {
                MessageBox.Show("error"+e.ToString());
                return;

            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            comingform n = new comingform();
            n.Show();
            this.Hide();
        }
    }
}
