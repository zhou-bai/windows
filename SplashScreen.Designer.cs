namespace Bookshop
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelprogressBar = new System.Windows.Forms.Panel();
            this.timerprogressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Image = global::Bookshop.Properties.Resources.Splashbackground;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(700, 400);
            this.BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround.TabIndex = 0;
            this.BackGround.TabStop = false;
            this.BackGround.Click += new System.EventHandler(this.BackGround_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.panelprogressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 15);
            this.panel1.TabIndex = 1;
            // 
            // panelprogressBar
            // 
            this.panelprogressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
            this.panelprogressBar.Location = new System.Drawing.Point(0, 0);
            this.panelprogressBar.Name = "panelprogressBar";
            this.panelprogressBar.Size = new System.Drawing.Size(16, 15);
            this.panelprogressBar.TabIndex = 0;
            // 
            // timerprogressBar
            // 
            this.timerprogressBar.Enabled = true;
            this.timerprogressBar.Interval = 30;
            this.timerprogressBar.Tick += new System.EventHandler(this.timerprogressBar_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelprogressBar;
        private System.Windows.Forms.Timer timerprogressBar;
    }
}