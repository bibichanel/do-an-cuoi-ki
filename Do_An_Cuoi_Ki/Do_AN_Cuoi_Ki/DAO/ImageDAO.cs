using Do_AN_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_AN_Cuoi_Ki.DAO
{
    class ImageDAO
    {
        private static ImageDAO instance;

        internal static ImageDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageDAO();
                return ImageDAO.instance;
            }
            private set => instance = value;
        }
        private ImageDAO() { }
        public List<ImageDTO> LoadImageList()
        {
            List<ImageDTO> ImageList = new List<ImageDTO>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM _IMAGE");
            foreach (DataRow item in data.Rows)
            {
                ImageDTO Image01 = new ImageDTO(item);
                ImageList.Add(Image01);
            }
            return ImageList;
        }
        public bool InsertImage(string MSSV, string Path01, string Path02)
        {
            string query = string.Format("INSERT dbo._IMAGE VALUES ( '{0}', '{1}', '{2}')",
                                                                MSSV, Path01, Path02);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public ImageDTO SearchEmployee(string MSSV)
        {
            ImageDTO Img = new ImageDTO();
            Img.MSSV = MSSV;
            List<ImageDTO> ImageList = ImageDAO.Instance.LoadImageList();
            foreach (ImageDTO item in ImageList)
            {
                if (Img.MSSV == item.MSSV)
                {
                    Img.LinkImage01 = item.LinkImage01;
                    Img.LinkImage02 = item.LinkImage02;
                }
            }
            return Img;
        }
    }
}
