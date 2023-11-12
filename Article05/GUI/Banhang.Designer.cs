namespace Article05.GUI
{
    partial class Banhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banhang));
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sale1DataSet1 = new Article05.sale1DataSet1();
            this.banhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banhangTableAdapter = new Article05.sale1DataSet1TableAdapters.banhangTableAdapter();
            this.sale1DataSet2 = new Article05.sale1DataSet2();
            this.sale1DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale1DataSet3 = new Article05.sale1DataSet3();
            this.banhang2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banhang2TableAdapter = new Article05.sale1DataSet3TableAdapters.banhang2TableAdapter();
            this.sale1DataSet4 = new Article05.sale1DataSet4();
            this.banhang2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banhang2TableAdapter1 = new Article05.sale1DataSet4TableAdapters.banhang2TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhang2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhang2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoá Đơn Bán Hàng";
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(112, 219);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(228, 21);
            this.cbArea.TabIndex = 22;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(622, 571);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 38);
            this.btExit.TabIndex = 21;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Cyan;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(469, 571);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(104, 38);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Them Ảnh";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(293, 571);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 38);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNew
            // 
            this.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(112, 571);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(92, 38);
            this.btNew.TabIndex = 18;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Khu vực";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(112, 114);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(228, 20);
            this.tbId.TabIndex = 15;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 163);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 20);
            this.tbName.TabIndex = 16;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giá";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chiết Khấu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số lượng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(436, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 28;
            // 
            // sale1DataSet1
            // 
            this.sale1DataSet1.DataSetName = "sale1DataSet1";
            this.sale1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banhangBindingSource
            // 
            this.banhangBindingSource.DataMember = "banhang";
            this.banhangBindingSource.DataSource = this.sale1DataSet1;
            // 
            // banhangTableAdapter
            // 
            this.banhangTableAdapter.ClearBeforeFill = true;
            // 
            // sale1DataSet2
            // 
            this.sale1DataSet2.DataSetName = "sale1DataSet2";
            this.sale1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sale1DataSet2BindingSource
            // 
            this.sale1DataSet2BindingSource.DataSource = this.sale1DataSet2;
            this.sale1DataSet2BindingSource.Position = 0;
            // 
            // sale1DataSet3
            // 
            this.sale1DataSet3.DataSetName = "sale1DataSet3";
            this.sale1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banhang2BindingSource
            // 
            this.banhang2BindingSource.DataMember = "banhang2";
            this.banhang2BindingSource.DataSource = this.sale1DataSet3;
            // 
            // banhang2TableAdapter
            // 
            this.banhang2TableAdapter.ClearBeforeFill = true;
            // 
            // sale1DataSet4
            // 
            this.sale1DataSet4.DataSetName = "sale1DataSet4";
            this.sale1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banhang2BindingSource1
            // 
            this.banhang2BindingSource1.DataMember = "banhang2";
            this.banhang2BindingSource1.DataSource = this.sale1DataSet4;
            // 
            // banhang2TableAdapter1
            // 
            this.banhang2TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.chietkhauDataGridViewTextBoxColumn,
            this.hinhanhDataGridViewImageColumn,
            this.tongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.banhang2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(50, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 280);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // chietkhauDataGridViewTextBoxColumn
            // 
            this.chietkhauDataGridViewTextBoxColumn.DataPropertyName = "chietkhau";
            this.chietkhauDataGridViewTextBoxColumn.HeaderText = "chietkhau";
            this.chietkhauDataGridViewTextBoxColumn.Name = "chietkhauDataGridViewTextBoxColumn";
            // 
            // hinhanhDataGridViewImageColumn
            // 
            this.hinhanhDataGridViewImageColumn.DataPropertyName = "hinhanh";
            this.hinhanhDataGridViewImageColumn.HeaderText = "hinhanh";
            this.hinhanhDataGridViewImageColumn.Name = "hinhanhDataGridViewImageColumn";
            // 
            // tongDataGridViewTextBoxColumn
            // 
            this.tongDataGridViewTextBoxColumn.DataPropertyName = "Tong";
            this.tongDataGridViewTextBoxColumn.HeaderText = "Tong";
            this.tongDataGridViewTextBoxColumn.Name = "tongDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(758, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Banhang";
            this.Text = "Banhang";
            this.Load += new System.EventHandler(this.Banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhang2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banhang2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private sale1DataSet1 sale1DataSet1;
        private System.Windows.Forms.BindingSource banhangBindingSource;
        private sale1DataSet1TableAdapters.banhangTableAdapter banhangTableAdapter;
        private System.Windows.Forms.BindingSource sale1DataSet2BindingSource;
        private sale1DataSet2 sale1DataSet2;
        private sale1DataSet3 sale1DataSet3;
        private System.Windows.Forms.BindingSource banhang2BindingSource;
        private sale1DataSet3TableAdapters.banhang2TableAdapter banhang2TableAdapter;
        private sale1DataSet4 sale1DataSet4;
        private System.Windows.Forms.BindingSource banhang2BindingSource1;
        private sale1DataSet4TableAdapters.banhang2TableAdapter banhang2TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhanhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}