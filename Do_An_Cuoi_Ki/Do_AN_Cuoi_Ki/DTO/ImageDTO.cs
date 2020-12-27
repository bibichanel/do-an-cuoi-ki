using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DTO
{
    class ImageDTO
    {
        private string mSSV;
        private string linkImage01;
        private string linkImage02;
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string LinkImage01 { get => linkImage01; set => linkImage01 = value; }
        public string LinkImage02 { get => linkImage02; set => linkImage02 = value; }

        public ImageDTO(string MSSV, string LinkImage01, string LinkImage02)
        {
            this.MSSV = MSSV;
            this.LinkImage01 = LinkImage01;
            this.LinkImage02 = LinkImage02;

        }
        public ImageDTO() { }
        public ImageDTO(DataRow row)
        {
            this.MSSV = row["MSSV"].ToString();
            this.LinkImage01 = row["LINK_IMAGE_01"].ToString();
            this.LinkImage02 = row["LINK_IMAGE_02"].ToString();
        }
    }
}
