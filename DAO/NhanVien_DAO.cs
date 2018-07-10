using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVien_DAO: DBConnect
    {
        //bien ket noi
        static SqlConnection con;
        static string strChuoiKetNoi = @"Data Source=Desktop-713sjhm;Initial Catalog=QUANLIFASTFOOD;Integrated Security=True";


        public static DataTable LoadNhanVien()
        {
            con = new SqlConnection(strChuoiKetNoi);
            string strTruyVan = @"SELECT A.MA_NV,HOTEN_NV,NS_NV,GT_NV,DIACHI_NV,SDT_NV,NGAYVAOLAM,A.MA_CV FROM NHANVIEN A";
            SqlDataAdapter DANhanVien = new SqlDataAdapter();
            DANhanVien.SelectCommand = new SqlCommand(strTruyVan, con);
            DataSet ds = new DataSet();
            DANhanVien.Fill(ds, "tblNhanVien");
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = ds.Tables["tblNhanVien"];
            return dtNhanVien;
        }
    }
}
