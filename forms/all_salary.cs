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
    public partial class all_salary : Form
    {
        pharmacy.PL.salarys ob = new pharmacy.PL.salarys();
        DataTable ds = new DataTable();
        public void bill_Manegment_constractor()
        {

            ds = ob.all_salary();
            dgv.DataSource = ds;
            dgv.AllowUserToAddRows = false;

        }
        public all_salary()
        {
            InitializeComponent();
            bill_Manegment_constractor();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
          

        }

        private void all_salary_Load(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {

                    ob.delete_sal(Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value));
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
               ds= ob.serch_salary_date(Convert.ToDateTime(date1.Value), Convert.ToDateTime(date2.Value));
                dgv.DataSource = ds;
            }
            catch
            {
                MessageBox.Show("خطأ" + e.ToString()) ;
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            expenses n = new expenses();
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
