using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static DataTable LoadNhanVien(){
            return NhanVien_DAO.LoadNhanVien();
        }
        public static bool ThemNhanVien(NhanVien_DTO nvDTO) {
            return NhanVien_DAO.ThemNhanVien(nvDTO);
        }
        public static bool XoaNhanVien(NhanVien_DTO nvDTO){
            return NhanVien_DAO.XoaNhanVien(nvDTO);
        }
    }
}
