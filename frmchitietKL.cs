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
    public partial class frmchitietKL : Form
    {
        public frmchitietKL()
        {
            InitializeComponent();
        }

        private void kyLuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kyLuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void chitietKL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.KyLuat' table. You can move, or remove it, as needed.
            this.kyLuatTableAdapter.Fill(this.myDBDataSet1.KyLuat);
            // TODO: This line of code loads data into the 'myDBDataSet1.HinhThucKyLuat' table. You can move, or remove it, as needed.
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet1.HinhThucKyLuat);
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            // TODO: This line of code loads data into the 'myDBDataSet.HinhThucKyLuat' table. You can move, or remove it, as needed.
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);
            // TODO: This line of code loads data into the 'myDBDataSet.KyLuat' table. You can move, or remove it, as needed.
            this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbMaHTKL.Text.Length < 1 || txtLyDo.Text.Length < 1 || cbbHoTenNV.Text.Length < 1)
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin");
                cbbMaHTKL.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.kyLuatTableAdapter.Insert(cbbMaHTKL.SelectedValue.ToString(),
                txtLyDo.Text,
                Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), 
                cbbHoTenNV.SelectedValue.ToString());
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.kyLuatTableAdapter.Delete(cbbMaHTKL.SelectedValue.ToString(), txtLyDo.Text, Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), cbbHoTenNV.SelectedValue.ToString());
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbMaHTKL.Text.Length < 1 || txtLyDo.Text.Length < 1 || cbbHoTenNV.Text.Length < 1)
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin");
                cbbMaHTKL.Focus();
            }
            else
                this.kyLuatBindingSource.EndEdit();
            this.kyLuatTableAdapter.Update(this.myDBDataSet);
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
        }

        private void fillByAllKLToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAllKLToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAllKLToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaHTKL.Text = txtLyDo.Text = cbbHoTenNV.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHTKyLuat objfrm = new frmHTKyLuat();
            objfrm.Show();
        }
    }
}
