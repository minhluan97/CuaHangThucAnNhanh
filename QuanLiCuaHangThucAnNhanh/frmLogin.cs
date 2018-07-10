using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLiCuaHangThucAnNhanh
{
    public partial class frmLogin : Form
    {
        ConnectToSQL con = new ConnectToSQL();
        //DataProvider con = new DataProvider();   
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dt = con.G("SELECT * FROM LOGIN WHERE USERNAME='" + txtUsername.Text + "' AND PASS='" + txtPassword.Text + "'");
            dt =con.GetData("SELECT * FROM LOGIN WHERE USERNAME='" + txtUsername.Text + "' AND PASS='" + txtPassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
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
