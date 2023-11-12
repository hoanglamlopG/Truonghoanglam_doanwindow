using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Article05.Model;
using Article05.DAL;
using Article05;

namespace BLL
{
    public class TaiKhoanBAL
    {
        TaiKhoanAcess tkAccess = new TaiKhoanAcess();
        public string CheckLogin(TaiKhoan taiKhoan)
        {
            //kiểm tra nghiệp vụ
            if (taiKhoan.sTaiKhoan == "")
            {
                return "requeid_taikhoan";

            }
            if (taiKhoan.sMatKhau == "")
            {
                return "requeid_password";

            }
            string info = tkAccess.CheckLogin(taiKhoan);
            return info;

        }
    }
}
