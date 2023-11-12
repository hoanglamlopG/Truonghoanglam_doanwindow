using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.Model
{
    public class NhanvienBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AreaBEL Area { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Anh { get; set; }
        public string AreaName
        {
            get { return Area.Name; }
        }
    }
}
