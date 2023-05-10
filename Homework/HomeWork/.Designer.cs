namespace HomeWork
{
    partial class Frm08_ScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm08_ScreenSaver));
            this.timer_ScreenSaver = new System.Windows.Forms.Timer(this.components);
            this.PBScreenSaver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBScreenSaver)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_ScreenSaver
            // 
            this.timer_ScreenSaver.Interval = 50;
            this.timer_ScreenSaver.Tick += new System.EventHandler(this.timer_ScreenSaver_Tick);
            // 
            // PBScreenSaver
            // 
            this.PBScreenSaver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBScreenSaver.BackgroundImage")));
            this.PBScreenSaver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBScreenSaver.Location = new System.Drawing.Point(1, -1);
            this.PBScreenSaver.Name = "PBScreenSaver";
            this.PBScreenSaver.Size = new System.Drawing.Size(183, 128);
            this.PBScreenSaver.TabIndex = 0;
            this.PBScreenSaver.TabStop = false;
            // 
            // Frm_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PBScreenSaver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_ScreenSaver";
            this.Text = "ScreenSaverForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ScreenSaver_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_ScreenSaver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PBScreenSaver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_ScreenSaver;
        private System.Windows.Forms.PictureBox PBScreenSaver;
    }
}