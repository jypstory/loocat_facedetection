using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Luxand;
using System.IO;
using System.Threading;

namespace CATSEE_GATE_SYSTEM
{
    public partial class IPCamForm_new : Form
    {
        bool needClose = false;
        bool CameraOpened = false;

        int cameraHandle = 0;

        String connStrLocal = "";
        String connStrRemote = "";
        String runMode = "";
        String dataRootDir = "";            //데이터 저장 루트 위치
        String activeKey = "";
        public String visitorDataDir = "";  //
        public String visit_id = "";        //방문자 ID(사번)
        String TrackerMemoryFile = ""; 

        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);


        public IPCamForm_new()
        {
            InitializeComponent();
        }

        private void IPCamForm_new_Load(object sender, EventArgs e)
        {
            Config conf = new Config();
            connStrLocal = conf.getConnStrLocal();
            connStrRemote = conf.getConnStrRemote();
            runMode = conf.getRunMode();
            dataRootDir = conf.getDataRootDir();
            activeKey = conf.getActiveKey();
            TrackerMemoryFile = conf.getTrackerMemoryFile();

            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary(activeKey))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
        }

        private void IPCamForm_new_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CameraOpened && FSDK.FSDKE_OK != FSDKCam.CloseVideoCamera(cameraHandle))
            {
                MessageBox.Show("Error closing camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (FSDK.FSDKE_OK != FSDKCam.OpenIPVideoCamera(FSDKCam.FSDK_VIDEOCOMPRESSIONTYPE.FSDK_MJPEG, AddressBox.Text, UsernameBox.Text, PasswordBox.Text, 50, ref cameraHandle))
            {
                MessageBox.Show("Error opening IP camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            CameraOpened = true;
            Thread thread1 = new Thread(new ThreadStart(doThreadFaceDetection));
            CheckForIllegalCrossThreadCalls = false;  //thread 에러 때문에 임시로 추가함
            thread1.Start();
        }


        //private void IPCamForm_new_Shown(object sender, EventArgs e)
        private void doThreadFaceDetection()
        {
            int tracker = 0;
            FSDK.CreateTracker(ref tracker);

            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "RecognizeFaces=false; HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);
            
            while (!needClose)
            {
                if (CameraOpened)
                {
                    Int32 imageHandle = 0;
                    if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                    {
                        MessageBox.Show("Error in FSDK_GrabFrame", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.DoEvents();
                        continue;
                    }
                    FSDK.CImage image = new FSDK.CImage(imageHandle);

                    long[] IDs;
                    long faceCount = 0;
                    FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                    Array.Resize(ref IDs, (int)faceCount);

                    Image frameImage = image.ToCLRImage();
                    Graphics gr = Graphics.FromImage(frameImage);

                    for (int i = 0; i < IDs.Length; ++i)
                    {
                        FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                        FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                        int left = facePosition.xc - (int)(facePosition.w * 0.6);
                        int top = facePosition.yc - (int)(facePosition.w * 0.5);
                        gr.DrawRectangle(Pens.LightGreen, left, top, (int)(facePosition.w * 1.2), (int)(facePosition.w * 1.2));
                    }

                    // display current frame
                    pictureBox1.Image = frameImage;
                }
                GC.Collect(); // collect the garbage after the deletion

                // make UI controls accessible
                Application.DoEvents();
            }

            if (CameraOpened)
                FSDKCam.CloseVideoCamera(cameraHandle);
        }
    }
}
