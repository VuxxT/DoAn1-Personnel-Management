namespace DoAn1HTTT0120
{
    partial class frmHTKhenThuong
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
            System.Windows.Forms.Label tenHTKTLabel;
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHTKT = new System.Windows.Forms.TextBox();
            this.hinhThucKhenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DoAn1HTTT0120.MyDBDataSet();
            this.txtTenHTKT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hinhThucKhenThuongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hinhThucKhenThuongTableAdapter = new DoAn1HTTT0120.MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter();
            this.tableAdapterManager = new DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager();
            maHTKTLabel = new System.Windows.Forms.Label();
            tenHTKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maHTKTLabel
            // 
            maHTKTLabel.AutoSize = true;
            maHTKTLabel.Location = new System.Drawing.Point(6, 33);
            maHTKTLabel.Name = "maHTKTLabel";
            maHTKTLabel.Size = new System.Drawing.Size(68, 16);
            maHTKTLabel.TabIndex = 0;
            maHTKTLabel.Text = "Mã HTKT:";
            // 
            // tenHTKTLabel
            // 
            tenHTKTLabel.AutoSize = true;
            tenHTKTLabel.Location = new System.Drawing.Point(6, 72);
            tenHTKTLabel.Name = "tenHTKTLabel";
            tenHTKTLabel.Size = new System.Drawing.Size(73, 16);
            tenHTKTLabel.TabIndex = 2;
            tenHTKTLabel.Text = "Tên HTKT:";
            tenHTKTLabel.Click += new System.EventHandler(this.tenHTKTLabel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(149, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(78, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(7, 97);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaHTKT
            // 
            this.txtMaHTKT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hinhThucKhenThuongBindingSource, "MaHTKT", true));
            this.txtMaHTKT.Location = new System.Drawing.Point(80, 30);
            this.txtMaHTKT.Name = "txtMaHTKT";
            this.txtMaHTKT.Size = new System.Drawing.Size(208, 22);
            this.txtMaHTKT.TabIndex = 1;
            // 
            // hinhThucKhenThuongBindingSource
            // 
            this.hinhThucKhenThuongBindingSource.DataMember = "HinhThucKhenThuong";
            this.hinhThucKhenThuongBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenHTKT
            // 
            this.txtTenHTKT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hinhThucKhenThuongBindingSource, "TenHTKT", true));
            this.txtTenHTKT.Location = new System.Drawing.Point(80, 69);
            this.txtTenHTKT.Name = "txtTenHTKT";
            this.txtTenHTKT.Size = new System.Drawing.Size(208, 22);
            this.txtTenHTKT.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hinhThucKhenThuongDataGridView);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 197);
            this.panel2.TabIndex = 1;
            // 
            // hinhThucKhenThuongDataGridView
            // 
            this.hinhThucKhenThuongDataGridView.AutoGenerateColumns = false;
            this.hinhThucKhenThuongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hinhThucKhenThuongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.hinhThucKhenThuongDataGridView.DataSource = this.hinhThucKhenThuongBindingSource;
            this.hinhThucKhenThuongDataGridView.Location = new System.Drawing.Point(3, 3);
            this.hinhThucKhenThuongDataGridView.Name = "hinhThucKhenThuongDataGridView";
            this.hinhThucKhenThuongDataGridView.RowHeadersWidth = 51;
            this.hinhThucKhenThuongDataGridView.RowTemplate.Height = 24;
            this.hinhThucKhenThuongDataGridView.Size = new System.Drawing.Size(296, 185);
            this.hinhThucKhenThuongDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHTKT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHTKT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHTKT";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenHTKT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnTroLai);
            this.groupBox1.Controls.Add(maHTKTLabel);
            this.groupBox1.Controls.Add(this.txtMaHTKT);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(tenHTKTLabel);
            this.groupBox1.Controls.Add(this.txtTenHTKT);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hình thức khen thưởng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.Location = new System.Drawing.Point(220, 97);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(72, 23);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(213, 154);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 7;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 224);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hình thức khen thưởng";
            // 
            // hinhThucKhenThuongTableAdapter
            // 
            this.hinhThucKhenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HinhThucKhenThuongTableAdapter = this.hinhThucKhenThuongTableAdapter;
            this.tableAdapterManager.HinhThucKyLuatTableAdapter = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.KyLuatTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongBanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn1HTTT0120.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmHTKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHTKhenThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hình Thức Khen Thưởng";
            this.Load += new System.EventHandler(this.frmHTKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucKhenThuongDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource hinhThucKhenThuongBindingSource;
        private MyDBDataSetTableAdapters.HinhThucKhenThuongTableAdapter hinhThucKhenThuongTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHTKT;
        private System.Windows.Forms.TextBox txtTenHTKT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView hinhThucKhenThuongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}