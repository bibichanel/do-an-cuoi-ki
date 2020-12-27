using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DTO
{
    class Infomation
    {
        private string mSSV;
        private string hoTen;
        private string ngaySinh;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public Infomation() { }
        public Infomation(string MSSV, string HoTen, string NgaySinh)
        {
            this.MSSV = MSSV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
        }
        public Infomation(DataRow row)
        {
            this.MSSV = row["MSSV"].ToString();
            this.HoTen = row["HOTEN"].ToString();
            this.NgaySinh = row["NGAYSINH"].ToString();
        }
    }
}
