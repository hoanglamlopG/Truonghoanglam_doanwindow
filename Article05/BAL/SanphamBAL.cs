using Article05.DAL;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.BAL
{
    public class SanphamBAL
    {
        SanPhamDAL sph= new SanPhamDAL();
        public List<SanphamBEL> ReadSanpham()
        {
            List<SanphamBEL> lstCus = sph.ReadSanpham();
            return lstCus;

        }
        public void Newsanpham1(SanphamBEL cus)
        {
            sph.Newsanpham(cus);
        }
        public void DeleteSanpham1(SanphamBEL cus)
        {
            sph.Deletesanpham(cus);
        }
        public void EditSanpham1(SanphamBEL cus)
        {
            sph.Editsanpham(cus);
        }

        internal void DeleteCustomer(SanphamBEL sp)
        {
            throw new NotImplementedException();
        }
    }
}
