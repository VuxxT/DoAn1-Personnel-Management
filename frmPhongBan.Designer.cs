namespace DoAn1HTTT0120
{
    partial class frmPhongBan
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
            System.Windows.Forms.Label maPBLabel;
            System.Windows.Forms.Label tenPBLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenChucVu = new System.Windows.Forms.ComboBox();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phongBanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBanTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.PhongBanTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.chucVuTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.ChucVuTableAdapter();
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillByAllCVToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByAllCVToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillByAllCVToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByAllCVToolStripButton = new System.Windows.Forms.ToolStripButton();
            maPBLabel = new System.Windows.Forms.Label();
            tenPBLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fillByAllCVToolStrip1.SuspendLayout();
            this.fillByAllCVToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // maPBLabel
            // 
            maPBLabel.AutoSize = true;
            maPBLabel.Location = new System.Drawing.Point(10, 17);
            maPBLabel.Name = "maPBLabel";
            maPBLabel.Size = new System.Drawing.Size(50, 16);
            maPBLabel.TabIndex = 0;
            maPBLabel.Text = "Mã PB:";
            // 
            // tenPBLabel
            // 
            tenPBLabel.AutoSize = true;
            tenPBLabel.Location = new System.Drawing.Point(10, 45);
            tenPBLabel.Name = "tenPBLabel";
            tenPBLabel.Size = new System.Drawing.Size(55, 16);
            tenPBLabel.TabIndex = 2;
            tenPBLabel.Text = "Tên PB:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 16);
            label1.TabIndex = 17;
            label1.Text = "Họ Tên NV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 16);
            label2.TabIndex = 18;
            label2.Text = "Tên Chức Vụ:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.cbbHoTenNV);
            this.panel1.Controls.Add(this.cbbTenChucVu);
            this.panel1.Controls.Add(this.btnTroLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(maPBLabel);
            this.panel1.Controls.Add(this.txtMaPB);
            this.panel1.Controls.Add(tenPBLabel);
            this.panel1.Controls.Add(this.txtTenPB);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 251);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemMoi.Location = new System.Drawing.Point(208, 144);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(83, 23);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Làm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phongBanBindingSource, "MaNV", true));
            this.cbbHoTenNV.DataSource = this.nhanVienBindingSource;
            this.cbbHoTenNV.DisplayMember = "HoTenNV";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(97, 70);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(194, 24);
            this.cbbHoTenNV.TabIndex = 15;
            this.cbbHoTenNV.ValueMember = "MaNV";
            this.cbbHoTenNV.SelectedIndexChanged += new System.EventHandler(this.cbbHoTenNV_SelectedIndexChanged);
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.myDBDataSet;
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
            // cbbTenChucVu
            // 
            this.cbbTenChucVu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phongBanBindingSource, "MaChucVu", true));
            this.cbbTenChucVu.DataSource = this.chucVuBindingSource;
            this.cbbTenChucVu.DisplayMember = "TenChucVu";
            this.cbbTenChucVu.FormattingEnabled = true;
            this.cbbTenChucVu.Location = new System.Drawing.Point(102, 100);
            this.cbbTenChucVu.Name = "cbbTenChucVu";
            this.cbbTenChucVu.Size = new System.Drawing.Size(189, 24);
            this.cbbTenChucVu.TabIndex = 14;
            this.cbbTenChucVu.ValueMember = "MaChucVu";
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.myDBDataSet;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(216, 208);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 13;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(142, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(75, 144);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(8, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPB
            // 
            this.txtMaPB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "MaPB", true));
            this.txtMaPB.Location = new System.Drawing.Point(97, 14);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(194, 22);
            this.txtMaPB.TabIndex = 1;
            this.txtMaPB.TextChanged += new System.EventHandler(this.txtMaPB_TextChanged);
            // 
            // txtTenPB
            // 
            this.txtTenPB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBanBindingSource, "TenPB", true));
            this.txtTenPB.Location = new System.Drawing.Point(97, 42);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(194, 22);
            this.txtTenPB.TabIndex = 3;
            this.txtTenPB.TextChanged += new System.EventHandler(this.txtTenPB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.phongBanDataGridView);
            this.panel2.Location = new System.Drawing.Point(10, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 251);
            this.panel2.TabIndex = 1;
            // 
            // phongBanDataGridView
            // 
            this.phongBanDataGridView.AutoGenerateColumns = false;
            this.phongBanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongBanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaNV,
            this.MaChucVu,
            this.dataGridViewTextBoxColumn2});
            this.phongBanDataGridView.DataSource = this.phongBanBindingSource;
            this.phongBanDataGridView.Location = new System.Drawing.Point(5, 6);
            this.phongBanDataGridView.Name = "phongBanDataGridView";
            this.phongBanDataGridView.RowHeadersWidth = 51;
            this.phongBanDataGridView.RowTemplate.Height = 24;
            this.phongBanDataGridView.Size = new System.Drawing.Size(345, 225);
            this.phongBanDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPB";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaPB";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "HoTenNV";
            this.MaNV.HeaderText = "Ten NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "TenChucVu";
            this.MaChucVu.HeaderText = "Ten Chuc Vu";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenPB";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenPB";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = null;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KyLuatTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = this.phongBanTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(325, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng ban";
            // 
            // fillByAllCVToolStrip1
            // 
            this.fillByAllCVToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAllCVToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllCVToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllCVToolStripButton1});
            this.fillByAllCVToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByAllCVToolStrip1.Name = "fillByAllCVToolStrip1";
            this.fillByAllCVToolStrip1.Size = new System.Drawing.Size(73, 27);
            this.fillByAllCVToolStrip1.TabIndex = 5;
            this.fillByAllCVToolStrip1.Text = "fillByAllCVToolStrip1";
            // 
            // fillByAllCVToolStripButton1
            // 
            this.fillByAllCVToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllCVToolStripButton1.Name = "fillByAllCVToolStripButton1";
            this.fillByAllCVToolStripButton1.Size = new System.Drawing.Size(60, 24);
            this.fillByAllCVToolStripButton1.Text = "Reload";
            this.fillByAllCVToolStripButton1.Click += new System.EventHandler(this.fillByAllCVToolStripButton1_Click);
            // 
            // fillByAllCVToolStrip
            // 
            this.fillByAllCVToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllCVToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllCVToolStripButton});
            this.fillByAllCVToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByAllCVToolStrip.Name = "fillByAllCVToolStrip";
            this.fillByAllCVToolStrip.Size = new System.Drawing.Size(716, 27);
            this.fillByAllCVToolStrip.TabIndex = 6;
            this.fillByAllCVToolStrip.Text = "fillByAllCVToolStrip";
            // 
            // fillByAllCVToolStripButton
            // 
            this.fillByAllCVToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllCVToolStripButton.Name = "fillByAllCVToolStripButton";
            this.fillByAllCVToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByAllCVToolStripButton.Text = "Reload";
            this.fillByAllCVToolStripButton.Click += new System.EventHandler(this.fillByAllCVToolStripButton_Click_1);
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 323);
            this.Controls.Add(this.fillByAllCVToolStrip);
            this.Controls.Add(this.fillByAllCVToolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhongBan";
            this.Text = "Phòng Ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.fillByAllCVToolStrip1.ResumeLayout(false);
            this.fillByAllCVToolStrip1.PerformLayout();
            this.fillByAllCVToolStrip.ResumeLayout(false);
            this.fillByAllCVToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private MyDBDataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.ComboBox cbbTenChucVu;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private MyDBDataSetTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView phongBanDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip fillByAllCVToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByAllCVToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip fillByAllCVToolStrip;
        private System.Windows.Forms.ToolStripButton fillByAllCVToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}