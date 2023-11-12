using Article05.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.DAL
{
    public class NhanvienDAL : DBConnection
    {
        public List<NhanvienBEL> ReadNhanvien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from nhanvien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanvienBEL> lstCus = new List<NhanvienBEL>();
            AreaDAL are = new AreaDAL();
            while (reader.Read())
            {
                NhanvienBEL cus = new NhanvienBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                var a = reader["id_area"].ToString();
                cus.Area = are.ReadArea(int.Parse(reader["id_area"].ToString()));
                cus.DienThoai = reader["dienthoai"].ToString();
                //THEM
                cus.NgaySinh = DateTime.Parse(reader["ngaysinh"].ToString());

                //
                cus.Anh = reader["anh"].ToString();
                lstCus.Add(cus);

            }

            conn.Close();
            return lstCus;
            //SqlConnection conn = CreateConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Nhanvien", conn);
            //SqlDataReader reader = cmd.ExecuteReader();

            //List<NhanvienBEL> lstCus = new List<NhanvienBEL>();
            //AreaDAL are = new AreaDAL();
            //while (reader.Read())
            //{
            //    NhanvienBEL cus = new NhanvienBEL();
            //    cus.Id = int.Parse(reader["id"].ToString());
            //    cus.Name = reader["name"].ToString();


            //    var a = reader["id_area"].ToString();

            //    cus.Area = are.ReadArea(int.Parse(reader["id_area"].ToString()));
            //    cus.DienThoai = reader["dienthoai"].ToString();
            //    //THEM
            //    cus.NgaySinh = DateTime.Parse(reader["ngaysinh"].ToString());

            //    //
            //    cus.Anh = reader["anh"].ToString();

            //    //


            //}

            //conn.Close();
            //return lstCus;
        }
        public void EditNhanvien(NhanvienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Nhanvien set name = @name, id_area= @id_area where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));

            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            //thêm
            cmd.Parameters.Add(new SqlParameter("@dienthoai", cus.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", cus.NgaySinh));
            //
            cmd.Parameters.Add(new SqlParameter("@anh", cus.Anh));

            //

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteNhanvien(NhanvienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Nhanvien where  id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewNhanvien(NhanvienBEL cus)
        {
            //SqlConnection conn = CreateConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Nhanvien values (@id,@name,@id_area,@dienthoai,@ngaysinh, @anh)", conn);
            //cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            //cmd.Parameters.Add(new SqlParameter("@name", cus.Name));

            //cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            //cmd.Parameters.Add(new SqlParameter("@dienthoai", cus.DienThoai));
            ////them'
            //cmd.Parameters.Add(new SqlParameter("@ngaysinh", cus.NgaySinh));

            ////
            //cmd.Parameters.Add(new SqlParameter("@anh", cus.Anh));
            ////cmd.Parameters.Add(new SqlParameter("@pictureBox1", cus.Anh));
            //cmd.ExecuteNonQuery();
            //conn.Close();
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Nhanvien values (@id,@name,@id_area,@dienthoai,@ngaysinh, @anh)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));

            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            //thêm
            cmd.Parameters.Add(new SqlParameter("@dienthoai", cus.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", cus.NgaySinh));
            //
            cmd.Parameters.Add(new SqlParameter("@anh", cus.Anh));

            //

            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
