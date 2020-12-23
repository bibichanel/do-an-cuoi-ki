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
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Do_AN_Cuoi_Ki.DAO;

namespace Do_AN_Cuoi_Ki
{
    public partial class Form1 : Form
    {
        //-----------Biến---------------
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool faceDetectionEnable = false;

        CascadeClassifier faceCascade = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLables = new List<int>();
        bool EnableSaveImage = false;
        List<string> PersonsNames = new List<string>();
        //---------------------

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // Bước 1: bắt hình ảnh.
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);
                //------------------

                //Bước 2: Nhận diện khuôn mặt.
                if (faceDetectionEnable)
                {
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCascade.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                    // Nếu face đã được detect 
                    if (faces.Length > 0)
                    {
                        // vẽ rectangle xung quanh mặt.
                        foreach (var face in faces)
                        {
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                            //Bước 3: Add Person
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDetect.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDetect.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                string path01 = @"D:\Git_Lab\Do_AN_Cuoi_Ki\Do_AN_Cuoi_Ki\ImageAll\";
                                string path02 = @"D:\Git_Lab\Do_AN_Cuoi_Ki\Do_AN_Cuoi_Ki\ImageIcon\";
                                if (!Directory.Exists(path01))
                                    Directory.CreateDirectory(path01);
                                if (!Directory.Exists(path02))
                                    Directory.CreateDirectory(path02);

                                picCapture.Image.Save(path01 + @"\" + txtMSSV.Text + "_02" + ".jpg"); 
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path02 + @"\" + txtMSSV.Text + "_01"  + ".jpg");

                                string date = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                                bool result1 = InfomationDAO.Instance.InsertInfomationPerson(txtMSSV.Text, txtNamePerson.Text, date);
                                bool result2 = ImageDAO.Instance.InsertInformation(txtMSSV.Text, 
                                    path01 + @"\" + txtMSSV.Text + "_02" + ".jpg", path02 + @"\" + txtMSSV.Text + "_01" + ".jpg");
                                bool result3 = 
                            }

                            EnableSaveImage = false;
                            if (btnAddPerson.InvokeRequired)
                            {
                                btnAddPerson.Invoke(new ThreadStart(delegate { btnAddPerson.Enabled = true; }));
                            }
                            //------------------

                        }
                    }
                }
                //------------------

                //Dán ảnh lên picture box.
                picCapture.Image = currentFrame.Bitmap;
                //------------------
            }
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            faceDetectionEnable = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
           //btnSave.Enabled = true;
            btnAddPerson.Enabled = false;
            EnableSaveImage = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAddPerson.Enabled = false;
            btnAddPerson.Enabled = true;
            EnableSaveImage = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
