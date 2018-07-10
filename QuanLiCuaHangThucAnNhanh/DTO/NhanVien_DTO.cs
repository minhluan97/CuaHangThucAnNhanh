using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string strMaNV;

        public string StrMaNV
        {
            get { return strMaNV; }
            set { strMaNV = value; }
        }

        private string strHoTenNV;

        public string StrHoTenNV
        {
            get { return strHoTenNV; }
            set { strHoTenNV = value; }
        }
        private string strGTNV;

        public string StrGTNV
        {
            get { return strGTNV; }
            set { strGTNV = value; }
        }

        
        private DateTime strNSNV;

        public DateTime StrNSNV
        {
            get { return strNSNV; }
            set { strNSNV = value; }
        }

        private string strSDTNV;

        public string StrSDTNV
        {
            get { return strSDTNV; }
            set { strSDTNV = value; }
        }
        private string strDiaChiNV;

        public string StrDiaChiNV
        {
            get { return strDiaChiNV; }
            set { strDiaChiNV = value; }
        }
       
        private DateTime strNgayLam;

        public DateTime StrNgayLam
        {
            get { return strNgayLam; }
            set { strNgayLam = value; }
        }


        private string strMaCV;

        public string StrMaCV
        {
            get { return strMaCV; }
            set { strMaCV = value; }
        }

        //public NhanVien_DTO(string a1,string a2,string a3,string a4,string a5,string a6,DateTime b1,DateTime b2)
        //{
        //    StrDiaChiNV=a1;
        //    StrGTNV = a2;
        //    StrHoTenNV = a3;
        //    StrMaCV = a4;
        //    StrMaNV = a5;
        //    StrNgayLam = b1;
        //    StrNSNV = b2;
        //    StrSDTNV = a6;

        //}
    
    }
}
