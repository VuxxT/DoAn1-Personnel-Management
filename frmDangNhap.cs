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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.myDBDataSet.TaiKhoan);
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var lstTaiKhoan = this.myDBDataSet.TaiKhoan.ToList();
            bool fl = false;
            foreach (var item in lstTaiKhoan)
            {
                string taikhoan = item[0].ToString();
                string matkhau = item[1].ToString();
                string vaitro = item[2].ToString();
                if (item[0].ToString().Equals(txtTenDangNhap.Text) && item[1].ToString().Equals(txtMatKhau.Text))
                {
                    fl = true;
                    Program.vaitro = item[2].ToString();
                    break;
                }
            }
            if (fl)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Hide();
                frmQuanLy frm = new frmQuanLy();
                frm.Show();
            }
            else
            {
                MessageBox.Show("thử lại");

            }

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

