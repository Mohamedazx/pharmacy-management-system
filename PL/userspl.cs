  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Data.SqlClient;




namespace pharmacy.PL
{
    class userspl
    {

        public DataTable search_med_info(string med_name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@med_name", SqlDbType.NVarChar, 100);
            p[0].Value = med_name;
            dt = ob.Reader("search_med_info", p);
            ob.close();
            return dt;
        }
        public DataTable View_user_state()
        {
            DataTable dt = new DataTable();
            pharmacy.Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_Users_state", null);
            ob.close();
            return dt;
        }


        public void new_user(int user_id,
            string full_name,
            string phone,
            string mob,
            string addres,
            string gender,
            string job,

            DateTime birth_day,
            string serial,
            DateTime user_date,
            DateTime user_time
           )
        {
           Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[11];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = user_id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = full_name;
            p[2] = new SqlParameter("@phon", SqlDbType.NVarChar, 50);
            p[2].Value = phone;
            p[3] = new SqlParameter("@phon1", SqlDbType.NVarChar, 50);
            p[3].Value = mob;
            p[4] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            p[4].Value = addres;
            p[5] = new SqlParameter("@sex", SqlDbType.NVarChar, 50);
            p[5].Value = gender;
            p[6] = new SqlParameter("@jop", SqlDbType.NVarChar, 50);
            p[6].Value = job;
            p[7] = new SqlParameter("@bteth_day", SqlDbType.Date);
            p[7].Value = birth_day;
            p[8] = new SqlParameter("@serial", SqlDbType.NVarChar, 50);
            p[8].Value = serial;
            p[9] = new SqlParameter("@date", SqlDbType.Date);
            p[9].Value = user_date;
            p[10] = new SqlParameter("@time", SqlDbType.DateTime);
            p[10].Value = user_time;
            
            ob.RUA("new_stuf", p);
            ob.close();
        }
        public DataTable show_employees_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_employees_id", null);
            ob.close();
            return dt;
        }

