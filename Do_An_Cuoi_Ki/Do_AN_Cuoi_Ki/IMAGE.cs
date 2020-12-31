using Do_AN_Cuoi_Ki.DAO;
using Do_AN_Cuoi_Ki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZXing;
using QRCoder;
using System.Drawing;

namespace Do_AN_Cuoi_Ki
{
    public partial class IMAGE : Form
    {
        public IMAGE()
        {
            InitializeComponent();
            loadImageList();
            picQRcode.Image = Image.FromFile(dgvImage.Rows[0].Cells[0].Value.ToString());
        }

        private void loadImageList()
        {
            dgvImage.Rows.Clear();
            List<DTO.QRCode> listImage = QRCodeDAO.Instance.LoadQRCodeList();
            foreach (DTO.QRCode item in listImage)
            {
                dgvImage.Rows.Add(item.LinkQR);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Bitmap imgQRCode = (Bitmap)picQRcode.Image;
            if (imgQRCode != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imgQRCode);
                    string decoded = result.ToString().Trim();

                    //search data trong table INFORMATION 
                    Infomation info = InfomationDAO.Instance.SearchEmployee(decoded);
                    txtMSSV.Text = info.MSSV;
                    txtName.Text = info.HoTen;
                    txtxDateOfBirth.Text = info.NgaySinh;

                    //search data trong table IMAGE
                    ImageDTO img = ImageDAO.Instance.SearchEmployee(decoded);
                    picImage.Image = resizeImage(Image.FromFile(img.LinkImage01), 380, 232);
                    picIcon.Image = Image.FromFile(img.LinkImage02);

                    imgQRCode.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }

        private void dgvImage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvImage.Rows.Count < 0 || dgvImage.Rows.Count > e.RowIndex)
                return;
            if (dgvImage.Rows[e.RowIndex].Cells[0].Value != null)
                picQRcode.Image = Image.FromFile(dgvImage.Rows[e.RowIndex].Cells[0].Value.ToString());
           
        }

        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtxDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void IMAGE_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
