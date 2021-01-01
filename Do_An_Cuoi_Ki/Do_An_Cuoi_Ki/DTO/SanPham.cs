using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Cuoi_Ki.DTO
{
    class SanPham
    {
        private string maSP;
        private string tenSP;
        private string dVT;
        private string nuocSX;
        private float donGiaSP;
        private string linkSP;
        public string NuocSX { get => nuocSX; set => nuocSX = value; }
        public float DonGiaSP { get => donGiaSP; set => donGiaSP = value; }
        public string LinkSP { get => linkSP; set => linkSP = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DVT { get => dVT; set => dVT = value; }

        public SanPham() { }
        public SanPham(string MaSP, string TenSP, string DVT, string NuocSX, float DonGiaSP, string LinkSP )
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DVT = DVT;
            this.NuocSX = NuocSX;
            this.DonGiaSP = DonGiaSP;
            this.LinkSP = LinkSP;
        }
        public SanPham(DataRow row)
        {
            this.MaSP = row["MASP"].ToString();
            this.TenSP = row["TENSP"].ToString();
            this.DVT = row["DVT"].ToString();
            this.NuocSX = row["NUOCSX"].ToString();
            this.DonGiaSP = (float)row["GIA"];
            this.LinkSP = row["LINK_ANH"].ToString();
        }
    }
}
