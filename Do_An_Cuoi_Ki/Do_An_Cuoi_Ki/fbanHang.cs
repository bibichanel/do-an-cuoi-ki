using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

using BarcodeLib;

using ZXing;

namespace Do_An_Cuoi_Ki
{
    public partial class fbanHang : Form
    {
        #region variable

        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();

        #endregion
       

        public fbanHang()
        {
            InitializeComponent();
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // chuyển đổi sang quét mã barcode
            if(panelChoose.Visible == true)
            {
                panelChoose.Visible = false;
                panelScan.Visible = true;
                picBarCode.Visible = true;
                btnSwitch.Text = "Chuyển đổi sang chọn thủ công";

                if (videoCapture != null) videoCapture.Dispose();
                    videoCapture = new Capture();
                Application.Idle += ProcessFrame;
            }
            else // chuyển đổi sang chọn thủ công
            {
                panelChoose.Visible = true;
                panelScan.Visible = false;
                picBarCode.Visible = false;

                btnSwitch.Text = "Chuyển đổi sang quét mã BarCode";
                videoCapture.Dispose();
            }    
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>();

                picBarCode.Image = currentFrame.Bitmap;
            }

            if (currentFrame != null)
                currentFrame.Dispose();
        }

            private string LoadBarcode()
        {
            Bitmap imgBarCode = (Bitmap)picBarCode.Image;
            if (imgBarCode != null)
            {

                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(imgBarCode);
                string decoded = result.ToString().Trim();

                imgBarCode.Dispose();
                return decoded;
            }
            else
                return null;
        }
        
        

    }
}
