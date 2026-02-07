using pharmacy.PL;
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
    public partial class show_billing : Form
    {
        DataTable dt = new DataTable();
        PL.billingcs ob = new PL.billingcs();
        public void updatemed_add()
        {
            billingcs b = new billingcs();
            b.add_med(Convert.ToInt32(this.dgp.CurrentRow.Cells[4].Value)
                , this.dgp.CurrentRow.Cells[1].Value.ToString()
                , this.dgp.CurrentRow.Cells[6].Value.ToString());
              }
        public void bill_Manegment_constractor()
        {

            dt = ob.show_billing();
            dgp.DataSource = dt;
            dgp.AllowUserToAddRows = false;

        }
        public show_billing()
        {
            InitializeComponent();
            bill_Manegment_constractor();
        }

        private void show_billing_Load(object sender, EventArgs e)
        {
            date1.Value = DateTime.Now;
            Date.Value = DateTime.Now;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void id_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                dt = ob.bill_search_by_id(Convert.ToInt32(id.Text));
                dgp.DataSource = dt;
            }
            catch
            {
                return;
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
           

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {
                    billingcs mb = new billingcs();
                    updatemed_add();
                    ob.delete_bill(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    mb.salp_med();

                    bill_Manegment_constractor();
                }
                catch
                {
                    MessageBox.Show("error" + e);
                    return;
                }
            }

            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                dt = ob.serch_biliing_cust(cust.Text);
                dgp.DataSource = dt;
                double y = 0;
                for (int i = 0; i < dgp.Rows.Count; i++)
                {
                    y += Convert.ToDouble(dgp.Rows[i].Cells[6].Value);
                }
                Total_Amount.Text = "اجمالي التكلفه=" + y.ToString() + "جنيه";
            }
            catch
            {
                return;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            allbills m = new allbills();
            m.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                dt = ob.serch_biliing_date(Convert.ToDateTime(Date.Value), Convert.ToDateTime(date1.Value));
                dgp.DataSource = dt;
            }
            catch
            {
                return;
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            allbills n = new allbills();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            homeform m = new homeform();
            m.Show();
            this.Hide();
        }
    }
}
