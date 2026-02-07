using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy.forms
{
    public partial class expebills : Form
    {
        PL.expbills ob = new PL.expbills();
        DataTable dt = new DataTable();
        public void bill_Manegment_constractor()
        {

            dt = ob.all_expbills();
            dgv.DataSource = dt;
            dgv.AllowUserToAddRows = false;

        }
        public expebills()
        {
            InitializeComponent();
            dt = ob.expbill_id();
            id.Text = dt.Rows[0][0].ToString();
            bill_Manegment_constractor();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                ob.add_expbill(Convert.ToInt32(id.Text), Convert.ToDouble(amount.Text), Convert.ToDateTime(dt_now.Value), note.Text);
                MessageBox.Show("تم ادخال الفتوره");
                dt = ob.expbill_id();
                id.Text = dt.Rows[0][0].ToString();
                bill_Manegment_constractor();
            }
            catch
            {
                MessageBox.Show("خطأ"+e.ToString());
                return;

            }
        }

        private void expebills_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                dt = ob.expbills_date(Convert.ToDateTime(date1.Value), Convert.ToDateTime(date2.Value));
                dgv.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("خطأ" + e.ToString());
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {

                    ob.delete_expbill(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value));
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            allbills n = new allbills();
            n.Show();
            this.Hide();
        }
    }
}
