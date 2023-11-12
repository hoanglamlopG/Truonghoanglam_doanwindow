using Article05.BAL;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Article05.GUI
{
    public partial class SanPhamGUI2 : Form
    {
        SanphamBAL spBAL = new SanphamBAL();
        LoaiBAL LoaiBAL = new LoaiBAL();
        public SanPhamGUI2()
        {
            InitializeComponent();
        }

        private void SanphamGUI2_Load(object sender, EventArgs e)
        {
            List<SanphamBEL> lstsp = spBAL.ReadSanpham();
            foreach (SanphamBEL sp in lstsp)
            {
                dataGridView1.Rows.Add(sp.Id, sp.Gia, sp.TenSP, sp.NgayNhap, sp.LoaiBEL);
            }
            List<LoaiBEL> lstLoai = LoaiBAL.ReadLoaiList();
            foreach (LoaiBEL Loai in lstLoai)
            {
                cbArea.Items.Add(Loai);
            }
            cbArea.DisplayMember = "name";
        }

        

        private void btNew_Click_1(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Thêm thất bại,Nhập mã", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (tbName.Text == "")
            {
                MessageBox.Show("Thêm thất bại,Nhập tên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (tbngaynhap.Text == "")
            {
                MessageBox.Show("Thêm thất bại, Ngày Nhập khong được bỏ trống", "Thông báo", MessageBoxButtons.OK);
            }
            {

                SanphamBEL sp = new SanphamBEL();
                int id;
                if (!int.TryParse(tbId.Text, out id))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == id)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                sp.Id = int.Parse(tbId.Text);
                sp.Gia = float.Parse(tbgia.Text);
                sp.TenSP = tbName.Text;
                sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
                sp.loai = (LoaiBEL)cbArea.SelectedItem;
                spBAL.Newsanpham1(sp);
                dataGridView1.Rows.Add(sp.Id, sp.Gia, sp.TenSP, sp.NgayNhap, sp.loai.Name);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);

            }
            //SanphamBEL sp = new SanphamBEL();
            //sp.Id = int.Parse(tbId.Text);
            //sp.Gia = float.Parse(tbgia.Text);
            //sp.TenSP = tbName.Text;
            //sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
            //sp.loai = (LoaiBEL)cbArea.SelectedItem;
            //spBAL.Newsanpham1(sp);
            //dataGridView1.Rows.Add(sp.Id,sp.Gia,sp.TenSP,sp.NgayNhap, sp.loai.Name);

        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (tbId.Text == "" || tbName.Text == "" || dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (row != null)
                {
                    SanphamBEL sp = new SanphamBEL();
                    int id;
                    if (!int.TryParse(tbId.Text, out id))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    sp.Id = int.Parse(tbId.Text);
                    sp.Gia = float.Parse(tbgia.Text);
                    sp.TenSP = tbName.Text;
                    sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
                    sp.loai = (LoaiBEL)cbArea.SelectedItem;
                    spBAL.EditSanpham1(sp);
                    row.Cells[0].Value = sp.Id;
                    row.Cells[1].Value = sp.Gia;
                    row.Cells[2].Value = sp.TenSP;
                    row.Cells[3].Value = sp.loai;
                }

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            //DataGridViewRow row = dataGridView1.CurrentRow;
            //if (row != null)
            //{
            //    SanphamBEL sp = new SanphamBEL();
            //    sp.Id = int.Parse(tbId.Text);
            //    sp.Gia = float.Parse(tbgia.Text);
            //    sp.TenSP = tbName.Text;
            //    sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
            //    sp.loai = (LoaiBEL)cbArea.SelectedItem;
            //    spBAL.EditSanpham1(sp);
            //    row.Cells[0].Value = sp.Id;
            //    row.Cells[1].Value = sp.Gia;
            //    row.Cells[2].Value = sp.TenSP;
            //    row.Cells[3].Value = sp.loai;
            //}
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            SanphamBEL sp = new SanphamBEL();
            MessageBox.Show("Bạn có chắc muốn xóa");
            sp.Id = int.Parse(tbId.Text);
            sp.TenSP = tbName.Text;

            spBAL.DeleteSanpham1(sp);
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file(.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();

                tbgia.Text = row.Cells[1].Value.ToString();
                tbName.Text = row.Cells[2].Value.ToString();
                tbngaynhap.Text = row.Cells[3].Value.ToString();
                cbArea.Text = row.Cells[4].Value.ToString();

                //




            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;



        }
        private void button2_Click(object sender, EventArgs e)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Export Excel";
                    saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ExportExcel(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file thành công !");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                        }
                    }
                }
        private void xoagiaodien()
        {
            txtMa.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (radid.Checked)
            {
                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã trước khi tìm kiếm.");
                    return; // Dừng thực hiện tìm kiếm khi không có mã được nhập
                }

                if (!int.TryParse(txtMa.Text, out int ma))
                {
                    MessageBox.Show("Mã phải là một số nguyên.");
                    return; // Dừng thực hiện tìm kiếm nếu mã không phải là số
                }

                dataGridView2.Rows.Clear();

                bool found = false; // Biến kiểm tra xem có kết quả tìm thấy hay không

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (ma == Convert.ToInt32(dataGridView1[0, i].Value))
                    {
                        dataGridView2.Rows.Add(dataGridView1[0, i].Value, dataGridView1[1, i].Value, dataGridView1[2, i].Value, dataGridView1[3, i].Value, dataGridView1[4, i].Value);
                        found = true; // Đánh dấu là tìm thấy kết quả
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int newId;
            if (!int.TryParse(tbId.Text, out newId))
            {
                MessageBox.Show("Mã không hợp lệ. Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow existingRow in dataGridView1.Rows)
            {
                if (existingRow != row && existingRow.Cells[0].Value != null && Convert.ToInt32(existingRow.Cells[0].Value) == newId)
                {
                    MessageBox.Show("Mã đã tồn tại trong dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (tbId.Text == "" || tbName.Text == "" ||tbngaynhap.Text==""||tbgia.Text==""|| dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (row != null)
                {
                    SanphamBEL sp = new SanphamBEL();
                    int id;
                    if (!int.TryParse(tbId.Text, out id))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == id)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    sp.Id = int.Parse(tbId.Text);
                    sp.Gia = float.Parse(tbgia.Text);
                    sp.TenSP = tbName.Text;
                    sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
                    sp.loai = (LoaiBEL)cbArea.SelectedItem;
                    spBAL.EditSanpham1(sp);
                    row.Cells[0].Value = sp.Id;
                    row.Cells[1].Value = sp.Gia;
                    row.Cells[2].Value = sp.TenSP;
                    row.Cells[3].Value = sp.NgayNhap;
                    row.Cells[4].Value = sp.LoaiBEL;
                }

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Thêm thất bại,Nhập mã", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (tbName.Text == "")
            {
                MessageBox.Show("Thêm thất bại,Nhập tên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (tbngaynhap.Text == "")
            {
                MessageBox.Show("Thêm thất bại, Ngày Nhập khong được bỏ trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (tbgia.Text == "")
            {
                MessageBox.Show("Thêm thất bại, Giá khong được bỏ trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (cbArea.Text == "")
            {
                MessageBox.Show("Thêm thất bại, Giá khong được bỏ trống", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                SanphamBEL sp = new SanphamBEL();
                int id;
                if (!int.TryParse(tbId.Text, out id))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(tbgia.Text, out id))
                {
                    MessageBox.Show("Giá Phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == id)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                sp.Id = int.Parse(tbId.Text);
                sp.Gia = float.Parse(tbgia.Text);
                sp.TenSP = tbName.Text;
                sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
                sp.loai = (LoaiBEL)cbArea.SelectedItem;
                spBAL.Newsanpham1(sp);
                dataGridView1.Rows.Add(sp.Id, sp.Gia, sp.TenSP, sp.NgayNhap, sp.loai.Name);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);

            }
            //SanphamBEL sp = new SanphamBEL();
            //sp.Id = int.Parse(tbId.Text);
            //sp.Gia = float.Parse(tbgia.Text);
            //sp.TenSP = tbName.Text;
            //sp.NgayNhap = DateTime.Parse(tbngaynhap.Text);
            //sp.loai = (LoaiBEL)cbArea.SelectedItem;
            //spBAL.Newsanpham1(sp);
            //dataGridView1.Rows.Add(sp.Id,sp.Gia,sp.TenSP,sp.NgayNhap, sp.loai.Name);

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SanphamBEL sp = new SanphamBEL();
            MessageBox.Show("Bạn có chắc muốn xóa");
            if (tbId.Text == "" || tbName.Text == "" || tbngaynhap.Text == "" || tbgia.Text == "" || dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Xoá Thành Công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            sp.Id = int.Parse(tbId.Text);
            sp.TenSP = tbName.Text;

            spBAL.DeleteSanpham1(sp);
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file(.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file(.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
