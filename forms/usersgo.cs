using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pharmacy.forms
{
    public partial class usersgo : Form
    {
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");

        public void populate()
        {
            con.Open();
            string sql = "select * from coming";
            SqlDataAdapter dataadp = new SqlDataAdapter(sql, con);
            SqlCommandBuilder commendbu = new SqlCommandBuilder(dataadp);
            var ds = new DataSet();
            dataadp.Fill(ds);
            dgv.ReadOnly = true;
            dgv.DataSource = ds.Tables[0];

            con.Close();
        }
        public void show_employes()
        {
            con.Open();
            string sql = "select name from [employees]";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
         //  SqlDataAdapter dataadp;
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            comboBox_state.ValueMember = "name";
            comboBox_state.DataSource = dt;
            con.Close();

        }
        public usersgo()
        {
            InitializeComponent();
            populate();
            show_employes();
            time_go.Text = DateTime.Now.ToLongTimeString();
        }

        private void usersgooo_Load(object sender, EventArgs e)
        {
           
           /* double  x = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[6].Value); 
            }
            to_h.Text = x.ToString();*/

        }

        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          /*  if (sc.Text == "")
            {
                Patients_Manegment_constractor();
            }
            else
            {
                dt = ob.come_go_search(Convert.ToString( sc.Text));

                this.dgp.DataSource = dt;

                double x = 0;

                for (int i = 0; i < dgp.Rows.Count; i++)
                {
                    x += Convert.ToDouble(dgp.Rows[i].Cells[6].Value);
                }

                to_h.Text = x.ToString();
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (dgp.CurrentRow.Cells[5].Value != "")
            {
               
                time_come.Text = this.dgp.CurrentRow.Cells[4].Value.ToString();

               try
                {
                   


                    id_come.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();


                    ob.update_user_go(int.Parse(id_come.Text), Convert.ToDateTime(time_go.Text), Convert.ToDecimal(total_h.Text));

                    MessageBox.Show("تم تسجيل الانصراف", "تسجيل الانصراف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Patients_Manegment_constractor();


                }
                catch
                {

                    MessageBox.Show("...يوجد بينات ناقصة ", "تسجيل الانصراف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

            }
            else
            {
                MessageBox.Show("تم تسجيل الانصراف مؤخرا", "تسجيل الانصراف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
        }

        private void id_come_TextChanged(object sender, EventArgs e)
        {
            id_come.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
               /* try
                {*/
                   /* dt = ob.come_go_search(Convert.ToString(comboBox_state.SelectedValue.ToString()),sc.Text);
                    this.dgp.DataSource = dt;

                    double x = 0;
                    for (int i = 0; i < dgp.Rows.Count; i++)
                    {
                        x += Convert.ToDouble(dgp.Rows[i].Cells[6].Value);
                    }
                    to_h.Text = x.ToString();*/
              /*  }
                catch
                {
                    return;
                }*/
            
        }

        private void dgp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void time_com_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_come.Text= this.dgv.CurrentRow.Cells[0].Value.ToString();
            time_com.Text= Convert.ToDateTime( this.dgv.CurrentRow.Cells[3].Value.ToString()).ToLongTimeString();

            // TimeSpan total_time = (Convert.ToDateTime( DateTime.Now.ToLongTimeString()) - Convert.ToDateTime(time_com.Text));
            TimeSpan total_time = Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - Convert.ToDateTime(this.dgv.CurrentRow.Cells[3].Value.ToString());
            total_h.Text = total_time.TotalHours.ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentRow.Cells[4].Value.ToString() == "")
            {
                try
                {
                    ob.add_go(Convert.ToInt32(id_come.Text), Convert.ToDateTime(time_go.Text),total_h.Text, note.Text);
                    

                    MessageBox.Show("تم تسجيل الانصراف");
                    homeform m = new homeform();
                    m.Show();
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("eroor"+e.ToString());
                    return;

                }
            }
            else
            {
                MessageBox.Show("تم تسجيل الانصراف سابقا");
            }

           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_state_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_state.Text == "")
            {
                populate();
            }
            else
            {
                try
                {
                    dt = ob.come_go_search_name(Convert.ToString(comboBox_state.SelectedValue.ToString()));
                    this.dgv.DataSource = dt;

                    /* double x = 0;
                     for (int i = 0; i < dgp.Rows.Count; i++)
                     {
                         x += Convert.ToDouble(dgp.Rows[i].Cells[6].Value);
                     }
                     to_h.Text = x.ToString();*/
                }
                catch
                {
                    return;
                }
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_come.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            time_com.Text = Convert.ToDateTime(this.dgv.CurrentRow.Cells[3].Value.ToString()).ToLongTimeString();

            // TimeSpan total_time = (Convert.ToDateTime( DateTime.Now.ToLongTimeString()) - Convert.ToDateTime(time_com.Text));
            TimeSpan total_time = Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - Convert.ToDateTime(this.dgv.CurrentRow.Cells[3].Value.ToString());
            total_h.Text = total_time.TotalHours.ToString();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            comingform m = new comingform();
            m.Show();
            this.Hide();
        }
    }
}
