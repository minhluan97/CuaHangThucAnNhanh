using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLiCuaHangThucAnNhanh
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            //Load DataGridView
            LoadNhanVien();
            ////Dat lai ten cot
            //dgvNhanVien.Columns["StrMaNV"].HeaderText = "Mã NV";
            //dgvNhanVien.Columns["StrHoTenNV"].HeaderText = "Họ Tên";
            //dgvNhanVien.Columns["StrGTNV"].HeaderText = "Phái";
            //dgvNhanVien.Columns["StrNSNV"].HeaderText = "Ngày Sinh";
            //dgvNhanVien.Columns["StrSDTNV"].HeaderText = "Điện Thoại";
            //dgvNhanVien.Columns["StrDiaChiNV"].HeaderText = "Địa Chỉ";
            //dgvNhanVien.Columns["StrNgayLam"].HeaderText = "Ngày Vào Làm";
            //dgvNhanVien.Columns["StrMaCV"].Visible = false;
            ////dgvNhanVien.Columns["StrMaCV"].HeaderText = "Chức Vụ";
            //dgvNhanVien.Columns["StrTenCV"].HeaderText = "Chức Vụ";
            //dgvNhanVien.Columns["StrUsername"].HeaderText = "Tên Đăng Nhập";
            //dgvNhanVien.Columns["StrPassword"].HeaderText = "Mật Khẩu";
            //dgvNhanVien.Columns["StrQuyen"].HeaderText = "Quyền";
            ////Load Combobox
            LoadChucVu();
        }
        private void LoadNhanVien()
        {
            DataTable listNhanVien = NhanVien_BUS.LoadNhanVien();
            dgvNhanVien.DataSource = listNhanVien;
        }
        private void LoadChucVu()
        {
            DataTable listChucVu = ChucVu_BUS.LoadChucVu();
            cbxChucVu.DataSource = listChucVu;
            cbxChucVu.DisplayMember = "TEN_CV";
            cbxChucVu.ValueMember = "MA_CV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtXacNhanMK.Text == "")
            //{
            //    MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //NhanVien_DTO nvDTO = new NhanVien_DTO();
            //nvDTO.StrHoTenNV = txtHoTen.Text;
            //if (rbtnNam.Checked)
            //{ nvDTO.StrGTNV = "NAM"; }
            //else
            //{ nvDTO.StrGTNV = "NỮ"; }
            //nvDTO.StrNSNV = DateTime.Parse(dtpNS.Text.Trim());
            //nvDTO.StrSDTNV = txtSDT.Text.Trim();
            //nvDTO.StrDiaChiNV = txtDiaChi.Text.Trim();
            //nvDTO.StrMaCV = cbxChucVu.SelectedValue.ToString().Trim();
            //nvDTO.StrNgayLam = DateTime.Parse(dtpNgayLam.Text.Trim());
            ////nvDTO.StrUsername = txtTenDangNhap.Text.Trim();
            ////nvDTO.StrPassword = txtMatKhau.Text.Trim();
            ////nvDTO.StrQuyen = txtQuyen.Text.Trim();

            //DialogResult mes = MessageBox.Show("Bạn muốn thêm nhân viên này?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //if (DialogResult.OK == mes)
            //{
            //    if (NhanVien_BUS.ThemNhanVien(nvDTO) == true)
            //    {
            //        MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadNhanVien();
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            //    }
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //NhanVien_DTO nvDTO = new NhanVien_DTO();
            //nvDTO.StrMaNV = txtMaNV.Text;
            //DialogResult mes = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //if (DialogResult.OK == mes)
            //{
            //    if (NhanVien_BUS.XoaNhanVien(nvDTO) == true)
            //    {
            //        MessageBox.Show("Xoa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadNhanVien();
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            //    }
            //}

        }
    }
}
