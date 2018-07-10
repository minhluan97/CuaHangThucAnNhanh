using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> LoadChucVu() {
            string strTruyVan = "SELECT * FROM CHUCVU";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(strTruyVan,con);
            if (dt.Rows.Count == 0)
            { return null; }
            List<ChucVu_DTO> listcv = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.StrMaCV = dt.Rows[i]["MA_CV"].ToString();
                cv.StrTenCV = dt.Rows[i]["TEN_CV"].ToString();
                listcv.Add(cv);
            }
            DataProvider.DongKetNoi(con);
            return listcv;
        }
    }
}
