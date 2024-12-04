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
    public partial class frmKhenThuong : Form
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        private void khenThuongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khenThuongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            // TODO: This line of code loads data into the 'myDBDataSet.HinhThucKhenThuong' table. You can move, or remove it, as needed.
            this.hinhThucKhenThuongTableAdapter.Fill(this.myDBDataSet.HinhThucKhenThuong);
            // TODO: This line of code loads data into the 'myDBDataSet.KhenThuong' table. You can move, or remove it, as needed.
            this.khenThuongTableAdapter.FillByAllKT(this.myDBDataSet.KhenThuong);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbTenHTKT.Text.Length < 1 || cbbHoTenNV.Text.Length < 1 || txtLyDo.Text.Length <1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                txtLyDo.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.khenThuongTableAdapter.Insert(cbbTenHTKT.SelectedValue.ToString(), txtLyDo.Text, Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), cbbHoTenNV.SelectedValue.ToString());
            this.khenThuongTableAdapter.Fill(this.myDBDataSet.KhenThuong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.khenThuongTableAdapter.Delete(cbbTenHTKT.SelectedValue.ToString(), txtLyDo.Text, Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), cbbHoTenNV.SelectedValue.ToString());
            this.khenThuongTableAdapter.Fill(this.myDBDataSet.KhenThuong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbTenHTKT.Text.Length < 1 || cbbHoTenNV.Text.Length < 1 || txtLyDo.Text.Length < 1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                txtLyDo.Focus();
            }
            else
                this.khenThuongBindingSource.EndEdit();
            this.khenThuongTableAdapter.Update(this.myDBDataSet);
            this.khenThuongTableAdapter.Fill(this.myDBDataSet.KhenThuong);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHTKT_Click(object sender, EventArgs e)
        {
            frmHTKhenThuong objfrm = new frmHTKhenThuong();
            objfrm.Show();
        }

        private void fillByAllKTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.khenThuongTableAdapter.FillByAllKT(this.myDBDataSet.KhenThuong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbTenHTKT.SelectedValue = cbbHoTenNV.SelectedValue = txtLyDo.Text = "";
        }

        private void fillByAllKTToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.khenThuongTableAdapter.FillByAllKT(this.myDBDataSet.KhenThuong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAllKTToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.khenThuongTableAdapter.FillByAllKT(this.myDBDataSet.KhenThuong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
