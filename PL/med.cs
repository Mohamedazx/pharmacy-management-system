using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace pharmacy.PL
{
    class med
    {
        public void new_med(string @medname,
           Double @bprice,
           Double @sprice,
           int @medqty,
           DateTime @expdate,
           string @company,
           int id,
           string @barcode,int @tablet
          )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@medname", SqlDbType.NVarChar, 50);
            p[0].Value = @medname;
            p[1] = new SqlParameter("@bprice", SqlDbType.Float);
            p[1].Value = @bprice;
            p[2] = new SqlParameter("@sprice", SqlDbType.Float);
            p[2].Value = @sprice;
            p[3] = new SqlParameter("@medqty", SqlDbType.Int);
            p[3].Value = @medqty;
            p[4] = new SqlParameter("@expdate", SqlDbType.Date);
            p[4].Value = @expdate;
            p[5] = new SqlParameter("@company", SqlDbType.NVarChar, 50);
            p[5].Value = @company;
            p[6] = new SqlParameter("@id", SqlDbType.Int);
            p[6].Value = id;
            p[7] = new SqlParameter("@barcode", SqlDbType.NVarChar, 100);
            p[7].Value = @barcode;
            p[8] = new SqlParameter("@tablet", SqlDbType.Int);
            p[8].Value = @tablet;

            ob.RUA("add_medicine", p);
            ob.close();
        }

        public void update_medicine(string @medname,
          Double @bprice,
          Double @sprice,
          int @medqty,
          DateTime @expdate,
          string @company,
          int id,
          string @barcode,int tablet
         )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[9];
            p[0] = new SqlParameter("@medname", SqlDbType.NVarChar, 50);
            p[0].Value = @medname;
            p[1] = new SqlParameter("@bprice", SqlDbType.Float);
            p[1].Value = @bprice;
            p[2] = new SqlParameter("@sprice", SqlDbType.Float);
            p[2].Value = @sprice;
            p[3] = new SqlParameter("@medqty", SqlDbType.Int);
            p[3].Value = @medqty;
            p[4] = new SqlParameter("@expdate", SqlDbType.Date);
            p[4].Value = @expdate;
            p[5] = new SqlParameter("@company", SqlDbType.NVarChar, 50);
            p[5].Value = @company;
            p[6] = new SqlParameter("@id", SqlDbType.Int);
            p[6].Value = id;
            p[7] = new SqlParameter("@barcode", SqlDbType.NVarChar, 100);
            p[7].Value = @barcode;
            p[8] = new SqlParameter("@tablet", SqlDbType.Int);
            p[8].Value = tablet;



            ob.RUA("update_medicine", p);
            ob.close();
        }
        public void delete_med(int id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.RUA("delete_med", p);
            ob.close();
        }
    }
}
