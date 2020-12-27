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
using QRCoder;
using ZXing;

namespace Do_AN_Cuoi_Ki
{
    public partial class Form1 : Form
    {
        #region variables
        ////Camera 
        private Capture videoCapture = null; 
        Mat frame = new Mat();

        //Images for finding face
        private Image<Bgr, Byte> currentFrame = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLables = new List<int>();
        List<string> PersonsNames = new List<string>();

        CascadeClassifier faceCascade = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        EigenFaceRecognizer recognizer;

        private bool faceDetectionEnable = false;
        bool EnableSaveImage = true;
        private bool isTrained = false;

        #endregion

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

                            //Dán khuôn mặt lên picture nhỏ.
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDetect.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDetect.Image = resultImage.Bitmap;

                            //Step 3: Add Person 
                            if (EnableSaveImage)
                            {
                                //Kiểm tra đường dẫn có tồn tại hay ko
                                string path = @"D:\Git_Lab\Do_An_Cuoi_Ki\Do_AN_Cuoi_Ki\AddPerson\";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                //Lưu 10 tấm ảnh để so sánh khi train
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + txtNamePerson.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (btnAddPerson.InvokeRequired)
                            {
                                btnAddPerson.Invoke(new ThreadStart(delegate { btnAddPerson.Enabled = true; }));
                            }
                            //------------------
                            // Step 5: Train the face 
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                //Trả về khuôn mặt đã được tìm thấy.
                                if (result.Label != -1 && result.Distance < 2500)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                //Trả về khuôn mặt không được tìm thấy.
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
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
            if (txtNamePerson.Text == "" || txtMSSV.Text == "")
            {
                MessageBox.Show("Text Box Name Person or MSSV is empty.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            string path01 = @"D:\Git_Lab\Do_AN_Cuoi_Ki\Do_AN_Cuoi_Ki\ImageAll\";
            string path02 = @"D:\Git_Lab\Do_AN_Cuoi_Ki\Do_AN_Cuoi_Ki\ImageIcon\";
            string path03 = @"D:\Git_Lab\Do_AN_Cuoi_Ki\Do_AN_Cuoi_Ki\QRcodeImage\";
            if (!Directory.Exists(path01))
                Directory.CreateDirectory(path01);
            if (!Directory.Exists(path02))
                Directory.CreateDirectory(path02);
            if (!Directory.Exists(path03))
                Directory.CreateDirectory(path03);
            {
               // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                picCapture.Image.Save(path01 + txtMSSV.Text + "_01" + ".jpg");
            }
            picDetect.Image.Save(path02 + txtMSSV.Text + "_02" + ".jpg");
            picQRCode.Image.Save(path03 + txtMSSV.Text + "_03" + ".jpg");

            string date = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");

            bool result1 = InfomationDAO.Instance.InsertInfomationPerson(txtMSSV.Text, txtNamePerson.Text, date);
            bool result2 = ImageDAO.Instance.InsertImage(txtMSSV.Text,
                path01 + txtMSSV.Text + "_01" + ".jpg", 
                path02 + txtMSSV.Text + "_02" + ".jpg");
            bool result3 = QRCodeDAO.Instance.InsertQRCode(txtMSSV.Text, 
                path03 + txtMSSV.Text + "_03" + ".jpg",
                path02 + txtMSSV.Text + "_02" + ".jpg");
            if (result1 == true && result2 == true && result3 == true)
                MessageBox.Show("Add complete.", "Anounce", MessageBoxButtons.OK);
            else
                MessageBox.Show("Error.", "Anounce", MessageBoxButtons.OK);
            btnAddPerson.Enabled = false;
            EnableSaveImage = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Image displayQrCode()
        {
            if (txtMSSV.Text == "") return null;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData codeData = qrGenerator.CreateQrCode(txtMSSV.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode QRCode = new QRCode(codeData); 
            Image qrcode = QRCode.GetGraphic(7, Color.Black, Color.White, false);
            return qrcode;
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            picQRCode.Image =  displayQrCode();
        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2500;
            TrainedFaces.Clear();
            PersonsLables.Clear();
            PersonsNames.Clear();
            try
            {;
                string path = @"D:\Git_Lab\Do_An_Cuoi_Ki\Do_AN_Cuoi_Ki\AddPerson\";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLables.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLables.ToArray());

                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        private void listViewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMAGE form1 = new IMAGE();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }
    }
}
