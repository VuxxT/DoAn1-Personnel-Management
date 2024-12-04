using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1HTTT0120
{
    public partial class frmHTKyLuat : Form
    {
        public frmHTKyLuat()
        {
            InitializeComponent();
        }

        private void hinhThucKyLuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hinhThucKyLuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmHTKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.HinhThucKyLuat' table. You can move, or remove it, as needed.
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHTKL.Text.Length < 1 || txtTenHTKL.Text.Length < 1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin nha");
                txtMaHTKL.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.hinhThucKyLuatTableAdapter.Insert(txtMaHTKL.Text, txtTenHTKL.Text);
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.hinhThucKyLuatTableAdapter.Delete(txtMaHTKL.Text, txtTenHTKL.Text);
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHTKL.Text.Length < 1 || txtTenHTKL.Text.Length < 1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin nha");
                txtMaHTKL.Focus();
            }
            else
                this.hinhThucKyLuatBindingSource.EndEdit();
            this.hinhThucKyLuatTableAdapter.Update(this.myDBDataSet);
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHTKL.Text = txtTenHTKL.Text = "";
        }
    }
}
