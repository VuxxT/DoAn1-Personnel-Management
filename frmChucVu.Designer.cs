namespace DoAn1HTTT0120
{
    partial class frmChucVu
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
            System.Windows.Forms.Label maChucVuLabel;
            System.Windows.Forms.Label tenChucVuLabel;
            System.Windows.Forms.Label maNVLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chucVuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.ChucVuTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillByAllNV5ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByAllNV5ToolStripButton = new System.Windows.Forms.ToolStripButton();
            maChucVuLabel = new System.Windows.Forms.Label();
            tenChucVuLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fillByAllNV5ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // maChucVuLabel
            // 
            maChucVuLabel.AutoSize = true;
            maChucVuLabel.Location = new System.Drawing.Point(8, 16);
            maChucVuLabel.Name = "maChucVuLabel";
            maChucVuLabel.Size = new System.Drawing.Size(81, 16);
            maChucVuLabel.TabIndex = 0;
            maChucVuLabel.Text = "Mã Chức Vụ:";
            // 
            // tenChucVuLabel
            // 
            tenChucVuLabel.AutoSize = true;
            tenChucVuLabel.Location = new System.Drawing.Point(8, 44);
            tenChucVuLabel.Name = "tenChucVuLabel";
            tenChucVuLabel.Size = new System.Drawing.Size(86, 16);
            tenChucVuLabel.TabIndex = 2;
            tenChucVuLabel.Text = "Tên Chức Vụ:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(8, 72);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(56, 16);
            maNVLabel.TabIndex = 4;
            maNVLabel.Text = "Tên NV:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.cbbNV);
            this.panel1.Controls.Add(this.btnTroLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(maChucVuLabel);
            this.panel1.Controls.Add(this.txtMaCV);
            this.panel1.Controls.Add(tenChucVuLabel);
            this.panel1.Controls.Add(this.txtTenCV);
            this.panel1.Controls.Add(maNVLabel);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 211);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.Location = new System.Drawing.Point(210, 118);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(83, 23);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbNV
            // 
            this.cbbNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chucVuBindingSource, "MaNV", true));
            this.cbbNV.DataSource = this.nhanVienBindingSource1;
            this.cbbNV.DisplayMember = "HoTenNV";
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(100, 72);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(193, 24);
            this.cbbNV.TabIndex = 10;
            this.cbbNV.ValueMember = "MaNV";
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.myDBDataSet;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(218, 178);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 9;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(144, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(76, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(11, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaCV
            // 
            this.txtMaCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chucVuBindingSource, "MaChucVu", true));
            this.txtMaCV.Location = new System.Drawing.Point(100, 13);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(193, 22);
            this.txtMaCV.TabIndex = 1;
            // 
            // txtTenCV
            // 
            this.txtTenCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chucVuBindingSource, "TenChucVu", true));
            this.txtTenCV.Location = new System.Drawing.Point(100, 41);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(193, 22);
            this.txtTenCV.TabIndex = 3;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.myDBDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chucVuDataGridView);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 211);
            this.panel2.TabIndex = 1;
            // 
            // chucVuDataGridView
            // 
            this.chucVuDataGridView.AutoGenerateColumns = false;
            this.chucVuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chucVuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaNV,
            this.dataGridViewTextBoxColumn2});
            this.chucVuDataGridView.DataSource = this.chucVuBindingSource;
            this.chucVuDataGridView.Location = new System.Drawing.Point(3, 3);
            this.chucVuDataGridView.Name = "chucVuDataGridView";
            this.chucVuDataGridView.RowHeadersWidth = 51;
            this.chucVuDataGridView.RowTemplate.Height = 24;
            this.chucVuDataGridView.Size = new System.Drawing.Size(310, 198);
            this.chucVuDataGridView.TabIndex = 0;
            this.chucVuDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chucVuDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaChucVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaChucVu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "HoTenNV";
            this.MaNV.HeaderText = "Tên NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenChucVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenChucVu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = this.chucVuTableAdapter;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = null;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KyLuatTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(327, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chức vụ nhân viên";
            // 
            // fillByAllNV5ToolStrip
            // 
            this.fillByAllNV5ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAllNV5ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllNV5ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllNV5ToolStripButton});
            this.fillByAllNV5ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByAllNV5ToolStrip.Name = "fillByAllNV5ToolStrip";
            this.fillByAllNV5ToolStrip.Size = new System.Drawing.Size(73, 27);
            this.fillByAllNV5ToolStrip.TabIndex = 4;
            this.fillByAllNV5ToolStrip.Text = "fillByAllNV5ToolStrip";
            // 
            // fillByAllNV5ToolStripButton
            // 
            this.fillByAllNV5ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllNV5ToolStripButton.Name = "fillByAllNV5ToolStripButton";
            this.fillByAllNV5ToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByAllNV5ToolStripButton.Text = "Reload";
            this.fillByAllNV5ToolStripButton.Click += new System.EventHandler(this.fillByAllNV5ToolStripButton_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 282);
            this.Controls.Add(this.fillByAllNV5ToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChucVu";
            this.Text = "Chức  Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chucVuDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.fillByAllNV5ToolStrip.ResumeLayout(false);
            this.fillByAllNV5ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private MyDBDataSetTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView chucVuDataGridView;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStrip fillByAllNV5ToolStrip;
        private System.Windows.Forms.ToolStripButton fillByAllNV5ToolStripButton;
        private System.Windows.Forms.Button btnLamMoi;
    }
}