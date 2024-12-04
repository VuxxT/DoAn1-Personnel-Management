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
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void QuanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLPBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap objfrm = new frmDangNhap();
            objfrm.Show();
        }

        private void QLCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucVu frm = new frmChucVu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLKTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietKT frm = new frmchitietKT();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLKLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietKL frm = new frmchitietKL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLNDHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            if(Program.vaitro == "admin")
            {
                QLCVToolStripMenuItem.Visible = false;
                QLNVToolStripMenuItem.Visible = false;
                QLPBToolStripMenuItem.Visible = false;
                QLKTToolStripMenuItem.Visible = false;
                QLKLToolStripMenuItem.Visible = false;
            }    
            if(Program.vaitro == "QuanLy")
            {
                QLNDHTToolStripMenuItem.Visible = false;
                QLKTToolStripMenuItem.Visible = false;
                QLKLToolStripMenuItem.Visible = false;
            }  
            if (Program.vaitro == "BanGD")
            {
                QLNVToolStripMenuItem.Visible = false;
                QLPBToolStripMenuItem.Visible = false;
                QLNDHTToolStripMenuItem.Visible = false;
            }    
        }
    }
}
