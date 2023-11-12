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

namespace Article05.GUI
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        AreaBAL areaBAL = new AreaBAL();
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
            List<AreaBEL> lstArea = areaBAL.ReadAreaList();
            foreach (AreaBEL area in lstArea)
            {
                cbArea.Items.Add(area);
            }
            cbArea.DisplayMember = "name";
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
            {

                CustomerBEL cus = new CustomerBEL();
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

                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBAL.NewCustomer(cus);
                dataGridView1.Rows.Add(cus.Id, cus.Name, cus.Area.Name);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);

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
            if (tbId.Text == "" || tbName.Text == "" || dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (row != null)
                {
                    CustomerBEL cus = new CustomerBEL();
                    int id;
                    if (!int.TryParse(tbId.Text, out id))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.Mã phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    cus.Id = int.Parse(tbId.Text);
                    cus.Name = tbName.Text;
                    cus.Area = (AreaBEL)cbArea.SelectedItem;
                    cusBAL.EditCustomer(cus);
                    row.Cells[0].Value = cus.Id;
                    row.Cells[1].Value = cus.Name;
                    row.Cells[2].Value = cus.AreaName;
                }

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            //if (row != null)
            //{
            //    CustomerBEL cus = new CustomerBEL();
            //    cus.Id = int.Parse(tbId.Text);
            //    cus.Name = tbName.Text;
            //    cus.Area = (AreaBEL)cbArea.SelectedItem;
            //    cusBAL.EditCustomer(cus);
            //    row.Cells[0].Value = cus.Id;
            //    row.Cells[1].Value = cus.Name;
            //    row.Cells[2].Value = cus.AreaName;
            //}
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
         CustomerBEL cus=new CustomerBEL();
            MessageBox.Show("Bạn có chắc muốn xóa");
            cus.Id=int.Parse(tbId.Text);
            cus.Name=tbName.Text;
            cusBAL.DeleteCustomer(cus);
            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file(.png,.jpg)|*.png;*.jpg";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.ReadOnly = true;
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
