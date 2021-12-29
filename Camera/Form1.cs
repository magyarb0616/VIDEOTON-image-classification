using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using CameraML.Model;



namespace Camera
{

	public partial class Form1 : Form
    {

        private string getOrderName(int n)
		{
            switch (n)
			{
                case 0: return "NNN";
                case 1: return "NNP";
                case 2: return "NPN";
                case 3: return "NPP";
                case 4: return "PNN";
                case 5: return "PNP";
                case 6: return "PPN";
                case 7: return "PPP";
                default: return "Wrong data";
            }
		}
        

		private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;
        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Directory.GetCurrentDirectory()+@"\sample\";   //Application.StartupPath + @"\ImageCapture\";
        public string celldataPath = @"C:\Users\bence\Desktop\MachineLearning\celldata\";
        public Bitmap seged;
        private Stopwatch stopWatch = null;
        private static bool needSnapshot = false;

        public Form1()
        {
            InitializeComponent();
            getListCameraUSB();
            gbValidationPanel.Enabled = false;
            chart.Titles.Add("Distribution");
            pbInstagrid.Visible = true;
            pbVideoton.Visible = true;
        }

        private static string _usbcamera;
        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }

        private void Satart_button_Click(object sender, EventArgs e)
        {
            OpenCamera();
        }

        

        private void OpenCamera()
        {
            try
            {
                usbcamera = CameraList_comboBox.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in videoDevices)
                    {
                        listCamera.Add(device.Name);

                    }
                }
                else
                {
                    MessageBox.Show("Camera devices found");
                }

                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                if (snapshotCapabilities.Length == 0)
                {
                    //MessageBox.Show("Camera Capture Not supported");
                }

                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //Delegate Untuk Capture, insert database, update ke grid 
        public delegate void CaptureSnapshotManifast(Bitmap image);
        public void UpdateCaptureSnapshotManifast(Bitmap image)
        {
            try
            {
                needSnapshot = false;
                Capture_pictureBox.Image = image;
                Capture_pictureBox.Update();


                string nameImage = "sampleImage";
                string nameCapture = nameImage + ".jpg";    // "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";

                if (Directory.Exists(pathFolder))
                {
                    Capture_pictureBox.Image.Save(pathFolder + nameCapture, ImageFormat.Jpeg);
                }
                else
                {
                    Directory.CreateDirectory(pathFolder);
                    Capture_pictureBox.Image.Save(pathFolder + nameCapture, ImageFormat.Jpeg);
                }


                var input = new ModelInput()
                {
                    ImageSource = Directory.GetCurrentDirectory() + @"\sample\sampleImage.jpg"
                };
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("Tipp: " + result.Prediction);
                Result_Label.Text = "Prediction: " + result.Prediction;
                chart.Series["s1"].Points.Clear();
                for (int i = 0; i < 4; i++){
                    chart.Series["s1"].Points.AddXY(getOrderName(i) +" "+ String.Format("{0:00.00}", (result.Score[i] * 100)) + "%", (result.Score[i] * 100));
                    chart.Series["s1"].Points.AddXY(getOrderName(i + 4) + " " + String.Format("{0:00.00}", (result.Score[i+4] * 100)) + "%", (result.Score[i+4] * 100));
                }
                chart.Series["s1"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending);
            }

            catch(Exception ex) { Console.WriteLine(ex.Message); }

        }

        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;

                // stop current video source
                CloseCurrentVideoSource();

                // start new video source
                videoSourcePlayer1.VideoSource = source;
                videoSourcePlayer1.Start();

                // reset stop watch
                stopWatch = null;


                this.Cursor = Cursors.Default;
            }
            catch { }
        }

        private void getListCameraUSB()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    CameraList_comboBox.Items.Add(device.Name);
                }
            }else
            {
                CameraList_comboBox.Items.Add("No DirectShow devices found");
            }

            CameraList_comboBox.SelectedIndex = 0;

        }

        public void CloseCurrentVideoSource()
        {
            try
            {

                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();

                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }

                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }

                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }

        private void Snapshot_button_Click(object sender, EventArgs e)
        {
            needSnapshot = true;
            Snapshot_button.Enabled = false;
            gbValidationPanel.Enabled = true;
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);

                // paint current time
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
                brush.Dispose();
                if (needSnapshot)
                {
                    seged = image;
                    this.Invoke(new CaptureSnapshotManifast(UpdateCaptureSnapshotManifast), image);
                }
                g.Dispose();
            }
            catch
            { }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnNNN_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"nnn\" + "NNN_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnNNP_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"nnp\" + "NNP_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnNPN_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"npn\" + "NPN_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnNPP_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"npp\" + "NPP_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnPPP_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"ppp\" + "PPP_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnPNN_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"pnn\" + "PNN_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnPNP_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"pnp\" + "PNP_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnPPN_Click(object sender, EventArgs e)
		{
            System.IO.File.Move(pathFolder + "sampleImage.jpg", celldataPath + @"ppn\" + "PPN_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg");
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		private void btnCorrect_Click(object sender, EventArgs e)
		{
            Snapshot_button.Enabled = true;
            gbValidationPanel.Enabled = false;
        }

		
	}
}
