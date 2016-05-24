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
    public partial class EnterModeForm : Form
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

        public EnterModeForm()
        {
            InitializeComponent();
        }

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

        private void EnterModeForm_Load(object sender, EventArgs e)
        {
            txb_cardnum.Focus();

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
            //this.Width = formatList[VideoFormat].Width + 50;
            //this.Height = formatList[VideoFormat].Height + 96;

            //this.panel1.Height = formatList[VideoFormat].Height + 96 + 230;
        }

       




        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);



        private void EnterModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
        }

        //캠활성화 버튼 클릭
        private void FaceDetection(object sender, EventArgs e)
        {
            int motion_check = 0;


            //cmb_cam.Items.AddRange(cameraList);
            cameraName = cmb_cam.SelectedItem.ToString();
            //this.btn_start.Enabled = false;
            int cameraHandle = 0;

            int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            int tracker = 0; 	// creating a Tracker

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
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected 얼굴여부 체크
                Array.Resize(ref IDs, (int)faceCount);

                // make UI controls accessible (to find if the user clicked on a face)
                Application.DoEvents();

                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);


                //모션 없음
                if (faceCount == 0)
                {
                    motion_check++;
                    //모션 있음
                }
                else
                {
                    motion_check = 0;
                }
                if (motion_check > 1000)
                {
                    System.Windows.Forms.MessageBox.Show("방범모드");
                    motion_check = 0;
                }


                for (int i = 0; i < IDs.Length; ++i)
                {
                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);
                    int w = (int)(facePosition.w * 1.2);

                    String name;
                    int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

                    //데이터와 얼굴 영상이 일치하는 경우
                    if (FSDK.FSDKE_OK == res && name.Length > 0)
                    { // draw name
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;

                        gr.DrawString("이름:" + name, new System.Drawing.Font("Arial", 16),
                            new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                            facePosition.xc, top + w + 5, format);
                    }

                    //데이터와 얼굴 영상이 일치하지 않는 경우
                    else
                    {

                    }

                    FSDK.UnlockID(tracker, IDs[i]);
                    Pen pen = Pens.LightGreen;

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
        }




        private void button1_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = txb_cardnum.Text + "#";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txb_cardnum.Text = "";
        }

        

    }
}
