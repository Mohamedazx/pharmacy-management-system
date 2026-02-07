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
    public partial class billing_form : Form
    {
       
        int number = 0;
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();
       int v;
        int x;
        int z;
        string y;
        double pts, buing;
        DateTime Date;

        PL.billingcs mb = new PL.billingcs();//\\SQLEXPRESS
      //  SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");  
        public void popudate()
        {
            try
            {
                dt = mb.xpr_date(comboBox1.Text);
                expd.DataSource = dt;
                expd.DisplayMember = "ExpDate";
                expd.ValueMember = "ExpDate";
            }
            catch
            {

            }
        }
       
     public void fetch()
        {
            try
            {
                DataTable dtv = new DataTable();
                dtv = mb.fetch_with_name(comboBox1.SelectedValue.ToString());
               /* foreach (DataRow dr in dtv.Rows)
                {*/
                    x = Convert.ToInt32(dtv.Rows[0][0].ToString());//Convert.ToInt32(dr["MedQty"].ToString());
                    z = Convert.ToInt32(dtv.Rows[0][1].ToString());
                    v = Convert.ToInt32(dtv.Rows[0][2].ToString());


                   pts = Convert.ToDouble(dtv.Rows[0][3].ToString());//Convert.ToDouble(dr["Sprice"].ToString());
                   ava.Text = "الكميه المتاحه = " + dtv.Rows[0][0].ToString();// dr["MedQty"].ToString();
                   tablet.Text = "كميه الاشرطه = " + dtv.Rows[0][1].ToString(); //+ dr["all_tablet"].ToString();
                   total_profit.Text = dtv.Rows[0][4].ToString();//dr["total_profit"].ToString();
                   unit_price.Text = pts.ToString();
                   buing = Convert.ToDouble(dtv.Rows[0][5].ToString());//Convert.ToDouble(dr["Bprice"].ToString());
                   unite_buying.Text = buing.ToString();
                   Date = Convert.ToDateTime(dtv.Rows[0][6].ToString());  //Convert.ToDateTime( dr["ExpDate"].ToString());
                   exp.Text = Date.ToShortDateString();
                   y = Convert.ToString(dtv.Rows[0][7].ToString());//Convert.ToString(dr["barcode"].ToString());
                   barcode.Text = y;
                   
               // }
               
            }
            catch(Exception ex)
            {
              //  MessageBox.Show("خطأ في اظهار البينات"+ex.ToString());
                return;
            }
        }   
        public void peche()
        {
           try
            {
                DataTable dtx = new DataTable();
               
               dtx = mb.fetch_with_date(comboBox1.SelectedValue.ToString(), expd.SelectedValue.ToString());
             x = Convert.ToInt32(dtx.Rows[0][0].ToString());//Convert.ToInt32(dr["MedQty"].ToString());
            z = Convert.ToInt32(dtx.Rows[0][1].ToString());
            v = Convert.ToInt32(dtx.Rows[0][2].ToString());


            pts = Convert.ToDouble(dtx.Rows[0][3].ToString());//Convert.ToDouble(dr["Sprice"].ToString());
            ava.Text = "الكميه المتاحه = " + dtx.Rows[0][0].ToString();// dr["MedQty"].ToString();
            tablet.Text = "كميه الاشرطه = " + dtx.Rows[0][1].ToString(); //+ dr["all_tablet"].ToString();
            total_profit.Text = dtx.Rows[0][4].ToString();//dr["total_profit"].ToString();
            unit_price.Text = pts.ToString();
            buing = Convert.ToDouble(dtx.Rows[0][5].ToString());//Convert.ToDouble(dr["Bprice"].ToString());
            unite_buying.Text = buing.ToString();
            Date = Convert.ToDateTime(dtx.Rows[0][6].ToString());  //Convert.ToDateTime( dr["ExpDate"].ToString());
            exp.Text = Date.ToShortDateString();
            y = Convert.ToString(dtx.Rows[0][7].ToString());//Convert.ToString(dr["barcode"].ToString());
            barcode.Text = y;
            /* foreach (DataRow dr in dtx.Rows)
             {

             x = Convert.ToInt32(dr["MedQty"].ToString());
             z = Convert.ToInt32(dr["all_tablet"].ToString());
             v = Convert.ToInt32(dr["tablet"].ToString());

             pts = Convert.ToDouble(dr["Sprice"].ToString());
             ava.Text = "الكميه المتاحه = " + dr["MedQty"].ToString();

             tablet.Text = "كميه الاشرطه = " + dr["all_tablet"].ToString();
             total_profit.Text = dr["total_profit"].ToString();
             unit_price.Text = pts.ToString();
             buing = Convert.ToDouble(dr["Bprice"].ToString());
             unite_buying.Text = buing.ToString();
             Date = Convert.ToDateTime(dr["ExpDate".ToString()]);
                 exp.Text = Date.ToShortDateString();
             y = Convert.ToString(dr["barcode"].ToString());
             barcode.Text = y;*/

       // }
                
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.ToString()); 
            }
        }

        public void updatemed_add()
        {

            try
            {
                ob.add_med(Convert.ToInt32(this.dgp.CurrentRow.Cells[4].Value)
               , this.dgp.CurrentRow.Cells[1].Value.ToString()
               , this.dgp.CurrentRow.Cells[6].Value.ToString());
            }
            catch
            {

            }
        }
        public void updatemed_minas()
        {
            try
            {


                ob.minas_med(Convert.ToInt32(Quantity.Text),
                    comboBox1.SelectedValue.ToString()
                    , exp.Text,
                    Convert.ToInt32(Quantity.Text) * v + Convert.ToInt32(tablets.Text));
            }
            catch
            {

            }
        }
        public void bill_Manegment_constractor()
        {
            DataTable dt = new DataTable();
            PL.userspl ob = new PL.userspl();
            dt = ob.view_all_bills(Convert.ToInt32(id.Text),Convert.ToInt32(namper.Text));
            dgp.DataSource = dt;
            dgp.Columns[0].Width = 55;
            dgp.Columns[1].Width = 170;
            dgp.Columns[2].Width = 120;
            dgp.Columns[3].Width = 100;
            dgp.Columns[4].Width = 100;
            dgp.Columns[5].Width = 120;
            dgp.Columns[6].Width = 115;
            dgp.Columns[7].Width = 100;
          
           dgp.Columns[2].DefaultCellStyle.Format = "c";
            dgp.Columns[5].DefaultCellStyle.Format = "c";



        }
        public billing_form()
        {
            InitializeComponent();

           // mb.show_med_name();
            dt = mb.show_med_name();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "MedName";
            comboBox1.ValueMember = "MedName";
            popudate();

        }

        private void billing_form_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                comboBox1.Text = "اسم الدواء";
                DataTable dt = new DataTable();
                dt = ob.show_bill_id();
                id.Text = dt.Rows[0][0].ToString();
                namper.Text = Convert.ToString(number);

                bill_Manegment_constractor();
                barcode.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

        }

        private void select_med_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetch();
        }
       

        private void Total_Amount_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Bitmap bitmap;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 432, 12, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
           
        }

       

       

       

        private void bunifuThinButton22_Click_2(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد ..! ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {
                    updatemed_add();
                    ob.delete_bill(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    mb.salp_med();
                    //fetch();
                bill_Manegment_constractor();
               }
                catch
                {
                   // MessageBox.Show("error"+e);
                    return;
                }
                double x = 0;
                for (int i = 0; i < dgp.Rows.Count; i++)
                {
                    x += Convert.ToDouble(dgp.Rows[i].Cells[5].Value);
                }
                Total_Amount.Text = "اجمالي التكلفه=" + x.ToString();

            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

       
        private void barcode_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                PL.userspl f = new PL.userspl();
                ds = f.barcode(barcode.Text);
                comboBox1.DataSource = ds; 
                fetch();
                popudate();
            }
            catch
            {
               // MessageBox.Show(e.ToString());

                return;
            }
           
        }

        private void Quantity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                if (Quantity.Text == "" || Quantity.Text == "عدد العلب" || tablet.Text == "عدد الاشرطه" || tablet.Text == "0")
                {
                    MessageBox.Show("     برجاء ادخال الكميه المراد بيعها     ");
                }

                else if (Convert.ToInt32(Quantity.Text) > x)
                {
                    MessageBox.Show("    عفوا لا يوجد علب كافيه    ");

                }

                else if ((Convert.ToInt32(Quantity.Text) * v) + Convert.ToInt32(tablets.Text) > z)

                {
                    MessageBox.Show("     عفوا لا يوجد اشرطه كافيه    ");

                }

                else if (Convert.ToDateTime( Date) < DateTime.Now)
                {
                    MessageBox.Show("    انتهت صلاحيه هذا المنتج   ");

                }

                else
                {
                /* try
                 {*/
                float g; float m; float l; float t; float j; float o;
                g = (float)(Convert.ToDouble(unit_price.Text) * Convert.ToInt32(Quantity.Text));
                m= (float)((Convert.ToDouble(unit_price.Text) / v)*Convert.ToInt32(tablets.Text));
                l = g + m;
                
                t = (float)(Convert.ToDouble(total_profit.Text) * Convert.ToInt32(Quantity.Text));
                j = (float)((Convert.ToDouble(total_profit.Text) / v) * Convert.ToInt32(tablets.Text));
                o = t + j;
                DateTime timenow =Convert.ToDateTime( DateTime.Now.ToShortTimeString());
                DateTime datenow = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime expir = Convert.ToDateTime(exp.Text);
                mb.add_billing(
                            Convert.ToInt32(id.Text),
                            timenow.ToString(),
                         datenow.ToString(),
                           comboBox1.SelectedValue.ToString(),
                           Convert.ToInt32(Quantity.Text),
                           (float)(Convert.ToDouble(unit_price.Text)),
                           (float)(Convert.ToDouble(unite_buying.Text)),
                          l  ,
                           expir.ToShortDateString(),
                         o
                           , cust.Text, (Convert.ToInt32(Quantity.Text)*v)+ Convert.ToInt32(tablets.Text)

                           );
                        dt = ob.show_bill_id();
                        id.Text = dt.Rows[0][0].ToString();
                        ob.minas_med(Convert.ToInt32(Quantity.Text),
                               comboBox1.SelectedValue.ToString()
                               ,exp.Text,
                               Convert.ToInt32(Quantity.Text) * v + Convert.ToInt32(tablets.Text));
                                        mb.salp_med();
                            namper.Text = Convert.ToString(number = number + 1);

                   /* }
                    catch
                    {
                        MessageBox.Show(Convert.ToString(e) + "خطأ في ادخال البينات");
                    }*/

                   // fetch();
              //  pech();
                    bill_Manegment_constractor();
                    double y = 0;
                    for (int i = 0; i < dgp.Rows.Count; i++)
                    {
                        y += Convert.ToDouble(dgp.Rows[i].Cells[5].Value);
                    }
                    Total_Amount.Text = " اجمالي التكلفه=  " + y.ToString() + " جنيه ";
                    comboBox1.Text = "اسم الدواء";
                    barcode.Text = "";
                    barcode.Focus();
                }

           /* }
            catch
            {
               
                MessageBox.Show(e.ToString() );
                return;


            }*/

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            namper.Text = Convert.ToString(number=0);
            barcode.Text = "";
            Quantity.Text = "0";
            cust.Text = "0";
            bill_Manegment_constractor();
            double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[5].Value);
            }
            Total_Amount.Text = " اجمالي التكلفه=  " + x.ToString()+" جنيه ";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unit_price_Click(object sender, EventArgs e)
        {

        }

        private void unite_buying_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void namper_Click(object sender, EventArgs e)
        {

        }

        private void exp_Click(object sender, EventArgs e)
        {

        }

        private void select_med_SelectedValueChanged(object sender, EventArgs e)
        {
            fetch();
        }

        private void Medicin_Click(object sender, EventArgs e)
        {

        }

        private void select_med_TextChanged(object sender, EventArgs e)
        {
           fetch();
        }

        private void select_med_Enter(object sender, EventArgs e)
        {
            fetch();
        }

        private void bunifuThinButton23_Enter(object sender, EventArgs e)
        {

        }

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Quantity_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
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

        private void Quantity_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Quantity.Text = "";
        }

        private void cust_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cust.Text = "";
        }

       

        private void expd_SelectedIndexChanged(object sender, EventArgs e)
        {
             peche(); 
           // fetch();

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {*/
                fetch();
                popudate();
          /*  }
            catch
            {
                return;
            }*/
            
        }

        private void expd_Click(object sender, EventArgs e)
        {
            popudate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
          
            comboBox1.DataSource = mb.show_med_name();
            comboBox1.DisplayMember = "MedName";
            comboBox1.ValueMember = "MedName";


        }




    }
}
