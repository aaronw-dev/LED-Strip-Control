using System.Windows.Forms;
namespace LEDPeripheralControl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.snackbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // snackbarIcon
            // 
            this.snackbarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.snackbarIcon.BalloonTipText = "Test";
            this.snackbarIcon.BalloonTipTitle = "Hello";
            this.snackbarIcon.ContextMenuStrip = this.notifyIconMenu;
            this.snackbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("snackbarIcon.Icon")));
            this.snackbarIcon.Text = "LED Strip Control";
            this.snackbarIcon.Visible = true;
            this.snackbarIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openTrayIcon);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.brightnessBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lighting";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(113, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(50, 52);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeColor);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(94, 183);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(89, 23);
            this.apply.TabIndex = 4;
            this.apply.Text = "apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0%";
            // 
            // brightnessBar
            // 
            this.brightnessBar.LargeChange = 1;
            this.brightnessBar.Location = new System.Drawing.Point(3, 41);
            this.brightnessBar.Maximum = 255;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(268, 45);
            this.brightnessBar.SmallChange = 0;
            this.brightnessBar.TabIndex = 1;
            this.brightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightnessBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brightness";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(289, -3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(19, 21);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.label1_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.BtnHover);
            this.closeButton.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.helloToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitApp);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloToolStripMenuItem.Text = "Hello!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 234);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LED Strip Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon snackbarIcon;
        private GroupBox groupBox1;
        private Label closeButton;
        private Label label1;
        private TrackBar brightnessBar;
        private Label label3;
        private Label label2;
        private Button apply;
        private Button button1;
        private RichTextBox richTextBox1;
        private ContextMenuStrip notifyIconMenu;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helloToolStripMenuItem;
    }
}