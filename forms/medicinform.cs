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
    public partial class medicinform : Form
    {
        pharmacy.PL.userspl ob = new pharmacy.PL.userspl();
        DataTable ds = new DataTable();
        PL.med n = new PL.med();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=DR_samar_pharmcy;Persist Security Info=True;User ID=hosny;Password=Hosnyaz123");
        /*  public void populate()
          {
              con.Open();
              string sql = "select * from medicine";
              SqlDataAdapter dataadp = new SqlDataAdapter(sql,con);
              SqlCommandBuilder commendbu = new SqlCommandBuilder(dataadp);
              var ds = new DataSet();
              dataadp.Fill(ds);
              dgp.ReadOnly = true;
              dgp.DataSource = ds.Tables[0];

              con.Close();
          }*/
        public void show_company()
        {
            con.Open();
            string sql = "select name from [Medicine_Manufacturer]";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
        //    SqlDataAdapter dataadp;
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            combany.ValueMember = "name";
            combany.DataSource = dt;
            con.Close();

        }

        public void bill_Manegment_constractor()
        {
            DataTable dt = new DataTable();
            PL.userspl ob = new PL.userspl();
            dt = ob.view_all_med();
            dgp.DataSource = dt;
            dgp.Columns[0].Width = 55;
            dgp.Columns[1].Width = 170;
            dgp.Columns[2].Width = 120;
            dgp.Columns[3].Width = 100;
            dgp.Columns[4].Width = 100;
            dgp.Columns[5].Width = 120;
            dgp.Columns[6].Width = 115;
            dgp.Columns[7].Width = 100;
          
            //dgp.Columns[2].DefaultCellStyle.Format = "c";
          
               dgp.AllowUserToAddRows = false;

        }
        public medicinform()
        {
            InitializeComponent();
            ds = ob.show_medicine_id();
            id.Text = ds.Rows[0][0].ToString();
            show_company();
            bill_Manegment_constractor();
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

                                  
                                   
                                
        }

        private void medicinform_Load(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bill_Manegment_constractor();
            ds = ob.show_medicine_id();
            id.Text = ds.Rows[0][0].ToString();
            med_name.Text = "اسم الدواء";
            buy.Text = "سعر الشراء";
            sell.Text = "سعر البيع";
            Quantity.Text = "الكميه";
            dt.Value = DateTime.Now;
            combany.Text = "الشركه";
            BarCode.Text = "البار كود";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();
            med_name.Text = this.dgp.CurrentRow.Cells[1].Value.ToString();
            buy.Text = this.dgp.CurrentRow.Cells[2].Value.ToString();
            sell.Text = this.dgp.CurrentRow.Cells[3].Value.ToString();
            Quantity.Text = this.dgp.CurrentRow.Cells[4].Value.ToString();
           tablet.Text= this.dgp.CurrentRow.Cells[5].Value.ToString();
            dt.Value = Convert.ToDateTime(this.dgp.CurrentRow.Cells[8].Value.ToString());
            combany.Text = this.dgp.CurrentRow.Cells[6].Value.ToString();
            BarCode.Text = this.dgp.CurrentRow.Cells[7].Value.ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("هل انت متأكد؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                try
                {
                   n.delete_med(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    /*string sql = "delete medicine where id='" + id.Text + "';";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();*/
                    MessageBox.Show("تم الحذف");

                    bill_Manegment_constractor();
                    ds = ob.show_medicine_id();
                    id.Text = ds.Rows[0][0].ToString();
                    med_name.Text = "اسم الدواء";
                    buy.Text = "سعر الشراء";
                    sell.Text = "سعر البيع";
                    Quantity.Text = "الكميه";
                    dt.Value = DateTime.Now;
                    combany.Text = "الشركه";
                    BarCode.Text = "البار كود";
                }
                catch
                {
                    MessageBox.Show("error"+e.ToString());
                    return;

                }
            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (med_name.Text == "" || med_name.Text == "medicinceName")
            {
                MessageBox.Show("لايوجد اسم للتعديل");
                //Focus( med_name.Text);
            }
            else
            {
                if (buy.Text == "" || buy.Text == "BuyingPrice")
                {
                    MessageBox.Show("لايوجد قيمه لسعر الشراء");

                }
                else
                {

                    if (sell.Text == "" || sell.Text == "SellingPrice")
                    {
                        MessageBox.Show("لايوجد قيمه لسعر البيع");

                    }
                    else
                    {
                        if (Quantity.Text == "" || Quantity.Text == "Quantity")
                        {
                            MessageBox.Show("لايوجد قيمه للكميه");

                        }
                        else
                        {
                            if (combany.Text == "" || combany.Text == "الشركه")
                            {
                                MessageBox.Show("لايوجد اسم شركه");

                            }
                            else
                            {
                                try
                                {
                                    n.update_medicine(med_name.Text ,
                                        Convert.ToDouble(buy.Text) ,
                                        Convert.ToDouble(sell.Text)
                                        , Convert.ToInt32(Quantity.Text) ,
                                        Convert.ToDateTime(dt.Value.ToString()) ,
                                        combany.Text ,
                                        Convert.ToInt32(id.Text),
                                        BarCode.Text,
                                        Convert.ToInt32(tablet.Text));
                          
                                    MessageBox.Show("تم التعديل بنجاح");

                                    bill_Manegment_constractor();
                                    ds = ob.show_medicine_id();
                                    id.Text = ds.Rows[0][0].ToString();
                                    med_name.Text = "اسم الدواء";
                                    buy.Text = "سعر الشراء";
                                    sell.Text = "سعر البيع";
                                    Quantity.Text = "الكميه";
                                    dt.Value = DateTime.Now;
                                    combany.Text = "الشركه";
                                    BarCode.Text = "البار كود";
                                }
                                catch
                                {
                                    MessageBox.Show(e.ToString());
                                }
                              /*  string sql = "update medicine set MedName='" + med_name.Text + "',Bprice='" + Convert.ToDouble(buy.Text) + "',Sprice='" + Convert.ToDouble(sell.Text) + "',MedQty='" + Quantity.Text + "',ExpDate='" + Convert.ToDateTime(dt.Value.ToString()) + "',company='" + combany.Text + "',barcode='" + BarCode.Text + "' where id='" + Convert.ToInt32(id.Text) + "'";
                                con.Open();
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.ExecuteNonQuery();*/
                               
                            }
                        }
                    }
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (med_name.Text == "" || med_name.Text == "اسم الدواء")
            {
                MessageBox.Show("برجاء ادخال اسم الدواء");
                //Focus( med_name.Text);
            }
            else
            {
                if (buy.Text == "" || buy.Text == "BuyingPrice")
                {
                    MessageBox.Show("برجاء ادخال القيمه المشتري بها الدواء");

                }
                else
                {

                    if (sell.Text == "" || sell.Text == "SellingPrice")
                    {
                        MessageBox.Show("برجاء ادخال القيمه التي سيباع بها الدواء");

                    }
                    else
                    {
                        if (Quantity.Text == "" || Quantity.Text == "Quantity")
                        {
                            MessageBox.Show("برجاء ادخال كميه هذا الدواء");

                        }
                        else
                        {
                            if (combany.Text == "")
                            {
                                MessageBox.Show("برجاء ادخال اسم الشركه");

                            }
                            else
                            {

                                try
                                {
                                    n.new_med(med_name.Text, Convert.ToDouble(buy.Text), Convert.ToDouble(sell.Text),
                                        Convert.ToInt32(Quantity.Text), Convert.ToDateTime(dt.Value), combany.SelectedValue.ToString(),
                                        Convert.ToInt32(id.Text), BarCode.Text,Convert.ToInt32(tablet.Text));
                                    MessageBox.Show("تم الاضافه بنجاح");
                                    bill_Manegment_constractor();
                                    ds = ob.show_medicine_id();
                                    id.Text = ds.Rows[0][0].ToString();
                                    med_name.Text = "اسم الدواء";
                                    buy.Text = "سعر الشراء";
                                    sell.Text = "سعر البيع";
                                    Quantity.Text = "الكميه";
                                    dt.Value = DateTime.Now;
                                    combany.Text = "الشركه";
                                    BarCode.Text = "البار كود";

                                }
                                catch
                                {

                                    MessageBox.Show("هذالتسجيل موجود بالفعل", "اضافه دواء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    // populate();
                                    ds = ob.show_medicine_id();
                                    id.Text = ds.Rows[0][0].ToString();
                                    med_name.Text = "اسم الدواء";
                                    buy.Text = "سعر الشراء";
                                    sell.Text = "سعر البيع";
                                    Quantity.Text = "الكميه";
                                    dt.Value = DateTime.Now;
                                    combany.Text = "الشركه";
                                    BarCode.Text = "البار كود";
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Quantity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void buy_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void sell_OnValueChanged(object sender, EventArgs e)
        {
            if (sell.Text == ""||sell.Text==ToString())
            {
                buying.Enabled = false;
            }
            else
            {
               
                buying.Enabled = true;


            }
        }

        private void med_name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            homeform h = new homeform();
            h.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            try
            {


                double n, m, v;
                n = Convert.ToDouble(sell.Text) - Convert.ToDouble(buying.Text);
                m = n / Convert.ToDouble(sell.Text);
                v = m * 100;
                buy.Text = v.ToString();
            }
            catch
            {
                return;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {
            DataTable f = new DataTable();
           f= ob.all_med_withname(name.Text);
            dgp.DataSource = f;
        }
    } 
}
