using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangThucAnNhanh
{
    public partial class frmMain : Form
    {
        public bool kt1=false;
        private string p1;
        private string p2;
        private string p3;
        private string p4;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string p1, string p2, string p3, string p4)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text ="Xin chào "  + p3.ToString();
            if (p4.ToString() != "admin")
            {
                btnQLNhanVien.Enabled=false;
                btnQLMenu.Enabled = false;
                
            }
            else kt1 = true;
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frmnhanvien = new frmQLNhanVien();
            frmnhanvien.ShowDialog();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLTaiKhoan frmtaikhoan = new frmQLTaiKhoan();
            frmtaikhoan.ShowDialog();
        }

        private void btnQLMenu_Click(object sender, EventArgs e)
        {
            frmQLMenu frmmenu = new frmQLMenu();
            frmmenu.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQLBanHang_Click(object sender, EventArgs e)
        {
            frmQLBanHang frmbanhang = new frmQLBanHang();
           // frmbanhang.MdiParent = this;    
            if (this.kt1 == true)
                frmbanhang.btnHuy.Hide();
            frmbanhang.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
