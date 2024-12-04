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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void phongBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phongBanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.myDBDataSet.NhanVien);
            // TODO: This line of code loads data into the 'myDBDataSet.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.myDBDataSet.ChucVu);
            // TODO: This line of code loads data into the 'myDBDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.FillByAllCV(this.myDBDataSet.PhongBan);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Length < 1 || txtTenPB.Text.Length < 1 || cbbHoTenNV.Text.Length<1 || cbbTenChucVu.Text.Length<1)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                txtMaPB.Focus();
            }
            else
                MessageBox.Show("Thêm thành công");
            this.phongBanTableAdapter.Insert(txtMaPB.Text, txtTenPB.Text, cbbHoTenNV.SelectedValue.ToString(), cbbTenChucVu.SelectedValue.ToString());
            this.phongBanTableAdapter.Fill(this.myDBDataSet.PhongBan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.phongBanTableAdapter.Delete(txtMaPB.Text, txtTenPB.Text, cbbHoTenNV.SelectedValue.ToString(), cbbTenChucVu.SelectedValue.ToString());
            this.phongBanTableAdapter.Fill(this.myDBDataSet.PhongBan);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Length < 1 || txtTenPB.Text.Length < 1 || cbbHoTenNV.Text.Length < 1 || cbbTenChucVu.Text.Length < 1)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                txtMaPB.Focus();
            }
            else
                MessageBox.Show("Cập nhật thành công");
            this.phongBanBindingSource.EndEdit();
            this.phongBanTableAdapter.Update(this.myDBDataSet);
            this.phongBanTableAdapter.Fill(this.myDBDataSet.PhongBan);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTenPB_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cbbHoTenNV.SelectedValue = cbbTenChucVu.SelectedValue=txtMaPB.Text = txtTenPB.Text = "";
        }

        private void fillByAllCVToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongBanTableAdapter.FillByAllCV(this.myDBDataSet.PhongBan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAllCVToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongBanTableAdapter.FillByAllCV(this.myDBDataSet.PhongBan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAllCVToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.phongBanTableAdapter.FillByAllCV(this.myDBDataSet.PhongBan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbHoTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillByAllCVToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.phongBanTableAdapter.FillByAllCV(this.myDBDataSet.PhongBan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
