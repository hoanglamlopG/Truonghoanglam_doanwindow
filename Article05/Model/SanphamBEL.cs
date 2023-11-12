using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.Model
{
    public class SanphamBEL
    {
        public int Id { get; set; }
        public float Gia { get; set; }
        public string TenSP { get;set; }
        public DateTime NgayNhap { get; set; }
        public LoaiBEL loai { get; set; }
        public string LoaiBEL
        {
            get { return loai.Name; }
        }
    }
}
