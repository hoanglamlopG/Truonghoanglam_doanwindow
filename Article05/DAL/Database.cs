using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Article05.Model;
using System.Data;
using Article05;

namespace Article05
{
    public class SqlconnectionData
    {
        //tạo chuỗi kết nối csdl
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-JGB5HJH\SQLEXPRESS; Initial Catalog = sale1; User Id = sa; Password=123";
            //string strcon = @"Data Source = DESKTOP - CPNOIOD\SQLEXPRESS; Initial Catalog = QuanLySinhVien; User Id = sa; Password=123";
            SqlConnection conn = new SqlConnection(strcon);//khởi tạo csdl
            return conn;
        }
    }


    public class Database
    {
        public static string CheckLoginDTO(TaiKhoan taiKhoan)
        {
            string user = null;
            // hàm connec tới csdl
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taiKhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taiKhoan.sMatKhau);
            //kiểm tra quyền 
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;

                }
                reader.Close();
                conn.Close();

            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
    }
}
