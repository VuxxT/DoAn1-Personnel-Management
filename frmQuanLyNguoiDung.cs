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
    public partial class frmQuanLyNguoiDung : Form
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.myDBDataSet.TaiKhoan);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Length < 1 || txtMatKhau.Text.Length <1 || txtVaiTro.Text.Length <1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                txtTenDN.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.taiKhoanTableAdapter.Insert(txtTenDN.Text, txtMatKhau.Text, txtVaiTro.Text);
            this.taiKhoanTableAdapter.Fill(this.myDBDataSet.TaiKhoan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.taiKhoanTableAdapter.Delete(txtTenDN.Text, txtMatKhau.Text, txtVaiTro.Text);
            this.taiKhoanTableAdapter.Fill(this.myDBDataSet.TaiKhoan);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Length < 1 || txtMatKhau.Text.Length < 1 || txtVaiTro.Text.Length < 1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                txtTenDN.Focus();
            }
            else
                this.taiKhoanBindingSource.EndEdit();
            this.taiKhoanTableAdapter.Update(this.myDBDataSet);
            this.taiKhoanTableAdapter.Fill(this.myDBDataSet.TaiKhoan);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
