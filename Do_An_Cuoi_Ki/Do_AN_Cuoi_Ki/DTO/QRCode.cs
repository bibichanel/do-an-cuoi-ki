using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DTO
{
    class QRCode
    {
        private string mSSV;
        private string linkQR;
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string LinkQR { get => linkQR; set => linkQR = value; }

        public QRCode(string MSSV, string LinkQR)
        {
            this.MSSV = MSSV;
            this.LinkQR = LinkQR;

        }
        public QRCode(DataRow row)
        {
            this.MSSV = row["MSSV"].ToString();
            this.LinkQR = row["LINK_QR"].ToString();
        }
    }
}
