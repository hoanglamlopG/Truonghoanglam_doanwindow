using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.Model
{
    public class LoaiBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }
       

        public List<SanphamBEL> sanpham1 { get; set; }
    }
}
