using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Cuoi_Ki.DTO
{
    class HoaDon
    {
        private string maHD;
        private string maNV;
        private string ngayBan;
        private string maKhach;
        private string tongTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
        public string MaKhach { get => maKhach; set => maKhach = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public HoaDon() { }
        public HoaDon(string MaHD, string NgayBan, string MaKhach,  string MaNV, string TongTien)
        {
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            this.NgayBan = NgayBan;
            this.MaKhach = MaKhach;
            this.TongTien = TongTien;
        }
        public HoaDon(DataRow row)
        {
            this.MaHD = row["SOHD"].ToString();
            this.NgayBan = row["NGHD"].ToString();
            this.MaKhach = row["MAKH"].ToString();
            this.MaNV = row["MANV"].ToString();
            this.TongTien = row["TRIGIA"].ToString();
        }
    }
}
