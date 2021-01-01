using Do_An_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Cuoi_Ki.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        internal static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return SanPhamDAO.instance;
            }
            private set => instance = value;
        }
        private SanPhamDAO() { }
        public List<SanPham> LoadProductList()
        {
            List<SanPham> SanPhamList = new List<SanPham>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM SANPHAM");
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                SanPhamList.Add(sanPham);
            }
            return SanPhamList;
        }
        public int GetMaxIdProduct()
        {
            int idMax = 0;
            List<SanPham> SanPhamList = SanPhamDAO.instance.LoadProductList();
            foreach (SanPham item in SanPhamList)
            {
                int id = int.Parse(item.MaSP.Substring(2));
                if (id > idMax)
                    idMax = id;
            }
            return idMax;
        }
        public bool InsertYogurt(string MaSP, string TenSP, string DVT, string NuocSX, float DonGiaSP, string LinkSP)
        {
            string query = string.Format("INSERT dbo.SANPHAM VALUES ( '{0}', N'{1}', N'{2}', N'{3}', {4}, '{5}')",
                                                                MaSP, TenSP, DVT, NuocSX, DonGiaSP, LinkSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //public bool UpdateYogurtstring MaSP, string TenSP, string DVT, string NuocSX, float DonGiaSP, string LinkSP)
        //{
        //    string query = string.Format("UPDATE dbo.HANG SET TenHang = N'{0}', DonGiaBan = {1}, Anh = '{2}', GhiChu = N'{3}' WHERE MaHang = '{4}'",
        //                                    TenSC, DonGia, LinkImagie, GhiChu, MaSC);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}

        public SanPham SearchProduct(string idProduct)
        {
            SanPham sp = new SanPham();
            sp.MaSP = idProduct;
            List<SanPham> spList = SanPhamDAO.Instance.LoadProductList();
            foreach (SanPham item in spList)
            {
                if (item.MaSP == sp.MaSP)
                {
                    sp.TenSP = item.TenSP;
                    sp.DVT = item.DVT;
                    sp.NuocSX = item.NuocSX;
                    sp.DonGiaSP = item.DonGiaSP;
                    sp.LinkSP = item.LinkSP;
                }
            }
            return sp;
        }
        public SanPham SearchProductWithName(string nameProduct)
        {
            SanPham sp = new SanPham();
            sp.TenSP = nameProduct;
            List<SanPham> productList = SanPhamDAO.Instance.LoadProductList();
            foreach (SanPham item in productList)
            {
                if (item.TenSP == sp.TenSP)
                {
                    sp.MaSP = item.MaSP;
                    sp.DVT = item.DVT;
                    sp.NuocSX = item.NuocSX;
                    sp.DonGiaSP = item.DonGiaSP;
                    sp.LinkSP = item.LinkSP;
                }
            }
            return sp;
        }
    }
}
