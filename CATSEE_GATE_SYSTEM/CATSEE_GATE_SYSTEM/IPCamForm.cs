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
    public partial class IPCamForm : Form
    {

        bool needClose = false;
        bool CameraOpened = false;

        int cameraHandle = 0;

        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);

        public IPCamForm()
        {
            InitializeComponent();
        }

        private void IPCamForm_Load(object sender, EventArgs e)
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("iTBMsfqfYezuLhQckrpYsFWhLuU/IehgWDK1JEvsJZ8gwOAp2irjJjcrV+vxabe6bu3GhLnDee6bPaSSR5ZFsOQ40nZau7ckLloDXob1WllsVra58JMxVlydqpf7Qia/phVnWeGHxTejJkgwJIzNWmGDgzmwDIgEIDl0rNSrzyo="))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
        }

        private void IPCamForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
