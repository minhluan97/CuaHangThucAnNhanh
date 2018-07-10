using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LoadChucVu() {
            return ChucVu_DAO.LoadChucVu();
        }
    }
}
