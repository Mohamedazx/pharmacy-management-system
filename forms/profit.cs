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
    public partial class profit : Form
    {
        DataTable dt = new DataTable();
        PL.all_profit ob = new PL.all_profit();
        public profit()
        {
            InitializeComponent();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            expenses n = new expenses();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            homeform n = new homeform();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            dt = ob.profit_billing(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgp.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[0].Value);

            }
            cost.Text = "دخل الادويه : " + x.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dt = ob.profit_salary(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgv.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[0].Value);

            }
            cost.Text = "مجموع المرتبات : " + x.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            dt = ob.profit_bills(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgc.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgc.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgc.Rows[i].Cells[0].Value);

            }
            cost.Text = "مجموع الفواتير : " + x.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dt = ob.profit_billing(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgp.DataSource = dt;
            dt = ob.profit_salary(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgv.DataSource = dt;
            dt = ob.profit_bills(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgc.DataSource = dt;
            Double x = 0;
            Double y = 0;
            Double z = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[0].Value);

            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                y += Convert.ToDouble(dgv.Rows[i].Cells[0].Value);

            }
            for (int i = 0; i < dgc.Rows.Count; i++)
            {
                z += Convert.ToDouble(dgc.Rows[i].Cells[0].Value);

            }
            cost.Text = "صافي الربح : " + (x - (y + z)).ToString();
        }
    }
}
