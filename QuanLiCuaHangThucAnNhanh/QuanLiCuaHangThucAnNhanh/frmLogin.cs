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
    public partial class frmLogin : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("SELECT * FROM LOGIN WHERE USERNAME='" + txtUsername.Text + "' AND PASS='" + txtPassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Đăng nhập thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frmmain = new frmMain(dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(),dt.Rows[0][2].ToString(),dt.Rows[0][3].ToString());
                this.Hide(); //frmmain.kt1 = true;
                frmmain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
