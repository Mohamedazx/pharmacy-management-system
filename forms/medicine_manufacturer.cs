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
    public partial class medicine_manufacturer : Form
    {
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        DataTable ds = new DataTable();
        PL.medcin_munfer ot = new PL.medcin_munfer();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");
        public void bill_Manegment_constractor()
        {

            ds = ot.all_med_Manufacturer();
            dgv.DataSource = ds;
            dgv.AllowUserToAddRows = false;

        }/*
        public void populate()
        {
            con.Open();
            string sql = "select * from Medicine_Manufacturer";
            SqlDataAdapter dataadp = new SqlDataAdapter(sql, con);
            SqlCommandBuilder commendbu = new SqlCommandBuilder(dataadp);
            var ds = new DataSet();
            dataadp.Fill(ds);
            dgv.ReadOnly = true;
            dgv.DataSource = ds.Tables[0];

            con.Close();
        }*/
        public medicine_manufacturer()
        {
            InitializeComponent();
            bill_Manegment_constractor();
            ds = ob.Medicine_Manufacturer_id();
            id.Text = ds.Rows[0][0].ToString();
        }

        private void medicine_manufacturer_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || name.Text == "Name")
            {
                MessageBox.Show("برجاء ادخال اسم الشركه");
                //Focus( med_name.Text);
            }
            else
            {
                if (Adress.Text == "" || Adress.Text == "العنوان")
                {
                    MessageBox.Show("برجاء ادخال عنوان الشركه");

                }
                else
                {

                    if (mob.Text == "" || mob.Text == "المحمول")
                    {
                        MessageBox.Show("برجاء ادخال رقم التليفون");

                    }
                    else
                    {
                        try
                        {
                            ot.add_medicine_manufacturer(Convert.ToInt32(id.Text), name.Text, Adress.Text, mob.Text);

                            MessageBox.Show("تم الاضافه بنجاح");
                            bill_Manegment_constractor();
                            ds = ob.Medicine_Manufacturer_id();
                            id.Text = ds.Rows[0][0].ToString();
                            name.Text = "اسم الشركه";
                            Adress.Text = "العنوان";
                            mob.Text = "المحمول";
                        }
                        catch
                        {
                            MessageBox.Show("error"+e.ToString());
                            return;


                        }

                    }
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            name.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            Adress.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            mob.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DG == DialogResult.Yes)
                {

                    ot.delet_Medicine_Manufacturer(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value));

                    MessageBox.Show("تم الحذف");
                   
                    bill_Manegment_constractor();
                    ds = ob.Medicine_Manufacturer_id();
                    id.Text = ds.Rows[0][0].ToString();
                    name.Text = "اسم الشركه";
                    Adress.Text = "العنوان";
                    mob.Text = "المحمول";

                }
                else if (DG == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("error" + e.ToString());
                return;

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                ot.ubdate_medicine_manufacturer(Convert.ToInt32(id.Text), name.Text, Adress.Text, mob.Text);


                MessageBox.Show("تم التعديل بنجاح");

                bill_Manegment_constractor();
                ds = ob.Medicine_Manufacturer_id();
                id.Text = ds.Rows[0][0].ToString();
                name.Text = "اسم الشركه";
                Adress.Text = "العنوان";
                mob.Text = "المحمول";
            }
            catch
            {
                MessageBox.Show("error" + e.ToString());
                return;


            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
            ds = ob.Medicine_Manufacturer_id();
            id.Text = ds.Rows[0][0].ToString();
            name.Text = "اسم الشركه";
            Adress.Text = "العنوان";
            mob.Text = "المحمول";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void Adress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            homeform n = new homeform();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

        }
    }
}
