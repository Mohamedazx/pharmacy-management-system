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
    public partial class employes : Form
    {
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        PL.employeess oc = new PL.employeess();
        DataTable ds = new DataTable();
        PL.employeess n = new PL.employeess();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");

        public void bill_Manegment_constractor()
        {

            ds = oc.all_empoloy();
            dgv.DataSource = ds;
            dgv.AllowUserToAddRows = false;

        }
       /* public void populate()
        {
            con.Open();
            string sql = "select * from employees";
            SqlDataAdapter dataadp = new SqlDataAdapter(sql, con);
            SqlCommandBuilder commendbu = new SqlCommandBuilder(dataadp);
            var ds = new DataSet();
            dataadp.Fill(ds);
            dgv.ReadOnly = true;
            dgv.DataSource = ds.Tables[0];

            con.Close();
        }*/
        public employes()
        {
            InitializeComponent();
            ds = ob.show_employees_id();
            id.Text = ds.Rows[0][0].ToString();
            bill_Manegment_constractor();
        }

        private void male_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employes_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || name.Text == "الاسم")
            {
                MessageBox.Show("برجاء ادخال اسم الموظف");
                name.Focus();
                //Focus( med_name.Text);
            }
            else
            {
                if (salary.Text == "" || salary.Text == "سعر الساعه")
                {
                    MessageBox.Show("برجاء ادخال قيمه المرتب");
                    salary.Focus();

                }
                else
                {

                    if (card_number.Text == "" || card_number.Text == "الرقم القومي")
                    {
                        MessageBox.Show("برجاء ادخال رقم البطاقه");
                        card_number.Focus();

                    }
                    else
                    {
                        if (Age.Text == "" || Age.Text == "العمر")
                        {
                            MessageBox.Show("برجاء ادخال العمر");
                            Age.Focus();

                        }
                        else
                        {
                            if (mob.Text == "" || mob.Text == "المحمول")
                            {
                                MessageBox.Show("برجاء ادخال الموبايل");

                            }
                            else
                            {
                                if (sex.Text == "النوع" )
                                {
                                    MessageBox.Show("برجاء اختيار النوع");

                                }
                                else
                                {
                                    try { 

                                    n.add_employ(Convert.ToInt32(id.Text), name.Text, Convert.ToInt32(salary.Text),
                                       card_number.Text, Age.Text,sex.Text, Convert.ToDateTime(dt.Value.ToString()),  mob.Text);
                                        MessageBox.Show("تم الاضافه بنجاح");

                                    }
                                    catch
                                    {
                                        MessageBox.Show("error"+e.ToString());
                                        return; 

                                    }

                                    bill_Manegment_constractor();
                                    ds = ob.show_employees_id();
                                    id.Text = ds.Rows[0][0].ToString();
                                    name.Text = "اسم الموظف";
                                    salary.Text = "سعر الساعه";
                                    card_number.Text = "الرقم القومي";
                                    Age.Text = "العمر";
                                    dt.Value = DateTime.Now;
                                    sex.Text = "النوع";
                                    mob.Text = "المحمول";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {

                    oc.delete_empoloy(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value));
                    bill_Manegment_constractor();


                }
                catch
                {
                    MessageBox.Show("error" + e);
                    return;
                }
            }
            else
            {
                return;
            }
            
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            name.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            salary.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            card_number.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            Age.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            dt.Value = Convert.ToDateTime( this.dgv.CurrentRow.Cells[6].Value.ToString());
            sex.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();
            mob.Text = this.dgv.CurrentRow.Cells[7].Value.ToString();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                n.update_employees(Convert.ToInt32(id.Text), name.Text, Convert.ToInt32(salary.Text),
                    card_number.Text, Age.Text, Convert.ToDateTime(dt.Value.ToString()), sex.Text, mob.Text);

                MessageBox.Show("تم التعديل بنجاح");
            }
            catch
            {
                MessageBox.Show("erorr"+e.ToString());
                return ;

            }

            bill_Manegment_constractor();
            ds = ob.show_employees_id();
            id.Text = ds.Rows[0][0].ToString();
            name.Text = "اسم الموظف";
            salary.Text = "سعر الساعه";
            card_number.Text = "الرقم القومي";
            Age.Text = "العمر";
            dt.Value = DateTime.Now;
            sex.Text = "النوع";
            mob.Text = "المحمول";
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
            ds = ob.show_employees_id();
            id.Text = ds.Rows[0][0].ToString();
            name.Text = "اسم الموظف";
            salary.Text = "سعر الساعه";
            card_number.Text = "الرقم القومي";
            Age.Text = "العمر";
            dt.Value = DateTime.Now;
            sex.Text = "النوع";
            mob.Text = "المحمول";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void Medicin_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            expenses m = new expenses();
            m.Show();
            this.Hide();
        }
    }
}
