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
    public partial class serch_outs : Form
    {
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        PL.salarys oc = new PL.salarys();
        DataTable dt = new DataTable();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");
        public void fetch()
        {
            try
            {
                DataTable f = new DataTable();
                PL.employeess n = new PL.employeess();
                dt = n.catsh_salary(comboBox_state.Text);
                hor_cost.Text= dt.Rows[0][0].ToString();
               /* con.Open();
                string sql = "select * from employees where name='" + comboBox_state.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    hor_cost.Text = "سعر الساعه = " + dr["salary"].ToString();
                    hor_costs = dr["salary"].ToString();



                }
                con.Close();*/
            }
            catch
            {
                return;
            }
        }
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
           // SqlDataAdapter dataadp;
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            comboBox_state.ValueMember = "name";
            comboBox_state.DataSource = dt;
            con.Close();

        }
        public serch_outs()
        {
            InitializeComponent();
            dt = oc.salary_id();
            salary_id.Text = dt.Rows[0][0].ToString();
            populate();
            show_employes();
          
        }

        private void serch_outs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                dt = ob.search_outs(date1.Value, date2.Value, comboBox_state.Text);
                this.dgv.DataSource = dt;

                double x = 0;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    x += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
                }
                to_h.Text = "Total Hours =" + x.ToString();
                fetch();
               // salary.Text = "صافي المرتب ="+ (x * Convert.ToInt32(hor_cost.Text)).ToString();
            }
            catch
            {
                return;
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            double x = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[5].Value);
            }
            PL.salarys n = new PL.salarys();
            try
            {
                n.add_salary(Convert.ToInt32(salary_id.Text), comboBox_state.Text, x, Convert.ToDouble(hor_cost.Text),  Convert.ToDouble(salary.Text),DateTime.Now);
                MessageBox.Show("تم ادخال المرتب");
            }
            catch
            {
                MessageBox.Show("error"+e.ToString());
                return;
            }
        }

        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            expenses n = new expenses();
            n.Show();
            this.Hide();
        }
    }
}
