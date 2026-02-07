using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class salarys
    {
        public void delete_sal(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_sal", p);
            ob.close();
        }
        public DataTable all_salary()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_salary", null);
            ob.close();
            return dt;
        }
        public void add_salary(int id, string @medname,
          Double @bprice,
          Double @sprice,
          Double @medqty,DateTime date
         
         )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @medname;
            p[2] = new SqlParameter("@total_h", SqlDbType.Float);
            p[2].Value = @bprice;
            p[3] = new SqlParameter("@h_cost", SqlDbType.Float);
            p[3].Value = @sprice;
            p[4] = new SqlParameter("@total_salary", SqlDbType.Float);
            p[4].Value = @medqty;
            p[5] = new SqlParameter("@date", SqlDbType.Date);
            p[5].Value = date;



            ob.RUA("add_salary", p);
            ob.close();
        }
        public DataTable salary_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("salary_id", null);
            ob.close();
            return dt;
        }
        public DataTable serch_salary_date(DateTime date, DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("serch_salary_dates", p);
            ob.close();
            return dt;
        }
    }
}
