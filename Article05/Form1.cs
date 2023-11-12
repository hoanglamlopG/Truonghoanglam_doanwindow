using Article05.GUI;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article05
{
    public partial class Form1 : Form
    {
        TaiKhoan taikhoan1 = new TaiKhoan();
        TaiKhoanBAL tkBLL = new TaiKhoanBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //taikhoan1.sTaiKhoan = taikhoan.Text;
            //taikhoan1.sMatKhau = matkhau.Text;
            //string getuser = tkBLL.CheckLogin(taikhoan1);

            ////DataTable dt = new DataTable();



            //// trả lại kết quả nếu nghiệp vụ không đúng
            //switch (getuser)
            //{
            //    case "requeid_taikhoan":
            //        MessageBox.Show("Tài khoản không được bỏ trống!");
            //        return;
            //    case "requeid_password":
            //        MessageBox.Show("Mật khẩu không được bỏ trống!");
            //        return;
            //    case "Tài khoản hoặc mật khẩu không chính xác!":
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            //        return;
            //}
            //MessageBox.Show(" Đăng nhập thành công");
            //TrangChu f = new TrangChu();
            
            ////dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString()
            //f.Show();


            string user = "lam";
            string pass = "123";
            if (user.Equals(taikhoan.Text) && pass.Equals(matkhau.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                TrangChu f = new TrangChu();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangKy a = new DangKy();
            a.Show();

        }
    }
}
