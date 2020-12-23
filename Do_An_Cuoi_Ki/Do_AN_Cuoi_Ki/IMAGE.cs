using Do_AN_Cuoi_Ki.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_AN_Cuoi_Ki.DTO;

namespace Do_AN_Cuoi_Ki
{
    public partial class IMAGE : Form
    {
        public IMAGE()
        {
            InitializeComponent();
            loadImageList();
        }

        private void loadImageList()
        {
            dgvImage.Rows.Clear();
            List<ImageDTO> listImage = ImageDAO.Instance.LoadImageList();
            foreach (ImageDTO item in listImage)
            {
                dgvImage.Rows.Add(item.MSSV, item.LinkImage01, item.LinkImage02);
            }
        }

    }
}
