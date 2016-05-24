using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Luxand;
using System.IO;


namespace CATSEE_GATE_SYSTEM
{
    public partial class VisitorVideoCapture : Form
    {
        // program states: whether we recognize faces, or user has clicked a face
        enum ProgramState { psRemember, psRecognize }
        ProgramState programState = ProgramState.psRecognize;

        string connStrLocal = "";
        string connStrRemote = "";
        string runMode = "";
        string dataRootDir = "";               //데이터 저장 루트 위치
        string activeKey = "";
        public string visitorDataDir = "";     //
        public string visit_name = "";         //출입자 이름

        String cameraName;
        bool needClose = false;
        String TrackerMemoryFile = "";  //실제 얼굴 인식 관련 데이터 파일
        int mouseX = 0;
        int mouseY = 0;
        int tracker = 0; 	// creating a Tracker
        string[] cameraList;

        public String visitorImgFileName = "";
        //public String visitorCameraFileName = "";
        
        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);

        private void setConfig()
        {
            Config conf = new Config();
            connStrLocal = conf.getConnStrLocal();
            connStrRemote = conf.getConnStrRemote();
            runMode = conf.getRunMode();
            dataRootDir = conf.getDataRootDir();
            activeKey = conf.getActiveKey();
            TrackerMemoryFile = conf.getTrackerMemoryFile();
        }

        public VisitorVideoCapture()
        {
            InitializeComponent();
        }

        private void VisitorVideoCapture_Load(object sender, EventArgs e)
        {
            setConfig();

            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary(activeKey))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
            FSDKCam.InitializeCapturing();

            int count;
            FSDKCam.GetCameraList(out cameraList, out count);

            if (0 == count)
            {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            
            cmb_cam.Items.AddRange(cameraList);
            cmb_cam.SelectedIndex = 0;
            cameraName = cameraList[0];

            FSDKCam.VideoFormatInfo[] formatList;
            FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out count);

            int VideoFormat = 0; // choose a video format
            pictureBox1.Width = formatList[VideoFormat].Width;
            pictureBox1.Height = formatList[VideoFormat].Height;
            this.Width = formatList[VideoFormat].Width + 50;
            this.Height = formatList[VideoFormat].Height + 96;

            this.panel1.Height = formatList[VideoFormat].Height + 96 + 230;
        }

        private void VisitorVideoCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
        }

        //캠활성화 버튼 클릭
        private void FaceDetection(object sender, EventArgs e)
        {
            //this.btn_start.Enabled = false;
            int cameraHandle = 0;

            //cmb_cam.Items.AddRange(cameraList);
            cameraName = cmb_cam.SelectedItem.ToString();

            int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, dataRootDir + "\\" + TrackerMemoryFile)) // try to load saved tracker state
                FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker

            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);


            while (!needClose)
            {
                Int32 imageHandle = 0;
                if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                {
                    Application.DoEvents();
                    continue;
                }
                FSDK.CImage image = new FSDK.CImage(imageHandle);

                long[] IDs;
                long faceCount = 0;
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                Array.Resize(ref IDs, (int)faceCount);

                // make UI controls accessible (to find if the user clicked on a face)
                Application.DoEvents();

                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);

                for (int i = 0; i < IDs.Length; ++i)
                {
                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);
                    int w = (int)(facePosition.w * 1.2);

                    String name;
                    int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

                    if (FSDK.FSDKE_OK == res && name.Length > 0)
                    { // draw name
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;

                        gr.DrawString(name, new System.Drawing.Font("Arial", 16),
                            new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                            facePosition.xc, top + w + 5, format);

                    }

                    Pen pen = Pens.LightGreen;
                    if (mouseX >= left && mouseX <= left + w && mouseY >= top && mouseY <= top + w)
                    {
                        pen = Pens.Blue;
                        if (ProgramState.psRemember == programState)
                        {
                            if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
                            {
                                if (true)
                                {
                                    if (visit_name == null)
                                    {
                                    
                                    }
                                    else
                                    {
                                        FSDK.SetName(tracker, IDs[i], visit_name);  //tracker에 이름 저장

                                        visitorDataDir = dataRootDir;
                                        //(ex. C:\myWorkspace\catsee\data)

                                        //디렉토리 생성
                                        if (Directory.Exists(visitorDataDir) == false)
                                            Directory.CreateDirectory(visitorDataDir);
                                        //디렉토리 생성 끝

                                        visitorImgFileName = visit_name + "_" + tracker + "_" + IDs[i] + ".jpg";
                                        FSDK.SaveImageToFileW(image.ImageHandle, visitorDataDir + "\\" + visitorImgFileName); //사진파일 저장
                                    }
                                    FSDK.UnlockID(tracker, IDs[i]);
                                }
                            }
                        }
                    }
                    gr.DrawRectangle(pen, left, top, w, w);
                }
                programState = ProgramState.psRecognize;

                // display current frame
                pictureBox1.Image = frameImage;
                GC.Collect(); // collect the garbage after the deletion
            }
            FSDK.FreeTracker(tracker);
            FSDKCam.CloseVideoCamera(cameraHandle);
            FSDKCam.FinalizeCapturing();
            //this.btn_start.Enabled = true;
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            programState = ProgramState.psRemember;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseX = 0;
            mouseY = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            FSDK.SaveTrackerMemoryToFile(tracker, dataRootDir + "\\" + TrackerMemoryFile);
            FSDKCam.FinalizeCapturing();
            this.Close();
            //
        }
    }
}
