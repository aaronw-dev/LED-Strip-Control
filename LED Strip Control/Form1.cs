using System;
using System.IO;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace LEDPeripheralControl
{
    public partial class MainForm : Form
    {
        #region Window Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Window Detection
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hwnd, StringBuilder ss, int count);
        private string ActiveWindowTitle()
        {
            //Create the variable
            const int nChar = 256;
            StringBuilder ss = new StringBuilder(nChar);

            //Run GetForeGroundWindows and get active window informations
            //assign them into handle pointer variable
            IntPtr handle = IntPtr.Zero;
            handle = GetForegroundWindow();

            if (GetWindowText(handle, ss, nChar) > 0) return ss.ToString();
            else return "";
        }
        private void Tmr_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        SerialPort port = new SerialPort("COM6", 9600);

        Color curColor;

        public MainForm()
        {
            InitializeComponent();
            port.Open();
            curColor = Color.White;
            
            Timer tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += Tmr_Tick;
            tmr.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the NotifyIcon.
            this.snackbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
        }

        private void openTrayIcon(object sender, MouseEventArgs e)
        {
            snackbarIcon.Visible = false;
            Show();
            Activate();
            
        }
        private void quitApp(object sender, EventArgs e)
        {
            setColor(Color.Black);
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            snackbarIcon.Visible = true;
            Hide();
        }

        public void BtnHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }
        public void BtnLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Firebrick;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            setColor(curColor);
        }

        private void setColor(Color color)
        {
            float r = color.R;
            float g = color.G;
            float b = color.B;


            float brightness = (float)brightnessBar.Value / 255;
            r *= brightness;
            g *= brightness;
            b *= brightness;
            port.Write("RD" + r + ",GN" + g + ",BE" + b + ",");
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = dialog.Color;
                curColor = dialog.Color;
            }
        }
    }
}