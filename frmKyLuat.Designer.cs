namespace DoAn1HTTT0120
{
    partial class frmKyLuat
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
            System.Windows.Forms.Label lyDoLabel;
            System.Windows.Forms.Label ngayQuyetDinhLabel;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.kyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenHTKL = new System.Windows.Forms.ComboBox();
            this.hinhThucKyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnHTKL = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.ngayQuyetDinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kyLuatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyLuatTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.KyLuatTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.hinhThucKyLuatTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.HinhThucKyLuatTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.fillByAllKLToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByAllKLToolStripButton = new System.Windows.Forms.ToolStripButton();
            lyDoLabel = new System.Windows.Forms.Label();
            ngayQuyetDinhLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fillByAllKLToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyDoLabel
            // 
            lyDoLabel.AutoSize = true;
            lyDoLabel.Location = new System.Drawing.Point(9, 44);
            lyDoLabel.Name = "lyDoLabel";
            lyDoLabel.Size = new System.Drawing.Size(45, 16);
            lyDoLabel.TabIndex = 2;
            lyDoLabel.Text = "Lý Do:";
            // 
            // ngayQuyetDinhLabel
            // 
            ngayQuyetDinhLabel.AutoSize = true;
            ngayQuyetDinhLabel.Location = new System.Drawing.Point(9, 71);
            ngayQuyetDinhLabel.Name = "ngayQuyetDinhLabel";
            ngayQuyetDinhLabel.Size = new System.Drawing.Size(113, 16);
            ngayQuyetDinhLabel.TabIndex = 4;
            ngayQuyetDinhLabel.Text = "Ngày Quyết  Định:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 16);
            label3.TabIndex = 16;
            label3.Text = "Họ Tên NV:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.cbbHoTenNV);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbTenHTKL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTroLai);
            this.panel1.Controls.Add(this.btnHTKL);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(lyDoLabel);
            this.panel1.Controls.Add(this.txtLyDo);
            this.panel1.Controls.Add(ngayQuyetDinhLabel);
            this.panel1.Controls.Add(this.ngayQuyetDinhDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 224);
            this.panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.Location = new System.Drawing.Point(252, 137);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 23);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kyLuatBindingSource, "MaNV", true));
            this.cbbHoTenNV.DataSource = this.nhanVienBindingSource;
            this.cbbHoTenNV.DisplayMember = "HoTenNV";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(126, 94);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(217, 24);
            this.cbbHoTenNV.TabIndex = 17;
            this.cbbHoTenNV.ValueMember = "MaNV";
            // 
            // kyLuatBindingSource
            // 
            this.kyLuatBindingSource.DataMember = "KyLuat";
            this.kyLuatBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.myDBDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên HTKL";
            // 
            // cbbTenHTKL
            // 
            this.cbbTenHTKL.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kyLuatBindingSource, "MaHTKL", true));
            this.cbbTenHTKL.DataSource = this.hinhThucKyLuatBindingSource;
            this.cbbTenHTKL.DisplayMember = "TenHTKL";
            this.cbbTenHTKL.FormattingEnabled = true;
            this.cbbTenHTKL.Location = new System.Drawing.Point(126, 11);
            this.cbbTenHTKL.Name = "cbbTenHTKL";
            this.cbbTenHTKL.Size = new System.Drawing.Size(217, 24);
            this.cbbTenHTKL.TabIndex = 14;
            this.cbbTenHTKL.ValueMember = "MaHTKL";
            // 
            // hinhThucKyLuatBindingSource
            // 
            this.hinhThucKyLuatBindingSource.DataMember = "HinhThucKyLuat";
            this.hinhThucKyLuatBindingSource.DataSource = this.myDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "(*)";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(268, 186);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 12;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnHTKL
            // 
            this.btnHTKL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHTKL.Location = new System.Drawing.Point(12, 186);
            this.btnHTKL.Name = "btnHTKL";
            this.btnHTKL.Size = new System.Drawing.Size(202, 23);
            this.btnHTKL.TabIndex = 11;
            this.btnHTKL.Text = "Hình Thức Kỷ Luật";
            this.btnHTKL.UseVisualStyleBackColor = false;
            this.btnHTKL.Click += new System.EventHandler(this.btnHTKL_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(172, 137);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(90, 137);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(12, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyLuatBindingSource, "LyDo", true));
            this.txtLyDo.Location = new System.Drawing.Point(126, 38);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(217, 22);
            this.txtLyDo.TabIndex = 3;
            // 
            // ngayQuyetDinhDateTimePicker
            // 
            this.ngayQuyetDinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kyLuatBindingSource, "NgayQuyetDinh", true));
            this.ngayQuyetDinhDateTimePicker.Location = new System.Drawing.Point(126, 65);
            this.ngayQuyetDinhDateTimePicker.Name = "ngayQuyetDinhDateTimePicker";
            this.ngayQuyetDinhDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.ngayQuyetDinhDateTimePicker.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kyLuatDataGridView);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 227);
            this.panel2.TabIndex = 1;
            // 
            // kyLuatDataGridView
            // 
            this.kyLuatDataGridView.AutoGenerateColumns = false;
            this.kyLuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kyLuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kyLuatDataGridView.DataSource = this.kyLuatBindingSource;
            this.kyLuatDataGridView.Location = new System.Drawing.Point(3, 3);
            this.kyLuatDataGridView.Name = "kyLuatDataGridView";
            this.kyLuatDataGridView.RowHeadersWidth = 51;
            this.kyLuatDataGridView.RowTemplate.Height = 24;
            this.kyLuatDataGridView.Size = new System.Drawing.Size(379, 209);
            this.kyLuatDataGridView.TabIndex = 0;
            this.kyLuatDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kyLuatDataGridView_CellContentClick);
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
            // kyLuatTableAdapter
            // 
            this.kyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = null;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KyLuatTableAdapter = this.kyLuatTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hinhThucKyLuatTableAdapter
            // 
            this.hinhThucKyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kỷ luật";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(374, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 257);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên kỷ luật";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // fillByAllKLToolStrip
            // 
            this.fillByAllKLToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllKLToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllKLToolStripButton});
            this.fillByAllKLToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByAllKLToolStrip.Name = "fillByAllKLToolStrip";
            this.fillByAllKLToolStrip.Size = new System.Drawing.Size(778, 27);
            this.fillByAllKLToolStrip.TabIndex = 4;
            this.fillByAllKLToolStrip.Text = "fillByAllKLToolStrip";
            // 
            // fillByAllKLToolStripButton
            // 
            this.fillByAllKLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllKLToolStripButton.Name = "fillByAllKLToolStripButton";
            this.fillByAllKLToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByAllKLToolStripButton.Text = "Reload";
            this.fillByAllKLToolStripButton.Click += new System.EventHandler(this.fillByAllKLToolStripButton_Click);
            // 
            // frmKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 303);
            this.Controls.Add(this.fillByAllKLToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKyLuat";
            this.Text = "Kỷ Luật";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKyLuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKyLuatBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kyLuatDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.fillByAllKLToolStrip.ResumeLayout(false);
            this.fillByAllKLToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource kyLuatBindingSource;
        private MyDBDataSetTableAdapters.KyLuatTableAdapter kyLuatTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnHTKL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.DateTimePicker ngayQuyetDinhDateTimePicker;
        private System.Windows.Forms.DataGridView kyLuatDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenHTKL;
        private System.Windows.Forms.BindingSource hinhThucKyLuatBindingSource;
        private MyDBDataSetTableAdapters.HinhThucKyLuatTableAdapter hinhThucKyLuatTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip fillByAllKLToolStrip;
        private System.Windows.Forms.ToolStripButton fillByAllKLToolStripButton;
        private System.Windows.Forms.Button btnLamMoi;
    }
}