using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace pharmacy.PL
{
    class employeess
    {
        public void update_employees(int @id ,string @name ,
int  @salary ,
string @card_number,
string @age ,
DateTime @date ,
string @gender,
string @mobile
      )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @name;
            p[2] = new SqlParameter("@salary", SqlDbType.Int, 50);
            p[2].Value = @salary;
            p[3] = new SqlParameter("@card_number", SqlDbType.NVarChar, 50);
            p[3].Value = @card_number;
            p[4] = new SqlParameter("@age", SqlDbType.NVarChar,50);
            p[4].Value = @age;
            p[5] = new SqlParameter("@date", SqlDbType.DateTime);
            p[5].Value = @date;
            p[6] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            p[6].Value = @gender;
            p[7] = new SqlParameter("@mobile", SqlDbType.NVarChar, 50);
            p[7].Value = @mobile;

            ob.RUA("update_employees", p);
            ob.close();
        }

        public void add_employ(int @id, string @name,
int @salary,
string @card_number,
string @age,

string @gender,
DateTime @date,
string @mobile
     )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = @name;
            p[2] = new SqlParameter("@salary", SqlDbType.Int, 50);
            p[2].Value = @salary;
            p[3] = new SqlParameter("@card_number", SqlDbType.NVarChar, 50);
            p[3].Value = @card_number;
            p[4] = new SqlParameter("@age", SqlDbType.NVarChar, 50);
            p[4].Value = @age;
           
            p[5] = new SqlParameter("@gender", SqlDbType.NVarChar, 50);
            p[5].Value = @gender;
            p[6] = new SqlParameter("@date", SqlDbType.DateTime);
            p[6].Value = @date;
            p[7] = new SqlParameter("@mobile", SqlDbType.NVarChar, 50);
            p[7].Value = @mobile;

            ob.RUA("add_employ", p);
            ob.close();
        }
        public void delete_empoloy(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_empoloy", p);
            ob.close();
        }
        public DataTable all_empoloy()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_empoloy", null);
            ob.close();
            return dt;
        }
        public DataTable catsh_salary(string pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@salary", SqlDbType.NVarChar,50);
            p[0].Value = pat_id;
            DataTable dt = new DataTable();
            dt=ob.Reader("catsh_salary", p);
            ob.close();
            return dt;
        }


    }
}
