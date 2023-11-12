using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article05.GUI
{
    public partial class Banhang : Form
    {
        public Banhang()
        {
            InitializeComponent();
        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sale1DataSet4.banhang2' table. You can move, or remove it, as needed.
            this.banhang2TableAdapter1.Fill(this.sale1DataSet4.banhang2);
            // TODO: This line of code loads data into the 'sale1DataSet3.banhangvd2' table. You can move, or remove it, as needed.
            this.banhang2TableAdapter.Fill(this.sale1DataSet3.banhang2);
            // TODO: This line of code loads data into the 'sale1DataSet1.banhang' table. You can move, or remove it, as needed.
           

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            banhang2BindingSource1.AddNew();
        }

        private void btDelete_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Bạn Muốn Xoá Dòng này","Xoá dữ liệu",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                banhang2BindingSource1.RemoveCurrent();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         int i=    banhang2TableAdapter1.Update(sale1DataSet4.banhang2);
            MessageBox.Show("Hoan Thành Lưu mới" + i + "dòng dữ liệu", "Lưu Mới dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            PictureBox pt = new PictureBox();
            int r = dataGridView1.CurrentCell.RowIndex;
            if (odf.ShowDialog() == DialogResult.OK)
            {
                pt.Image = new Bitmap(odf.FileName);
                MemoryStream mstr = new MemoryStream();
                pt.Image.Save(mstr, pt.Image.RawFormat);
                dataGridView1.Rows[r].Cells[5].Value = mstr.ToArray();


            }
            else dataGridView1.Rows[r].Cells[5].Value = DBNull.Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
