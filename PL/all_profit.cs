using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class all_profit
    {
        public DataTable profit_billing(DateTime date, DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("profit_billing", p);
            ob.close();
            return dt;

        }
        public DataTable profit_salary(DateTime date, DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("profit_salary", p);
            ob.close();
            return dt;

        }
        public DataTable profit_bills(DateTime date, DateTime date1)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = date1;
            dt = ob.Reader("profit_bills", p);
            ob.close();
            return dt;
        }
        }

}
