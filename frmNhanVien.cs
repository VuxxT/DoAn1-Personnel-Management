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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length < 1 || txtHoTenNV.Text.Length < 1 || txtDiaChi.Text.Length < 1 || txtGioiTinh.Text.Length < 1 || txtLuong.Text.Length < 1 || txtSDT.Text.Length < 1)
            {
                MessageBox.Show("Nhập Thông Tin Đầy Đủ");
                txtMaNV.Focus();
      
            }
            else
                MessageBox.Show("Thêm thành công");
            this.nhanVienTableAdapter.Insert(txtMaNV.Text, txtHoTenNV.Text, txtGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text), Convert.ToDateTime(ngayNhanViec_DateTimePicker.Text));
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            this.nhanVienBindingSource.RemoveFilter();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Delete(txtMaNV.Text, txtHoTenNV.Text, txtGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text), Convert.ToDateTime(ngayNhanViec_DateTimePicker.Text));
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            this.nhanVienBindingSource.RemoveFilter();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length <1 || txtHoTenNV.Text.Length<1 || txtGioiTinh.Text.Length<1 || txtDiaChi.Text.Length<1 || txtSDT.Text.Length<1 || txtLuong.Text.Length<1)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                txtMaNV.Focus();
            }
            else
            {
                this.nhanVienBindingSource.EndEdit();
                this.nhanVienTableAdapter.Update(this.myDBDataSet);
                this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
                MessageBox.Show("Cập nhật thành công");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.nhanVienBindingSource.Filter = $"HoTenNV like '%{txtTimKiem.Text}%'";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = txtHoTenNV.Text = txtGioiTinh.Text = txtDiaChi.Text = txtLuong.Text = txtSDT.Text = "";
        }

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            //if(txtMaNV.Text.Length<1)
            //{
            //    MessageBox.Show("Nhập Mã Nhân Viên");
            //    txtMaNV.Focus();
            //}    
        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nhanVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
