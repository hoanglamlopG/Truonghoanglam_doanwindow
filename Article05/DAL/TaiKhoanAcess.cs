using Article05.DAL;
using Article05;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.DAL
{
    public class TaiKhoanAcess : Database
    {
        public string CheckLogin(TaiKhoan taiKhoan)
        {
            string info = CheckLoginDTO(taiKhoan);
            return info;
        }
    }
}
