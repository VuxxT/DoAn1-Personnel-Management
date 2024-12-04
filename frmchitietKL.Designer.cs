namespace DoAn1HTTT0120
{
    partial class frmchitietKL
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
            System.Windows.Forms.Label maHTKLLabel;
            System.Windows.Forms.Label lyDoLabel;
            System.Windows.Forms.Label ngayQuyetDinhLabel;
            System.Windows.Forms.Label maNVLabel;
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.kyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.hinhThucKyLuatTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.HinhThucKyLuatTableAdapter();
            this.hinhThucKyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyLuatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.ngayQuyetDinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbMaHTKL = new System.Windows.Forms.ComboBox();
            this.kyLuatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet1 = new DoAn1HTTT0120.MyDBDataSet();
            this.hinhThucKyLuatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kyLuatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByAllKLToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByAllKLToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.hinhThucKyLuatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyLuatTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.KyLuatTableAdapter();
            maHTKLLabel = new System.Windows.Forms.Label();
            lyDoLabel = new System.Windows.Forms.Label();
            ngayQuyetDinhLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            this.fillByAllKLToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maHTKLLabel
            // 
            maHTKLLabel.AutoSize = true;
            maHTKLLabel.Location = new System.Drawing.Point(18, 39);
            maHTKLLabel.Name = "maHTKLLabel";
            maHTKLLabel.Size = new System.Drawing.Size(138, 16);
            maHTKLLabel.TabIndex = 3;
            maHTKLLabel.Text = "Mã Hình Thức Kỷ Luật:";
            // 
            // lyDoLabel
            // 
            lyDoLabel.AutoSize = true;
            lyDoLabel.Location = new System.Drawing.Point(18, 67);
            lyDoLabel.Name = "lyDoLabel";
            lyDoLabel.Size = new System.Drawing.Size(45, 16);
            lyDoLabel.TabIndex = 5;
            lyDoLabel.Text = "Lý Do:";
            // 
            // ngayQuyetDinhLabel
            // 
            ngayQuyetDinhLabel.AutoSize = true;
            ngayQuyetDinhLabel.Location = new System.Drawing.Point(18, 97);
            ngayQuyetDinhLabel.Name = "ngayQuyetDinhLabel";
            ngayQuyetDinhLabel.Size = new System.Drawing.Size(113, 16);
            ngayQuyetDinhLabel.TabIndex = 7;
            ngayQuyetDinhLabel.Text = "Ngày Quyết  Định:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(18, 130);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(77, 16);
            maNVLabel.TabIndex = 9;
            maNVLabel.Text = "Họ Tên NV:";
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyLuatBindingSource
            // 
            this.kyLuatBindingSource.DataMember = "KyLuat";
            this.kyLuatBindingSource.DataSource = this.myDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = null;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = this.hinhThucKyLuatTableAdapter;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KyLuatTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hinhThucKyLuatTableAdapter
            // 
            this.hinhThucKyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // hinhThucKyLuatBindingSource
            // 
            this.hinhThucKyLuatBindingSource.DataMember = "HinhThucKyLuat";
            this.hinhThucKyLuatBindingSource.DataSource = this.myDBDataSet;
            // 
            // kyLuatBindingSource1
            // 
            this.kyLuatBindingSource1.DataMember = "FK_KyLuat_ToHinhThucKyLuat";
            this.kyLuatBindingSource1.DataSource = this.hinhThucKyLuatBindingSource;
            // 
            // txtLyDo
            // 
            this.txtLyDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyLuatBindingSource1, "LyDo", true));
            this.txtLyDo.Location = new System.Drawing.Point(178, 61);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(212, 22);
            this.txtLyDo.TabIndex = 6;
            // 
            // ngayQuyetDinhDateTimePicker
            // 
            this.ngayQuyetDinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kyLuatBindingSource1, "NgayQuyetDinh", true));
            this.ngayQuyetDinhDateTimePicker.Location = new System.Drawing.Point(177, 91);
            this.ngayQuyetDinhDateTimePicker.Name = "ngayQuyetDinhDateTimePicker";
            this.ngayQuyetDinhDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.ngayQuyetDinhDateTimePicker.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbMaHTKL);
            this.groupBox1.Controls.Add(this.cbbHoTenNV);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(maHTKLLabel);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(maNVLabel);
            this.groupBox1.Controls.Add(ngayQuyetDinhLabel);
            this.groupBox1.Controls.Add(lyDoLabel);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.ngayQuyetDinhDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(318, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 227);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Hình Thức Kỷ Luật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbMaHTKL
            // 
            this.cbbMaHTKL.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kyLuatBindingSource2, "MaHTKL", true));
            this.cbbMaHTKL.DataSource = this.hinhThucKyLuatBindingSource1;
            this.cbbMaHTKL.DisplayMember = "TenHTKL";
            this.cbbMaHTKL.FormattingEnabled = true;
            this.cbbMaHTKL.Location = new System.Drawing.Point(180, 31);
            this.cbbMaHTKL.Name = "cbbMaHTKL";
            this.cbbMaHTKL.Size = new System.Drawing.Size(210, 24);
            this.cbbMaHTKL.TabIndex = 16;
            this.cbbMaHTKL.ValueMember = "MaHTKL";
            // 
            // kyLuatBindingSource2
            // 
            this.kyLuatBindingSource2.DataMember = "KyLuat";
            this.kyLuatBindingSource2.DataSource = this.myDBDataSet1;
            // 
            // myDBDataSet1
            // 
            this.myDBDataSet1.DataSetName = "MyDBDataSet";
            this.myDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hinhThucKyLuatBindingSource1
            // 
            this.hinhThucKyLuatBindingSource1.DataMember = "HinhThucKyLuat";
            this.hinhThucKyLuatBindingSource1.DataSource = this.myDBDataSet1;
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kyLuatBindingSource1, "MaNV", true));
            this.cbbHoTenNV.DataSource = this.nhanVienBindingSource;
            this.cbbHoTenNV.DisplayMember = "HoTenNV";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(177, 122);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(213, 24);
            this.cbbHoTenNV.TabIndex = 15;
            this.cbbHoTenNV.ValueMember = "MaNV";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.myDBDataSet;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(315, 164);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(207, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(604, 266);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 15;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kyLuatDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 281);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Kỷ Luật";
            // 
            // kyLuatDataGridView
            // 
            this.kyLuatDataGridView.AutoGenerateColumns = false;
            this.kyLuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kyLuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.kyLuatDataGridView.DataSource = this.kyLuatBindingSource1;
            this.kyLuatDataGridView.Location = new System.Drawing.Point(6, 21);
            this.kyLuatDataGridView.Name = "kyLuatDataGridView";
            this.kyLuatDataGridView.RowHeadersWidth = 51;
            this.kyLuatDataGridView.RowTemplate.Height = 24;
            this.kyLuatDataGridView.Size = new System.Drawing.Size(552, 220);
            this.kyLuatDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHTKL";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHTKL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LyDo";
            this.dataGridViewTextBoxColumn2.HeaderText = "LyDo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn7.HeaderText = "MaNV";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.myDBDataSet;
            // 
            // nhanVienBindingSource2
            // 
            this.nhanVienBindingSource2.DataMember = "NhanVien";
            this.nhanVienBindingSource2.DataSource = this.myDBDataSet;
            // 
            // fillByAllKLToolStrip1
            // 
            this.fillByAllKLToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllKLToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllKLToolStripButton1});
            this.fillByAllKLToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByAllKLToolStrip1.Name = "fillByAllKLToolStrip1";
            this.fillByAllKLToolStrip1.Size = new System.Drawing.Size(735, 27);
            this.fillByAllKLToolStrip1.TabIndex = 18;
            this.fillByAllKLToolStrip1.Text = "Reload";
            // 
            // fillByAllKLToolStripButton1
            // 
            this.fillByAllKLToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllKLToolStripButton1.Name = "fillByAllKLToolStripButton1";
            this.fillByAllKLToolStripButton1.Size = new System.Drawing.Size(60, 24);
            this.fillByAllKLToolStripButton1.Text = "Reload";
            this.fillByAllKLToolStripButton1.Click += new System.EventHandler(this.fillByAllKLToolStripButton1_Click_1);
            // 
            // hinhThucKyLuatDataGridView
            // 
            this.hinhThucKyLuatDataGridView.AutoGenerateColumns = false;
            this.hinhThucKyLuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hinhThucKyLuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hinhThucKyLuatDataGridView.DataSource = this.hinhThucKyLuatBindingSource;
            this.hinhThucKyLuatDataGridView.Location = new System.Drawing.Point(12, 30);
            this.hinhThucKyLuatDataGridView.Name = "hinhThucKyLuatDataGridView";
            this.hinhThucKyLuatDataGridView.RowHeadersWidth = 51;
            this.hinhThucKyLuatDataGridView.RowTemplate.Height = 24;
            this.hinhThucKyLuatDataGridView.Size = new System.Drawing.Size(300, 220);
            this.hinhThucKyLuatDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaHTKL";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaHTKL";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenHTKL";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenHTKL";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // kyLuatTableAdapter
            // 
            this.kyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // frmchitietKL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 526);
            this.Controls.Add(this.hinhThucKyLuatDataGridView);
            this.Controls.Add(this.fillByAllKLToolStrip1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmchitietKL";
            this.Text = "Quản Lý Kỷ Luật";
            this.Load += new System.EventHandler(this.chitietKL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            this.fillByAllKLToolStrip1.ResumeLayout(false);
            this.fillByAllKLToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource kyLuatBindingSource;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MyDBDataSetTableAdapters.HinhThucKyLuatTableAdapter hinhThucKyLuatTableAdapter;
        private System.Windows.Forms.BindingSource hinhThucKyLuatBindingSource;
        private System.Windows.Forms.BindingSource kyLuatBindingSource1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.DateTimePicker ngayQuyetDinhDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private System.Windows.Forms.ToolStrip fillByAllKLToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByAllKLToolStripButton1;
        private System.Windows.Forms.ComboBox cbbMaHTKL;
        private System.Windows.Forms.DataGridView kyLuatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView hinhThucKyLuatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MyDBDataSetTableAdapters.KyLuatTableAdapter kyLuatTableAdapter;
        private MyDBDataSet myDBDataSet1;
        private System.Windows.Forms.BindingSource hinhThucKyLuatBindingSource1;
        private System.Windows.Forms.BindingSource kyLuatBindingSource2;
        private System.Windows.Forms.Button button1;
    }
}