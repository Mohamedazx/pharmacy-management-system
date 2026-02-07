using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class medcin_munfer
    {
        public void add_medicine_manufacturer(int id, string @medname,
         string @bprice,
         string @sprice     
        )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @medname;
            p[2] = new SqlParameter("@adress", SqlDbType.NVarChar,50);
            p[2].Value = @bprice;
            p[3] = new SqlParameter("@mob", SqlDbType.NVarChar,50);
            p[3].Value = @sprice;
            
            ob.RUA("add_medicine_manufacturer", p);
            ob.close();
        }
        public void ubdate_medicine_manufacturer(int id, string @medname,
        string @bprice,
        string @sprice
       )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @medname;
            p[2] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            p[2].Value = @bprice;
            p[3] = new SqlParameter("@mob", SqlDbType.NVarChar, 50);
            p[3].Value = @sprice;

            ob.RUA("ubdate_medicine_manufacturer", p);
            ob.close();
        }
        public DataTable all_med_Manufacturer()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_med_Manufacturer", null);
            ob.close();
            return dt;
        }
        public void delet_Medicine_Manufacturer(int id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.RUA("delet_Medicine_Manufacturer", p);
            ob.close();
        }
    }
}
