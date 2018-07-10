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
    public class NhanVien_DAO
    {
        //bien ket noi
        static SqlConnection con;
        static string strChuoiKetNoi = @"Data Source=Desktop-713sjhm;Initial Catalog=QUANLIFASTFOOD;Integrated Security=True";
        
            
        //Load NhanVien
        public static DataTable LoadNhanVien() {
            
             con = new SqlConnection(strChuoiKetNoi);
            string strTruyVan = @"SELECT A.MA_NV,HOTEN_NV,NS_NV,GT_NV,DIACHI_NV,SDT_NV,NGAYVAOLAM,A.MA_CV FROM NHANVIEN A";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(strTruyVan, con);
            DataTable ds = new DataTable();

            da.Fill(ds);
            return ds;
        }
        //
        private List<ChucVu_DTO> LoadDepartmentaData()
        {
            //SqlCommand reader = new SqlCommand("SELECT * From CHUCVU", con);
            SqlDataReader reader = new SqlCommand("SELECT * From CHUCVU", con);
            List<ChucVu_DTO> list=new List<ChucVu_DTO>();
            con.Open();
            reader.ExecuteReader();
            while (reader.Read())
            {
                ChucVu_DTO cvDTO = new ChucVu_DTO();
                cvDTO.StrMaCV = reader.ToString();
                cvDTO.StrTenCV = reader.ToString();
            }
        }

        //Them Nhan Vien Moi & Login moi cho nhan vien do
        public static bool ThemNhanVien(NhanVien_DTO nvDTO)
        {
            try
            {
                
                
                //Them Nhan Vien vao tblNhanVien

                string strTruyVan1 = "INSERT INTO NHANVIEN(HOTEN_NV,NS_NV,GT_NV,SDT_NV,DIACHI_NV,NGAYVAOLAM,MA_CV)VALUES(@HOTEN_NV,@NS_NV,@GT_NV,@SDT_NV,@DIACHI_NV,@NGAYVAOLAM,@MA_CV)";
                con = new SqlConnection(strChuoiKetNoi);
                SqlCommand cmd = new SqlCommand(strTruyVan1,con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HOTEN_NV",nvDTO.StrHoTenNV);
                cmd.Parameters.AddWithValue("@NS_NV", nvDTO.StrNSNV);
                cmd.Parameters.AddWithValue("@GT_NV", nvDTO.StrGTNV);
                cmd.Parameters.AddWithValue("@SDT_NV", nvDTO.StrSDTNV);
                cmd.Parameters.AddWithValue("@DIACHI_NV", nvDTO.StrDiaChiNV);
                cmd.Parameters.AddWithValue("@NGAYVAOLAM", nvDTO.StrNgayLam);
                cmd.Parameters.AddWithValue("@MA_CV", nvDTO.StrMaCV);

                cmd.ExecuteNonQuery();
                ////Them user pass quyen vao tblLogin
                //string strTruyVan2 = string.Format("INSERT INTO LOGIN(MA_NV,USERNAME, PASS,QUYEN) VALUES ((SELECT MAX(MA_NV) FROM NHANVIEN),'{1}','{2}','{3}')",
                //    nvDTO.StrMaNV, nvDTO.StrUsername, nvDTO.StrPassword, nvDTO.StrQuyen);
                //con = DataProvider.MoKetNoi();
                //DataProvider.ThucThiTruyVanNonQuery(strTruyVan2, con);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally 
            {
                DataProvider.DongKetNoi(con);
            } 
        }
        //Xoa Nhan Vien & Login
        public static bool XoaNhanVien(NhanVien_DTO nvDTO)
        {
            try
            {   //Xoa Nhan Vien vao tblNhanVien
                string strTruyVan1 = string.Format(@"DELETE FROM NHANVIEN WHERE MA_NV='{0}'",nvDTO.StrMaNV);
                con = DataProvider.MoKetNoi();
                DataProvider.ThucThiTruyVanNonQuery(strTruyVan1, con);

                //Xoa user pass quyen vao tblLogin
                string strTruyVan2 = string.Format(@"DELETE FROM LOGIN WHERE MA_NV='{0}'", nvDTO.StrMaNV);
                con = DataProvider.MoKetNoi();
                DataProvider.ThucThiTruyVanNonQuery(strTruyVan2, con);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DataProvider.DongKetNoi(con);
            }
        }

    }
}
