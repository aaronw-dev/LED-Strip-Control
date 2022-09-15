using System;
using System.IO;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;

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

        SerialPort port = new SerialPort("COM6", 9600);

        Color curColor;

        public MainForm()
        {
            InitializeComponent();
            port.Open();
            curColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
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
            float r = curColor.R;
            float g = curColor.G;
            float b = curColor.B;


            float brightness = (float)brightnessBar.Value / 255;
            r *= brightness;
            g *= brightness;
            b *= brightness;

            Console.WriteLine("RD" + r + ",GN" + g + ",BE" + b + ",");
            port.Write("RD" + r + ",GN" + g + ",BE" + b + ",");
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                curColor = dialog.Color;
            }
        }
    }
}