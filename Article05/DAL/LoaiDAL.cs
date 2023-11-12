using Article05.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.DAL
{
    public class LoaiDAL : DBConnection
    {
        public List<LoaiBEL> ReadLoaiList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Loai", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<LoaiBEL> lstLoai = new List<LoaiBEL>();
            while (reader.Read())
            {
                LoaiBEL sph = new LoaiBEL();
                sph.Id = int.Parse(reader["id"].ToString());
                sph.Name = reader["name"].ToString();
                lstLoai.Add(sph);
            }
            conn.Close();
            return lstLoai;
        }
        public LoaiBEL ReadLoai(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from loai where id =" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            LoaiBEL area = new LoaiBEL();
            if (reader.HasRows && reader.Read())
            {
                area.Id = int.Parse(reader["id"].ToString());
                area.Name = reader["name"].ToString();
            }
            conn.Close();
            return area;
        }
    }
}
