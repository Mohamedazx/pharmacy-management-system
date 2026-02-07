using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class expbills
    {
        public DataTable expbill_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("expbill_id", null);
            ob.close();
            return dt;
        }
        public void delete_expbill(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_expbill", p);
            ob.close();
        }
        public void add_expbill(int @id,
         double @name,
         DateTime number,
         string mob

        )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@amount", SqlDbType.Float);
            p[1].Value = @name;
            p[2] = new SqlParameter("@date", SqlDbType.Date);
            p[2].Value = @number;
            p[3] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            p[3].Value = mob;



            ob.RUA("add_expbill", p);
            ob.close();
        }
        public DataTable all_expbills()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_expbills", null);
            ob.close();
            return dt;
        }
        public DataTable expbills_date(DateTime date, DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("expbills_date", p);
            ob.close();
            return dt;
    
        }
        public void delete_expbills(int id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.RUA("delete_expbills", p);
            ob.close();
        }
    }

}
