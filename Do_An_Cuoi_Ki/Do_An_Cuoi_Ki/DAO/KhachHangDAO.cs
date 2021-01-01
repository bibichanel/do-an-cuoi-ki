using Do_An_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Cuoi_Ki.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAO();
                return KhachHangDAO.instance;
            }
            private set => instance = value;
        }
        private KhachHangDAO() { }

        public List<KhachHang> LoadCustomerList()
        {
            List<KhachHang> KhachHangList = new List<KhachHang>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM KHACHHANG");
            foreach (DataRow item in data.Rows)
            {
                KhachHang datakh = new KhachHang(item);
                KhachHangList.Add(datakh);
            }
            return KhachHangList;
        }
        public int GetMaxIdCustomer()
        {
            int idmax = 0;
            List<KhachHang> khachHangList = KhachHangDAO.instance.LoadCustomerList();
            foreach (KhachHang item in khachHangList)
            {
                int id = int.Parse(item.MaKH.Substring(2));
                if (id > idmax)
                    idmax = id;
            }
            return idmax;
        }
        //public bool InsertCustomer(string MaKH, string TenKH, string DiaChiKH, string DienThoaiKH)
        //{
        //    string query = string.Format("INSERT dbo.KHACH VALUES ( '{0}', N'{1}', N'{2}', '{3}')",
        //                                                        MaKH, TenKH, DiaChiKH, DienThoaiKH);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool UpdateCustomer(string MaKH, string TenKH, string DiaChiKH, string DienThoaiKH)
        //{
        //    string query = string.Format("UPDATE dbo.KHACH SET TenKhach = N'{0}', DiaChi = N'{1}', DienThoai = '{2}' WHERE MaKhach = '{3}'",
        //                                  TenKH, DiaChiKH, DienThoaiKH, MaKH);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool DeleteCustomer(string idCustommer)
        //{
        //    //Xóa Chi tiết hóa đơn liên quan tới khách hàng.
        //    HoaDon billOfCustomer = HoaDonDAO.Instance.SearchHoaDonWithIdCustomer(idCustommer);
        //    ChiTietHoaDonDAO.Instance.DeleteBillDetailWithIdBill(billOfCustomer.MaHD);

        //    //Xóa hóa đơn liên quan tới khách hàng.
        //    HoaDonDAO.Instance.DeleteBillWithIdBill(billOfCustomer.MaHD);

        //    //Xóa Nhân Viên.
        //    string query = string.Format("DELETE FROM KHACH WHERE MaKhach = '{0}'", idCustommer);
        //    int resultDeleteCustomer = DataProvider.Instance.ExecuteNonQuery(query);

        //    return resultDeleteCustomer > 0;
        //}
        public KhachHang SearchCustomer(string idKhachHang)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = idKhachHang;
            List<KhachHang> khachHangList = KhachHangDAO.Instance.LoadCustomerList();
            foreach (KhachHang item in khachHangList)
            {
                if (khachHang.MaKH == item.MaKH)
                {
                    khachHang.TenKH = item.TenKH;
                    khachHang.DiaChiKH = item.DiaChiKH;
                    khachHang.SoDienThoaiKH = item.SoDienThoaiKH;
                }
            }
            return khachHang;
        }
    }
}
