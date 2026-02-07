using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class billingcs
    {
        public DataTable show_billing()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_billing", null);
            ob.close();
            return dt;
        }
        public DataTable show_med_name()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_med_name", null);
            ob.close();
            return dt;
        }
        public DataTable xpr_date(string date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@med", SqlDbType.NVarChar, 50);
            p[0].Value = date;
            dt = ob.Reader("xpr_date", p);
            ob.close();
            return dt;
        }
        public DataTable fetch_with_date(string medname,string exp)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@medname", SqlDbType.NVarChar, 50);
            p[0].Value = medname;
            p[1] = new SqlParameter("@exp", SqlDbType.NVarChar, 50);
            p[1].Value = exp;
            dt = ob.Reader("fetch_with_date", p);
            ob.close();
            return dt;
        }
        public DataTable fetch_with_name(string medname)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@medname", SqlDbType.NVarChar, 50);
            p[0].Value = medname;
           
            dt = ob.Reader("fetch_with_name", p);
            ob.close();
            return dt;
        }

        public DataTable bill_search_by_id(int date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = date;
            dt = ob.Reader("bill_search_by_id", p);
            ob.close();
            return dt;
        }
        public DataTable serch_biliing_date(DateTime date,DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("serch_biliing_date", p);
            ob.close();
            return dt;
        }
        public DataTable serch_biliing_cust(string date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@date", SqlDbType.NVarChar,50);
            p[0].Value = date;
            dt = ob.Reader("serch_biliing_cust", p);
            ob.close();
            return dt;
        }
        public void add_med(int @amount, string @medname, string date)
        {
            Dxl ob = new Dxl();
        ob.open();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@amount", SqlDbType.Int);
            p[0].Value = @amount;
            p[1] = new SqlParameter("@medname", SqlDbType.NVarChar, 50);
            p[1].Value = @medname;
            p[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
            p[2].Value = date;
            ob.RUA("add_med", p);
            ob.close();
        }
        public void salp_med()
        {
            Dxl ob = new Dxl();
            ob.open();
            ob.RUA("salp_med", null);
            ob.close();
        }
        public void delete_bill(int id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.RUA("delete_bill", p);
            ob.close();
        }
        public void add_billing(int id, string time,string date,string @med_name,
            int qnt, float up, float pp,
            float tp,string exp,
            float tpf,string cm,int tablets)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[12];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@time", SqlDbType.NVarChar, 50);
            p[1].Value = time;
            p[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
            p[2].Value = date;
            p[3] = new SqlParameter("@med_name", SqlDbType.NVarChar,50);
            p[3].Value = @med_name;
            p[4] = new SqlParameter("@quantity", SqlDbType.Int);
            p[4].Value = qnt;
            p[5] = new SqlParameter("@unit_price", SqlDbType.Float);
            p[5].Value = up;
            p[6] = new SqlParameter("@paying_price", SqlDbType.Float);
            p[6].Value = pp;
            p[7] = new SqlParameter("@total_price", SqlDbType.Float);
            p[7].Value = tp;
            p[8] = new SqlParameter("@exp", SqlDbType.Date);
            p[8].Value = exp;
            p[9] = new SqlParameter("@total_profit", SqlDbType.Float);
            p[9].Value = tpf;
            p[10] = new SqlParameter("@costomer_num", SqlDbType.NVarChar, 50);
            p[10].Value = cm;
            p[11] = new SqlParameter("@tablets", SqlDbType.Int);
            p[11].Value = tablets;

            ob.RUA("add_billing", p);
            ob.close();
        }
    }
}
