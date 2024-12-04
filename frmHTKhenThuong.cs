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
    public partial class frmHTKhenThuong : Form
    {
        public frmHTKhenThuong()
        {
            InitializeComponent();
        }

        private void hinhThucKhenThuongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hinhThucKhenThuongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmHTKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.KhenThuong' table. You can move, or remove it, as needed.
            //this.khenThuongTableAdapter.Fill(this.myDBDataSet.KhenThuong);
            // TODO: This line of code loads data into the 'myDBDataSet.HinhThucKhenThuong' table. You can move, or remove it, as needed.
            this.hinhThucKhenThuongTableAdapter.Fill(this.myDBDataSet.HinhThucKhenThuong);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHTKT.Text.Length < 1 && txtTenHTKT.Text.Length < 1)
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin");
                txtMaHTKT.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.hinhThucKhenThuongTableAdapter.Insert(txtMaHTKT.Text,txtTenHTKT.Text);
            this.hinhThucKhenThuongTableAdapter.Fill(this.myDBDataSet.HinhThucKhenThuong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.hinhThucKhenThuongTableAdapter.Delete(txtMaHTKT.Text, txtTenHTKT.Text);
            this.hinhThucKhenThuongTableAdapter.Fill(this.myDBDataSet.HinhThucKhenThuong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHTKT.Text.Length < 1 && txtTenHTKT.Text.Length < 1)
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin");
                txtMaHTKT.Focus();
            }
            else
                this.hinhThucKhenThuongBindingSource.EndEdit();
            this.hinhThucKhenThuongTableAdapter.Update(this.myDBDataSet);
            this.hinhThucKhenThuongTableAdapter.Fill(this.myDBDataSet.HinhThucKhenThuong);
        }



        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHTKT.Text = txtTenHTKT.Text = "";
        }

        private void tenHTKTLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
