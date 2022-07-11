namespace Hospital_Management_System
{
    partial class FormSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.circularProgressBarLoading = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circularProgressBarLoading
            // 
            this.circularProgressBarLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarLoading.AnimationSpeed = 500;
            this.circularProgressBarLoading.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarLoading.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarLoading.ForeColor = System.Drawing.Color.White;
            this.circularProgressBarLoading.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBarLoading.InnerMargin = 2;
            this.circularProgressBarLoading.InnerWidth = -1;
            this.circularProgressBarLoading.Location = new System.Drawing.Point(200, 300);
            this.circularProgressBarLoading.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarLoading.Name = "circularProgressBarLoading";
            this.circularProgressBarLoading.OuterColor = System.Drawing.Color.White;
            this.circularProgressBarLoading.OuterMargin = -25;
            this.circularProgressBarLoading.OuterWidth = 26;
            this.circularProgressBarLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.circularProgressBarLoading.ProgressWidth = 25;
            this.circularProgressBarLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarLoading.Size = new System.Drawing.Size(200, 200);
            this.circularProgressBarLoading.StartAngle = 270;
            this.circularProgressBarLoading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarLoading.SubscriptText = "";
            this.circularProgressBarLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarLoading.SuperscriptText = "";
            this.circularProgressBarLoading.TabIndex = 0;
            this.circularProgressBarLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarLoading.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.circularProgressBarLoading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            this.Load += new System.EventHandler(this.FormSplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBarLoading;
        private System.Windows.Forms.Timer timer1;
    }
}