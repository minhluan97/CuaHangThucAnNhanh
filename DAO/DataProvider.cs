using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
namespace DAO
{
    public class DataProvider
    {

        //Open connection
        public static SqlConnection MoKetNoi()
        {
            string strChuoiKetNoi = @"Data Source=Desktop-713sjhm;Initial Catalog=QUANLIFASTFOOD;Integrated Security=True";
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
            con.Open();
            return con;
        }
        //Close connection
        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }
        //lay DataTable
        public static DataTable LayDataTable(string sTruyVan, SqlConnection con)
        {
            SqlDataAdapter sqlDA = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }
        public static bool ThucThiTruyVanNonQuery(string sTruyVan, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sTruyVan, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
