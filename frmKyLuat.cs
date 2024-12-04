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
    public partial class frmKyLuat : Form
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }

        private void kyLuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kyLuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            // TODO: This line of code loads data into the 'myDBDataSet.HinhThucKyLuat' table. You can move, or remove it, as needed.
            this.hinhThucKyLuatTableAdapter.Fill(this.myDBDataSet.HinhThucKyLuat);
            // TODO: This line of code loads data into the 'myDBDataSet.KyLuat' table. You can move, or remove it, as needed.
            //this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLyDo.Text.Length <1 || cbbTenHTKL.Text.Length <1 || cbbHoTenNV.Text.Length <1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                txtLyDo.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.kyLuatTableAdapter.Insert(cbbTenHTKL.SelectedValue.ToString(), txtLyDo.Text, Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), cbbHoTenNV.SelectedValue.ToString());
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //this.kyLuatTableAdapter.Delete(cbbTenHTKL.SelectedValue.ToString(), txtLyDo.Text, Convert.ToDateTime(ngayQuyetDinhDateTimePicker.Text), cbbHoTenNV.SelectedValue.ToString());
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtLyDo.Text.Length < 1 || cbbTenHTKL.Text.Length < 1 || cbbHoTenNV.Text.Length < 1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                txtLyDo.Focus();
            }
            else
                this.kyLuatBindingSource.EndEdit();
            this.kyLuatTableAdapter.Update(this.myDBDataSet);
            this.kyLuatTableAdapter.Fill(this.myDBDataSet.KyLuat);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHTKL_Click(object sender, EventArgs e)
        {
            frmHTKyLuat objfrm = new frmHTKyLuat();
            objfrm.Show();
        }

        private void kyLuatDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByAllKLToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.kyLuatTableAdapter.FillByAllKL(this.myDBDataSet.KyLuat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbHoTenNV.SelectedValue= cbbTenHTKL.SelectedValue = txtLyDo.Text = "";
        }
    }
}
