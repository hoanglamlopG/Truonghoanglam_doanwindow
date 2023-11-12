using Article05.BAL;
using Article05.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace Article05.GUI
{
    public partial class Nhanvien : Form
    {
        NhanvienBAL cusBAL = new NhanvienBAL();
        AreaBAL areaBAL = new AreaBAL();
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            List<NhanvienBEL> lstCus = cusBAL.ReadNhanvien();

            foreach (NhanvienBEL cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.Id, cus.Name, cus.AreaName, cus.DienThoai, cus.NgaySinh, cus.Anh);
            }
            {
                List<AreaBEL> lstArea = areaBAL.ReadAreaList();
                foreach (AreaBEL area in lstArea)
                {
                    cbArea.Items.Add(area);
                }
                cbArea.DisplayMember = "name";
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
                tbsdt.Text = row.Cells[3].Value.ToString();
                //txtImagePath.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();

                //
                pictureBox1.Text = row.Cells[5].Value.ToString();



            }
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(pictureBox1.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void btNew_Click(object sender, EventArgs e)
        {


            NhanvienBEL cus = new NhanvienBEL();
            int id;
            if (!int.TryParse(tbId.Text, out id))
            {
                MessageBox.Show("Mã  không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbsdt.Text, out id))
            {
                MessageBox.Show("số điện  không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    MessageBox.Show("Mã  đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (cus != null)
            {
                if (tbId.Text == "")
                {
                    MessageBox.Show("Thông tin Mã không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                }
                else

                if (tbName.Text == "")
                {
                    MessageBox.Show("Thông tin tên không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    if (cbArea.Text == "")
                {
                    MessageBox.Show("Thông tin  không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                if (tbsdt.Text == "")
                {
                    MessageBox.Show("Thông tin Số điện thoại không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                if (dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Thông tin ngày sinh  không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                if (pictureBox1.Text == "")
                {
                    MessageBox.Show("Ảnh không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    cus.Id = int.Parse(tbId.Text);

                    cus.Name = tbName.Text;
                    cus.Area = (AreaBEL)cbArea.SelectedItem;
                    cus.DienThoai = tbsdt.Text;
                    cus.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
                    //
                    cus.Anh = pictureBox1.Text;
                    //cus.Anh = txtImagePath.Text;
                    cusBAL.NewCustomer(cus);
                    dataGridView1.Rows.Add(cus.Id, cus.Name, cus.Area.Name, cus.DienThoai, cus.NgaySinh, cus.Anh);
                    MessageBox.Show("Nhân Viên đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void btBows_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Text = openFileDialog1.FileName;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Kiểm tra nếu các ô cột có giá trị (không rỗng) trong hàng được chọn
                if (!string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value?.ToString()) &&
                    !string.IsNullOrWhiteSpace(selectedRow.Cells[1].Value?.ToString()) &&
                    !string.IsNullOrWhiteSpace(selectedRow.Cells[2].Value?.ToString()))
                {
                    int idx = selectedRow.Index;

                    NhanvienBEL cus = new NhanvienBEL();
                    cus.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
                    cus.Name = selectedRow.Cells[1].Value.ToString();
                    cus.Area = (AreaBEL)cbArea.SelectedItem;
                    cus.DienThoai = selectedRow.Cells[2].Value.ToString();

                    string dateString = "Mon 16 Jun 8:30 AM 2008"; // Modified from MSDN
                    string format = "ddd dd MMM h:mm tt yyyy";
                    cus.NgaySinh = DateTime.ParseExact(dateString, format,
                    CultureInfo.InvariantCulture);

                    cus.Anh = selectedRow.Cells[3].Value.ToString();
                    cusBAL.DeleteCustomer(cus);
                    dataGridView1.Rows.RemoveAt(idx);

                    MessageBox.Show("Nhân Viên đã được xoá khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xoá hàng chưa có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!int.TryParse(tbsdt.Text, out newId))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tbId.Text == "" || tbName.Text == "" ||tbsdt.Text==""|| txtImagePath.Text==""||cbArea.Text==""|| dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại,Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else

            if (row != null)
            {
                NhanvienBEL cus = new NhanvienBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cus.DienThoai = tbsdt.Text;
                cus.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
                cus.Anh = pictureBox1.Text;
                //cus.Anh=txtImagePath.Text;
                cusBAL.EditCustomer(cus);
                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;

                row.Cells[3].Value = cus.DienThoai;
                row.Cells[4].Value = cus.NgaySinh;
                row.Cells[5].Value = cus.Anh;
                //row.Cells[5].Value = cus.Anh;
                MessageBox.Show("Nhân Viên đã được sửa và cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể sửa hàng chưa có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
                tbsdt.Text = row.Cells[3].Value.ToString();
                //txtImagePath.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();

                //
                txtImagePath.Text = row.Cells[5].Value.ToString();



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.ReadOnly = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