        public DataTable show_bill_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_bill_id", null);
            ob.close();
            return dt;
        }
        public DataTable Medicine_Manufacturer_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_company_id", null);
            ob.close();
            return dt;
        }
        public DataTable show_medicine_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_medicine_id", null);
            ob.close();
            return dt;
        }
        public DataTable show_come_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_come_id", null);
            ob.close();
            return dt;
        }




        public void update_user_info(int user_id,
            string full_name,
            string phone,
            string mob,
            string addres,
            string gender,
            string job,
            string curent_user,
            string user_name,
            string pass,
            DateTime birth_day,
            string serial,
            DateTime user_date,
            DateTime user_time,
            string user_curent)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[15];
            p[0] = new SqlParameter("@UserID", SqlDbType.Int);
            p[0].Value = user_id;
            p[1] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 100);
            p[1].Value = full_name;
            p[2] = new SqlParameter("@UserPhone", SqlDbType.NVarChar, 20);
            p[2].Value = phone;
            p[3] = new SqlParameter("@UserMobile", SqlDbType.NVarChar, 30);
            p[3].Value = mob;
            p[4] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, 200);
            p[4].Value = addres;
            p[5] = new SqlParameter("@UserGender", SqlDbType.NVarChar, 5);
            p[5].Value = gender;
            p[6] = new SqlParameter("@UserJob", SqlDbType.NVarChar, 50);
            p[6].Value = job;
            p[7] = new SqlParameter("@UserForProgramm", SqlDbType.NVarChar, 50);
            p[7].Value = curent_user;
            p[8] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            p[8].Value = user_name;
            p[9] = new SqlParameter("@UserPassword", SqlDbType.NVarChar, 50);
            p[9].Value = pass;
            p[10] = new SqlParameter("@UserDOB", SqlDbType.Date);
            p[10].Value = birth_day;
            p[11] = new SqlParameter("@UserCardID", SqlDbType.NVarChar, 20);
            p[11].Value = serial;
            p[12] = new SqlParameter("@UserDate", SqlDbType.Date);
            p[12].Value = user_date;
            p[13] = new SqlParameter("@UserTime", SqlDbType.DateTime);
            p[13].Value = user_time;
            p[14] = new SqlParameter("@UserCurrentUser", SqlDbType.NVarChar, 100);
            p[14].Value = user_curent;
            ob.RUA("Update_user_info", p);
            ob.close();
        }
        public void addcome(int @id ,
                                               string @name ,
                                               DateTime @date ,
                                               DateTime @time_com ,
                                             string   @nottocome)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            p[1].Value = @name;
            p[2] = new SqlParameter("@date", SqlDbType.Date);
            p[2].Value = @date;
            p[3] = new SqlParameter("@time_com", SqlDbType.DateTime);
            p[3].Value = @time_com;
            p[4] = new SqlParameter("@nottocome", SqlDbType.NVarChar, 200);
            p[4].Value = @nottocome;
           
           
            ob.RUA("addcome", p);
            ob.close();
        }

        public void add_go(int @id,
                                   DateTime @date ,
                                   string @total_time ,
                                   string @nottocome 
                                    )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = @id;
            p[1] = new SqlParameter("@date", SqlDbType.DateTime);
            p[1].Value = @date;
            p[2] = new SqlParameter("@total_time", SqlDbType.NVarChar, 50);
            p[2].Value = @total_time;
            p[3] = new SqlParameter("@nottocome", SqlDbType.NVarChar, 50);
            p[3].Value = @nottocome;
           
            ob.RUA("add_go", p);
            ob.close();
        }



        public void update_user_go(int user_id, DateTime birth_day, decimal total_h)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@UserID", SqlDbType.Int);
            p[0].Value = user_id;
            p[1] = new SqlParameter("@cometimego", SqlDbType.DateTime);
            p[1].Value = birth_day;
            p[2] = new SqlParameter("@total_h", SqlDbType.Decimal);
            p[2].Value = total_h;

            ob.RUA("Update_user_go", p);
            ob.close();
        }
        public void delete_user_info(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_user_info", p);
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

        public DataTable barcode(string barecode)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@barcode", SqlDbType.NVarChar,100);
            p[0].Value = barecode;
            dt = ob.Reader("barcode", p);
            ob.close();
            return dt;
        }
        public DataTable view_all_users()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_users", null);
            ob.close();
            return dt;
        }


        public DataTable search_income(string date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, (50));
            p[0].Value = date;
            dt = ob.Reader("search_income", p);
            ob.close();
            return dt;
        }

        public DataTable s_login(string user_name, string user_password, string user_type)

        {
            Dxl ob = new Dxl();


            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            p[0].Value = user_name;
            p[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            p[1].Value = user_password;
            p[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            p[2].Value = user_type;
            ob.open();
            dt = ob.Reader("S_login", p);

            return dt;
            ob.close();

        }
        public DataTable search_income_users(string date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, (50));
            p[0].Value = date;
           
            dt = ob.Reader("search_income_user", p);
            ob.close();
            return dt;
        }
        public DataTable come_go_search(string date)
        {
            DataTable dt = new DataTable();

            Dxl ob = new Dxl();

            ob.open();

            SqlParameter[] p = new SqlParameter[1];

            p[0] = new SqlParameter("@search", SqlDbType.NVarChar, (50));

            p[0].Value = date;
           
            dt = ob.Reader("com_go_date", p);

            ob.close();

            return dt;
        }

        public DataTable come_go_search_name(string date)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, (50));
            p[0].Value = date;
            dt = ob.Reader("come_go_search_name", p);
            ob.close();
            return dt;
        }
        public DataTable view_all_users_se()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_users_se", null);
            ob.close();
            return dt;
        }

        public DataTable view_all_come()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_come", null);
            ob.close();
            return dt;
        }

        public DataTable view_all_med()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_med", null);
            ob.close();
            return dt;
        }
        public DataTable all_med_withname(string name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar,(50));
            p[0].Value = name;
            dt = ob.Reader("all_med_withname", p);
            ob.close();
            return dt;
        }

        public void new_come(int user_id,
          string comedate,
           DateTime cometime,
           string comeuserfullname,
           DateTime cometimecome,
           string comenotecome)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@com_id", SqlDbType.Int);
            p[0].Value = user_id;
            p[1] = new SqlParameter("@comedate", SqlDbType.NVarChar, 50);
            p[1].Value = comedate;
            p[2] = new SqlParameter("@cometime", SqlDbType.DateTime);
            p[2].Value = cometime;
            p[3] = new SqlParameter("@comeuserfullname", SqlDbType.NVarChar,50);
            p[3].Value = comeuserfullname;
            p[4] = new SqlParameter("@cometimecome", SqlDbType.DateTime);
            p[4].Value = cometimecome;
;
            p[5] = new SqlParameter("@comenotecome", SqlDbType.NVarChar, 50);
            p[5].Value = comenotecome;
            
            ob.RUA("new_com", p);
            ob.close();
        }

        public DataTable search_outs(DateTime date,DateTime dates,string name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = date;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = dates;
            p[2] = new SqlParameter("@name", SqlDbType.NVarChar ,50);
            p[2].Value = name;
            dt = ob.Reader("search_outs", p);
            ob.close();
            return dt;
        }
        public DataTable view_all_bills(int id,int number)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@nambur", SqlDbType.Int);
            p[1].Value = number ;
            dt = ob.Reader("show_bills", p);
            ob.close();
            return dt;
        }

        public void minas_med(int @amount, string @medname,string date,int tablet)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@amount", SqlDbType.Int);
            p[0].Value = @amount;
            p[1] = new SqlParameter("@medname", SqlDbType.NVarChar,50);
            p[1].Value = @medname;
            p[2] = new SqlParameter("@date", SqlDbType.NVarChar, 50);
            p[2].Value = date;
            p[3] = new SqlParameter("@tablet", SqlDbType.Int);
            p[3].Value = tablet;

            ob.RUA("minas_med", p);
            ob.close();
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
        public DataTable cutsh_type()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("cutsh_type", null);
            ob.close();
            return dt;
        }
        public void set_user(string name, string type
     )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = name;
            p[1] = new SqlParameter("@user", SqlDbType.NVarChar, 50);
            p[1].Value = type;
            ob.RUA("set_user", p);
            ob.close();
        }



    }



}
