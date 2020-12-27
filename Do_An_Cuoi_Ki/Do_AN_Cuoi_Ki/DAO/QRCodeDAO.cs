using Do_AN_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DAO
{
    class QRCodeDAO
    {
        private static QRCodeDAO instance;

        internal static QRCodeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QRCodeDAO();
                return QRCodeDAO.instance;
            }
            private set => instance = value;
        }
        private QRCodeDAO() { }
        public List<QRCode> LoadQRCodeList()
        {
            List<QRCode> QRCodeList = new List<QRCode>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM QRCODE");
            foreach (DataRow item in data.Rows)
            {
                QRCode QRCODE01 = new QRCode(item);
                QRCodeList.Add(QRCODE01);
            }
            return QRCodeList;
        }
        public bool InsertQRCode(string MSSV, string LinkQR, string LinkImage02)
        {
            string query = string.Format("INSERT dbo.QRCODE VALUES ( '{0}', '{1}', '{2}')",
                                                                MSSV, LinkQR, LinkImage02);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
