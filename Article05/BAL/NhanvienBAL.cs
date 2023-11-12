using Article05.DAL;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.BAL
{
    public class NhanvienBAL
    {
        NhanvienDAL dal = new NhanvienDAL();
        public List<NhanvienBEL> ReadNhanvien()
        {
            List<NhanvienBEL> lstCus = dal.ReadNhanvien();
            return lstCus;

        }
        public void NewCustomer(NhanvienBEL cus)
        {
            dal.NewNhanvien(cus);
        }
        public void DeleteCustomer(NhanvienBEL cus)
        {
            dal.DeleteNhanvien(cus);
        }
        public void EditCustomer(NhanvienBEL cus)
        {
            dal.EditNhanvien(cus);
        }
        //

    }
}
