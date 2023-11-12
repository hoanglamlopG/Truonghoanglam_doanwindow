using Article05.GUI;
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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

       

        

        

        

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            CustomerGUI a = new CustomerGUI();
            a.Show();
            
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            SanPhamGUI2 a = new SanPhamGUI2();
            a.Show();
            
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien a = new Nhanvien();
            a.Show();
            
        }

        private void mn_hethong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void mn_quanly_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mn_banhang_Click(object sender, EventArgs e)
        {
            Banhang a = new Banhang();
            a.Show();
        }
    }
}
