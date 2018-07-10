using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class ChucVu_BUS
    {
        public static DataTable LoadChucVu()
        {
            return ChucVu_DAO.LoadChucVu();
        }
    }
}
