using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class costmers
    {
        public DataTable show_cus_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("cust_id", null);
            ob.close();
            return dt;
        }
        public void delete_cust_info(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_cust", p);
            ob.close();
        }
        public void add_costmer(int @id,
          string @name,
          string number,
          string mob
         
         )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @name;
            p[2] = new SqlParameter("@numer", SqlDbType.NVarChar, 50);
            p[2].Value = @number;
            p[3] = new SqlParameter("@mobile", SqlDbType.NVarChar,50);
            p[3].Value = mob;
          


            ob.RUA("add_costmer", p);
            ob.close();
        }
        public DataTable all_cust()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_cust", null);
            ob.close();
            return dt;
        }
    }
}
