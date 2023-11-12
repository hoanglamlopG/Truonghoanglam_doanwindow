using Article05.DAL;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.BAL
{
    public class LoaiBAL
    {
        LoaiDAL dal = new LoaiDAL();
        public List<LoaiBEL> ReadLoaiList()
        {
            List<LoaiBEL> lstLoai = dal.ReadLoaiList();
            return lstLoai;
        }
    }
}
