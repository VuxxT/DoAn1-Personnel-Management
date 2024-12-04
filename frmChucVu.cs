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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void chucVuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chucVuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            // TODO: This line of code loads data into the 'myDBDataSet.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.FillByAllNV5(this.myDBDataSet.ChucVu);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text.Length < 1 || txtTenCV.Text.Length <1 || cbbNV.Text.Length <1)
            {
                MessageBox.Show("Mã Chức Vụ Không Được Để Trống");
                txtMaCV.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.chucVuTableAdapter.Insert(txtMaCV.Text, txtTenCV.Text, cbbNV.SelectedValue.ToString());
            this.chucVuTableAdapter.Fill(this.myDBDataSet.ChucVu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.chucVuTableAdapter.Delete(txtMaCV.Text, txtTenCV.Text, cbbNV.SelectedValue.ToString());
            this.chucVuTableAdapter.Fill(this.myDBDataSet.ChucVu);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text.Length < 1 || txtTenCV.Text.Length < 1 || cbbNV.Text.Length < 1)
            {
                MessageBox.Show("Mã Chức Vụ Không Được Để Trống");
                txtMaCV.Focus();
            }
            else
                this.chucVuBindingSource.EndEdit();
                this.chucVuTableAdapter.Update(this.myDBDataSet);
                this.chucVuTableAdapter.Fill(this.myDBDataSet.ChucVu);
                MessageBox.Show("Cập nhật thành công");
               
            
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chucVuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByAllNV5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.chucVuTableAdapter.FillByAllNV5(this.myDBDataSet.ChucVu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbNV.SelectedValue = txtMaCV.Text = txtTenCV.Text = "";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
