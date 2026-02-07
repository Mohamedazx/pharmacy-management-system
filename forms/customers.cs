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
    public partial class customers : Form
    {
        pharmacy.PL.costmers ob = new pharmacy.PL.costmers();
        DataTable ds = new DataTable();
        public void bill_Manegment_constractor()
        {
           
            ds = ob.all_cust();
            dgp.DataSource = ds;
            dgp.AllowUserToAddRows = false;

        }
        public customers()
        {

            InitializeComponent();
            ds = ob.show_cus_id();
            id.Text = ds.Rows[0][0].ToString();
            bill_Manegment_constractor();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {


                ob.add_costmer(Convert.ToInt32(id.Text), name.Text, number.Text, mob.Text);
                bill_Manegment_constractor();
            }
            catch
            {
                MessageBox.Show("error" + e.ToString());
            }
        }

        private void mob_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {
                    
                    ob.delete_cust_info(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
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

            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            allbills n = new allbills();
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
