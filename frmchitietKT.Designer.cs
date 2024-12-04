namespace DoAn1HTTT0120
{
    partial class frmchitietKT
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
            System.Windows.Forms.Label maHTKTLabel;
            System.Windows.Forms.Label lyDoLabel;
            System.Windows.Forms.Label ngayQuyetDinhLabel;
            System.Windows.Forms.Label maNVLabel;
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.khenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khenThuongTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.KhenThuongTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.hinhThucKhenThuongTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter();
            this.hinhThucKhenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hinhThucKhenThuongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khenThuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khenThuongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHTKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDBDataSet1 = new DoAn1HTTT0120.MyDBDataSet1();
            this.kyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyLuatTableAdapter = new DoAn1HTTT0120.MyDBDataSet1TableAdapters.KyLuatTableAdapter();
            this.tableAdapterManager1 = new DoAn1HTTT0120.MyDBDataSet1TableAdapters.TableAdapterManager();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.ngayQuyetDinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHTKT = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTenHTKT = new System.Windows.Forms.ComboBox();
            this.khenThuongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hinhThucKhenThuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.fillByAllKTToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByAllKTToolStripButton = new System.Windows.Forms.ToolStripButton();
            maHTKTLabel = new System.Windows.Forms.Label();
            lyDoLabel = new System.Windows.Forms.Label();
            ngayQuyetDinhLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.fillByAllKTToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // maHTKTLabel
            // 
            maHTKTLabel.AutoSize = true;
            maHTKTLabel.Location = new System.Drawing.Point(329, 46);
            maHTKTLabel.Name = "maHTKTLabel";
            maHTKTLabel.Size = new System.Drawing.Size(73, 16);
            maHTKTLabel.TabIndex = 13;
            maHTKTLabel.Text = "Tên HTKT:";
            // 
            // lyDoLabel
            // 
            lyDoLabel.AutoSize = true;
            lyDoLabel.Location = new System.Drawing.Point(329, 74);
            lyDoLabel.Name = "lyDoLabel";
            lyDoLabel.Size = new System.Drawing.Size(45, 16);
            lyDoLabel.TabIndex = 15;
            lyDoLabel.Text = "Lý Do:";
            // 
            // ngayQuyetDinhLabel
            // 
            ngayQuyetDinhLabel.AutoSize = true;
            ngayQuyetDinhLabel.Location = new System.Drawing.Point(329, 103);
            ngayQuyetDinhLabel.Name = "ngayQuyetDinhLabel";
            ngayQuyetDinhLabel.Size = new System.Drawing.Size(110, 16);
            ngayQuyetDinhLabel.TabIndex = 17;
            ngayQuyetDinhLabel.Text = "Ngày Quyết Định:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(11, 104);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(77, 16);
            maNVLabel.TabIndex = 19;
            maNVLabel.Text = "Họ Tên NV:";
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khenThuongBindingSource
            // 
            this.khenThuongBindingSource.DataMember = "KhenThuong";
            this.khenThuongBindingSource.DataSource = this.myDBDataSet;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = this.hinhThucKhenThuongTableAdapter;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = this.khenThuongTableAdapter;
            this.tableAdapterManager.KyLuatTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hinhThucKhenThuongTableAdapter
            // 
            this.hinhThucKhenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // hinhThucKhenThuongBindingSource
            // 
            this.hinhThucKhenThuongBindingSource.DataMember = "HinhThucKhenThuong";
            this.hinhThucKhenThuongBindingSource.DataSource = this.myDBDataSet;
            // 
            // hinhThucKhenThuongDataGridView
            // 
            this.hinhThucKhenThuongDataGridView.AutoGenerateColumns = false;
            this.hinhThucKhenThuongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hinhThucKhenThuongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hinhThucKhenThuongDataGridView.DataSource = this.hinhThucKhenThuongBindingSource;
            this.hinhThucKhenThuongDataGridView.Location = new System.Drawing.Point(13, 38);
            this.hinhThucKhenThuongDataGridView.Name = "hinhThucKhenThuongDataGridView";
            this.hinhThucKhenThuongDataGridView.RowHeadersWidth = 51;
            this.hinhThucKhenThuongDataGridView.RowTemplate.Height = 24;
            this.hinhThucKhenThuongDataGridView.Size = new System.Drawing.Size(299, 220);
            this.hinhThucKhenThuongDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaHTKT";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaHTKT";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenHTKT";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenHTKT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // khenThuongBindingSource1
            // 
            this.khenThuongBindingSource1.DataMember = "FK_KhenThuong_ToHinhThucKhenThuong";
            this.khenThuongBindingSource1.DataSource = this.hinhThucKhenThuongBindingSource;
            // 
            // khenThuongDataGridView
            // 
            this.khenThuongDataGridView.AutoGenerateColumns = false;
            this.khenThuongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khenThuongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.MaHTKT,
            this.MaNV,
            this.dataGridViewTextBoxColumn3});
            this.khenThuongDataGridView.DataSource = this.khenThuongBindingSource1;
            this.khenThuongDataGridView.Location = new System.Drawing.Point(12, 272);
            this.khenThuongDataGridView.Name = "khenThuongDataGridView";
            this.khenThuongDataGridView.RowHeadersWidth = 51;
            this.khenThuongDataGridView.RowTemplate.Height = 24;
            this.khenThuongDataGridView.Size = new System.Drawing.Size(546, 220);
            this.khenThuongDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LyDo";
            this.dataGridViewTextBoxColumn2.HeaderText = "LyDo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // MaHTKT
            // 
            this.MaHTKT.DataPropertyName = "TenHTKT";
            this.MaHTKT.HeaderText = "TenHTKT";
            this.MaHTKT.MinimumWidth = 6;
            this.MaHTKT.Name = "MaHTKT";
            this.MaHTKT.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "HoTenNV";
            this.MaNV.HeaderText = "HoTenNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // myDBDataSet1
            // 
            this.myDBDataSet1.DataSetName = "MyDBDataSet1";
            this.myDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyLuatBindingSource
            // 
            this.kyLuatBindingSource.DataMember = "KyLuat";
            this.kyLuatBindingSource.DataSource = this.myDBDataSet1;
            // 
            // kyLuatTableAdapter
            // 
            this.kyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChucVuTableAdapter = null;
            this.tableAdapterManager1.HinhThucKhenThuongTableAdapter = null;
            this.tableAdapterManager1.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager1.KhenThuongTableAdapter = null;
            this.tableAdapterManager1.KyLuatTableAdapter = this.kyLuatTableAdapter;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhongBanTableAdapter = null;
            this.tableAdapterManager1.TaiKhoanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DoAn1HTTT0120.MyDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(552, 26);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 11;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTroLai);
            this.panel2.Location = new System.Drawing.Point(12, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 243);
            this.panel2.TabIndex = 13;
            // 
            // txtLyDo
            // 
            this.txtLyDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khenThuongBindingSource1, "LyDo", true));
            this.txtLyDo.Location = new System.Drawing.Point(443, 71);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(207, 22);
            this.txtLyDo.TabIndex = 16;
            // 
            // ngayQuyetDinhDateTimePicker
            // 
            this.ngayQuyetDinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khenThuongBindingSource1, "NgayQuyetDinh", true));
            this.ngayQuyetDinhDateTimePicker.Location = new System.Drawing.Point(443, 99);
            this.ngayQuyetDinhDateTimePicker.Name = "ngayQuyetDinhDateTimePicker";
            this.ngayQuyetDinhDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.ngayQuyetDinhDateTimePicker.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHTKT);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cbbTenHTKT);
            this.panel1.Controls.Add(maNVLabel);
            this.panel1.Controls.Add(this.cbbHoTenNV);
            this.panel1.Location = new System.Drawing.Point(318, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 220);
            this.panel1.TabIndex = 21;
            // 
            // btnHTKT
            // 
            this.btnHTKT.Location = new System.Drawing.Point(14, 187);
            this.btnHTKT.Name = "btnHTKT";
            this.btnHTKT.Size = new System.Drawing.Size(226, 23);
            this.btnHTKT.TabIndex = 27;
            this.btnHTKT.Text = "Hình Thức Khen Thưởng";
            this.btnHTKT.UseVisualStyleBackColor = true;
            this.btnHTKT.Click += new System.EventHandler(this.btnHTKT_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(260, 144);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(175, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 23);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(94, 144);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTenHTKT
            // 
            this.cbbTenHTKT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khenThuongBindingSource2, "MaHTKT", true));
            this.cbbTenHTKT.DataSource = this.hinhThucKhenThuongBindingSource1;
            this.cbbTenHTKT.DisplayMember = "TenHTKT";
            this.cbbTenHTKT.FormattingEnabled = true;
            this.cbbTenHTKT.Location = new System.Drawing.Point(125, 3);
            this.cbbTenHTKT.Name = "cbbTenHTKT";
            this.cbbTenHTKT.Size = new System.Drawing.Size(207, 24);
            this.cbbTenHTKT.TabIndex = 22;
            this.cbbTenHTKT.ValueMember = "MaHTKT";
            // 
            // khenThuongBindingSource2
            // 
            this.khenThuongBindingSource2.DataMember = "KhenThuong";
            this.khenThuongBindingSource2.DataSource = this.myDBDataSet;
            // 
            // hinhThucKhenThuongBindingSource1
            // 
            this.hinhThucKhenThuongBindingSource1.DataMember = "HinhThucKhenThuong";
            this.hinhThucKhenThuongBindingSource1.DataSource = this.myDBDataSet;
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khenThuongBindingSource, "MaNV", true));
            this.cbbHoTenNV.DataSource = this.nhanVienBindingSource;
            this.cbbHoTenNV.DisplayMember = "HoTenNV";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(125, 104);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(207, 24);
            this.cbbHoTenNV.TabIndex = 0;
            this.cbbHoTenNV.ValueMember = "MaNV";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.myDBDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // fillByAllKTToolStrip
            // 
            this.fillByAllKTToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllKTToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllKTToolStripButton});
            this.fillByAllKTToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByAllKTToolStrip.Name = "fillByAllKTToolStrip";
            this.fillByAllKTToolStrip.Size = new System.Drawing.Size(673, 27);
            this.fillByAllKTToolStrip.TabIndex = 22;
            this.fillByAllKTToolStrip.Text = "fillByAllKTToolStrip";
            // 
            // fillByAllKTToolStripButton
            // 
            this.fillByAllKTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllKTToolStripButton.Name = "fillByAllKTToolStripButton";
            this.fillByAllKTToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByAllKTToolStripButton.Text = "Reload";
            this.fillByAllKTToolStripButton.Click += new System.EventHandler(this.fillByAllKTToolStripButton_Click);
            // 
            // frmchitietKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 514);
            this.Controls.Add(this.fillByAllKTToolStrip);
            this.Controls.Add(maHTKTLabel);
            this.Controls.Add(lyDoLabel);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(ngayQuyetDinhLabel);
            this.Controls.Add(this.ngayQuyetDinhDateTimePicker);
            this.Controls.Add(this.khenThuongDataGridView);
            this.Controls.Add(this.hinhThucKhenThuongDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmchitietKT";
            this.Text = "Chi Tiết Khen Thưởng";
            this.Load += new System.EventHandler(this.chitietKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.fillByAllKTToolStrip.ResumeLayout(false);
            this.fillByAllKTToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource khenThuongBindingSource;
        private MyDBDataSetTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter hinhThucKhenThuongTableAdapter;
        private System.Windows.Forms.BindingSource hinhThucKhenThuongBindingSource;
        private System.Windows.Forms.DataGridView hinhThucKhenThuongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource khenThuongBindingSource1;
        private System.Windows.Forms.DataGridView khenThuongDataGridView;
        private MyDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource kyLuatBindingSource;
        private MyDBDataSet1TableAdapters.KyLuatTableAdapter kyLuatTableAdapter;
        private MyDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.DateTimePicker ngayQuyetDinhDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTenHTKT;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.BindingSource khenThuongBindingSource2;
        private System.Windows.Forms.BindingSource hinhThucKhenThuongBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.ToolStrip fillByAllKTToolStrip;
        private System.Windows.Forms.ToolStripButton fillByAllKTToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnHTKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHTKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}