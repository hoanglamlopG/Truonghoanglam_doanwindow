using Article05.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.DAL
{
    public class SanPhamDAL : DBConnection
    {
        public List<SanphamBEL> ReadSanpham()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from sanpham", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanphamBEL> lstCus = new List<SanphamBEL>();
            LoaiDAL are = new LoaiDAL();
            while (reader.Read())
            {
                SanphamBEL sp = new SanphamBEL();
                sp.Id = int.Parse(reader["id"].ToString());
                sp.Gia = sp.Gia = float.Parse(reader["gia"].ToString());
                sp.TenSP = reader["tensp"].ToString();
                sp.NgayNhap = DateTime.Parse(reader["ngaynhap"].ToString());
                var a = reader["id_loai"].ToString();
                sp.loai = are.ReadLoai(int.Parse(reader["id_loai"].ToString()));
                lstCus.Add(sp);
            }
            conn.Close();
            return lstCus;

        }
        public void Editsanpham(SanphamBEL sp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update sanpham set gia=@gia, ngaynhap=@ngaynhap ,tensp = @tensp, id_loai= @id_loai where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", sp.Id));
            cmd.Parameters.Add(new SqlParameter("@gia", sp.Gia));
            cmd.Parameters.Add(new SqlParameter("@tensp", sp.TenSP));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", sp.NgayNhap));

            cmd.Parameters.Add(new SqlParameter("@id_loai", sp.loai.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Deletesanpham(SanphamBEL sp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from sanpham where  id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", sp.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Newsanpham(SanphamBEL sp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sanpham values (@id,@gia,@Tensp,@ngaynhap,@id_loai)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", sp.Id));
            cmd.Parameters.Add(new SqlParameter("@gia", sp.Gia));

            cmd.Parameters.Add(new SqlParameter("@tensp", sp.TenSP));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", sp.NgayNhap));
            cmd.Parameters.Add(new SqlParameter("@id_loai", sp.loai.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
