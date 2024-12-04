namespace DoAn1HTTT0120
{
    partial class frmKhenThuong
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.khenThuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenHTKT = new System.Windows.Forms.ComboBox();
            this.hinhThucKhenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnHTKT = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.khenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngayQuyetDinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.khenThuongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHTKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khenThuongTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.KhenThuongTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            this.hinhThucKhenThuongTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nhanVienTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.NhanVienTableAdapter();
            this.fillByAllKTToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByAllKTToolStripButton = new System.Windows.Forms.ToolStripButton();
            lyDoLabel = new System.Windows.Forms.Label();
            ngayQuyetDinhLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fillByAllKTToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyDoLabel
            // 
            lyDoLabel.AutoSize = true;
            lyDoLabel.Location = new System.Drawing.Point(3, 39);
            lyDoLabel.Name = "lyDoLabel";
            lyDoLabel.Size = new System.Drawing.Size(45, 16);
            lyDoLabel.TabIndex = 2;
            lyDoLabel.Text = "Lý Do:";
            // 
            // ngayQuyetDinhLabel
            // 
            ngayQuyetDinhLabel.AutoSize = true;
            ngayQuyetDinhLabel.Location = new System.Drawing.Point(3, 69);
            ngayQuyetDinhLabel.Name = "ngayQuyetDinhLabel";
            ngayQuyetDinhLabel.Size = new System.Drawing.Size(110, 16);
            ngayQuyetDinhLabel.TabIndex = 4;
            ngayQuyetDinhLabel.Text = "Ngày Quyết Định:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 16);
            label2.TabIndex = 16;
            label2.Text = "Tên HTKT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 16);
            label3.TabIndex = 17;
            label3.Text = "Họ Tên NV:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.cbbHoTenNV);
            this.panel1.Controls.Add(this.cbbTenHTKT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHTKT);
            this.panel1.Controls.Add(this.btnTroLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(lyDoLabel);
            this.panel1.Controls.Add(this.txtLyDo);
            this.panel1.Controls.Add(ngayQuyetDinhLabel);
            this.panel1.Controls.Add(this.ngayQuyetDinhDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(4, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 257);
            this.panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.Location = new System.Drawing.Point(259, 160);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 23);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khenThuongBindingSource1, "MaNV", true));
            this.cbbHoTenNV.DataSource = this.nhanVienBindingSource;
            this.cbbHoTenNV.DisplayMember = "HoTenNV";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(127, 100);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(217, 24);
            this.cbbHoTenNV.TabIndex = 15;
            this.cbbHoTenNV.ValueMember = "MaNV";
            // 
            // khenThuongBindingSource1
            // 
            this.khenThuongBindingSource1.DataMember = "KhenThuong";
            this.khenThuongBindingSource1.DataSource = this.myDBDataSet;
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
            // cbbTenHTKT
            // 
            this.cbbTenHTKT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khenThuongBindingSource1, "MaHTKT", true));
            this.cbbTenHTKT.DataSource = this.hinhThucKhenThuongBindingSource;
            this.cbbTenHTKT.DisplayMember = "TenHTKT";
            this.cbbTenHTKT.FormattingEnabled = true;
            this.cbbTenHTKT.Location = new System.Drawing.Point(127, 6);
            this.cbbTenHTKT.Name = "cbbTenHTKT";
            this.cbbTenHTKT.Size = new System.Drawing.Size(217, 24);
            this.cbbTenHTKT.TabIndex = 14;
            this.cbbTenHTKT.ValueMember = "MaHTKT";
            // 
            // hinhThucKhenThuongBindingSource
            // 
            this.hinhThucKhenThuongBindingSource.DataMember = "HinhThucKhenThuong";
            this.hinhThucKhenThuongBindingSource.DataSource = this.myDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "(*)";
            // 
            // btnHTKT
            // 
            this.btnHTKT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHTKT.Location = new System.Drawing.Point(6, 212);
            this.btnHTKT.Name = "btnHTKT";
            this.btnHTKT.Size = new System.Drawing.Size(186, 23);
            this.btnHTKT.TabIndex = 12;
            this.btnHTKT.Text = "Hình Thức Khen Thưởng";
            this.btnHTKT.UseVisualStyleBackColor = false;
            this.btnHTKT.Click += new System.EventHandler(this.btnHTKT_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(269, 215);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 11;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(170, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(87, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(6, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLyDo
            // 
            this.txtLyDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khenThuongBindingSource, "LyDo", true));
            this.txtLyDo.Location = new System.Drawing.Point(127, 36);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(217, 22);
            this.txtLyDo.TabIndex = 3;
            // 
            // khenThuongBindingSource
            // 
            this.khenThuongBindingSource.DataMember = "KhenThuong";
            this.khenThuongBindingSource.DataSource = this.myDBDataSet;
            // 
            // ngayQuyetDinhDateTimePicker
            // 
            this.ngayQuyetDinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khenThuongBindingSource, "NgayQuyetDinh", true));
            this.ngayQuyetDinhDateTimePicker.Location = new System.Drawing.Point(127, 64);
            this.ngayQuyetDinhDateTimePicker.Name = "ngayQuyetDinhDateTimePicker";
            this.ngayQuyetDinhDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.ngayQuyetDinhDateTimePicker.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.khenThuongDataGridView);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 254);
            this.panel2.TabIndex = 1;
            // 
            // khenThuongDataGridView
            // 
            this.khenThuongDataGridView.AutoGenerateColumns = false;
            this.khenThuongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khenThuongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.MaNV,
            this.MaHTKT,
            this.dataGridViewTextBoxColumn3});
            this.khenThuongDataGridView.DataSource = this.khenThuongBindingSource;
            this.khenThuongDataGridView.Location = new System.Drawing.Point(3, 3);
            this.khenThuongDataGridView.Name = "khenThuongDataGridView";
            this.khenThuongDataGridView.RowHeadersWidth = 51;
            this.khenThuongDataGridView.RowTemplate.Height = 24;
            this.khenThuongDataGridView.Size = new System.Drawing.Size(364, 232);
            this.khenThuongDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LyDo";
            this.dataGridViewTextBoxColumn2.HeaderText = "LyDo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "HoTenNV";
            this.MaNV.HeaderText = "HoTenNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // MaHTKT
            // 
            this.MaHTKT.DataPropertyName = "TenHTKT";
            this.MaHTKT.HeaderText = "Ten HTKT";
            this.MaHTKT.MinimumWidth = 6;
            this.MaHTKT.Name = "MaHTKT";
            this.MaHTKT.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayQuyetDinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // khenThuongTableAdapter
            // 
            this.khenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = null;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khen thưởng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(381, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên khen thưởng";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // fillByAllKTToolStrip1
            // 
            this.fillByAllKTToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByAllKTToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllKTToolStripButton});
            this.fillByAllKTToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByAllKTToolStrip1.Name = "fillByAllKTToolStrip1";
            this.fillByAllKTToolStrip1.Size = new System.Drawing.Size(807, 27);
            this.fillByAllKTToolStrip1.TabIndex = 5;
            this.fillByAllKTToolStrip1.Text = "fillByAllKTToolStrip1";
            // 
            // fillByAllKTToolStripButton
            // 
            this.fillByAllKTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllKTToolStripButton.Name = "fillByAllKTToolStripButton";
            this.fillByAllKTToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.fillByAllKTToolStripButton.Text = "Reload";
            this.fillByAllKTToolStripButton.Click += new System.EventHandler(this.fillByAllKTToolStripButton_Click_2);
            // 
            // frmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 398);
            this.Controls.Add(this.fillByAllKTToolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhenThuong";
            this.Text = "Khen Thưởng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhenThuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khenThuongDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.fillByAllKTToolStrip1.ResumeLayout(false);
            this.fillByAllKTToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource khenThuongBindingSource;
        private MyDBDataSetTableAdapters.KhenThuongTableAdapter khenThuongTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHTKT;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.DateTimePicker ngayQuyetDinhDateTimePicker;
        private System.Windows.Forms.DataGridView khenThuongDataGridView;
        private System.Windows.Forms.ComboBox cbbTenHTKT;
        private System.Windows.Forms.BindingSource hinhThucKhenThuongBindingSource;
        private MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter hinhThucKhenThuongTableAdapter;
        private System.Windows.Forms.BindingSource khenThuongBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private MyDBDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHTKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStrip fillByAllKTToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByAllKTToolStripButton;
    }
}