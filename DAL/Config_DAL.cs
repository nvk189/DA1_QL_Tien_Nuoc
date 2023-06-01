using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Management.Instrumentation;
using System.Configuration;

namespace DAL
{
    public class Config_DAL
    {

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;


        // ham khoi tao khi goi class config ra no se chay vao ham nay dau tien va thuc hien nhuwng ham co trong ham nay
        public Config_DAL()
        {
            this.Conection();
        }



        public void Conection()
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-A45UN95\SQLEXPRESS;Initial Catalog=SQL_QLTTTN_DA1;Integrated Security=True");
                con.Open();
                // ham nay kiem tra xem database da mo chua mo roi thi dong lai
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }
            catch 
            {
               
            }

        }

        // ham dua du lieu vao bang truyen vao ham la 1 chuoi ket noi
        //ham tra ve 1 bang

        public DataTable GetDataTable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

      
        //ham thuc hien cacs tac vu them sua xoa
        //truyen vao ham 1 chuoi ket noi,nam,object, so luong doi tuong
        public int Excute(string sql, string[] Name, object[] Values, int so_luong)
        {
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
     

            //kiem tra ket noi
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            //duyet tu dau mang den cuoi mang vd trong database 
            for (int i = 0; i < so_luong; i++)
            {
                cmd.Parameters.AddWithValue(Name[i], Values[i]);

            }
            return cmd.ExecuteNonQuery();
        }


        //ham tim kiem 

        public DataTable ExecuteSearch(string sql, string[] Name, object[] Values, int So_luong)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }


            var command = new SqlCommand(sql, con);
            command.CommandType = CommandType.StoredProcedure;
           
            if (So_luong > 0)
            {
                for (int i = 0; i < So_luong; i++)
                {
                    command.Parameters.AddWithValue(Name[i], Values[i]);
                }
            }

            var dataTable = new DataTable();
            var dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }


       

    }






}
