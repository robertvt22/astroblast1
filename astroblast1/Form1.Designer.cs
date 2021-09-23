namespace astroblast1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1UFO = new System.Windows.Forms.PictureBox();
            this.pictureBox1Asteroid = new System.Windows.Forms.PictureBox();
            this.timerAsteroid = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1UFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Asteroid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1UFO
            // 
            this.pictureBox1UFO.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1UFO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1UFO.BackgroundImage")));
            this.pictureBox1UFO.Image = global::astroblast1.Properties.Resources.ufo;
            this.pictureBox1UFO.Location = new System.Drawing.Point(513, 621);
            this.pictureBox1UFO.Name = "pictureBox1UFO";
            this.pictureBox1UFO.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1UFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1UFO.TabIndex = 0;
            this.pictureBox1UFO.TabStop = false;
            // 
            // pictureBox1Asteroid
            // 
            this.pictureBox1Asteroid.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Asteroid.BackgroundImage = global::astroblast1.Properties.Resources.meteorit;
            this.pictureBox1Asteroid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1Asteroid.Location = new System.Drawing.Point(970, 30);
            this.pictureBox1Asteroid.Name = "pictureBox1Asteroid";
            this.pictureBox1Asteroid.Size = new System.Drawing.Size(113, 94);
            this.pictureBox1Asteroid.TabIndex = 1;
            this.pictureBox1Asteroid.TabStop = false;
            // 
            // timerAsteroid
            // 
            this.timerAsteroid.Enabled = true;
            this.timerAsteroid.Interval = 20;
            this.timerAsteroid.Tick += new System.EventHandler(this.timerAsteroid_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::astroblast1.Properties.Resources.planet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1140, 672);
            this.Controls.Add(this.pictureBox1Asteroid);
            this.Controls.Add(this.pictureBox1UFO);
            this.Name = "Form1";
            this.Text = "astroblast";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1UFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Asteroid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1UFO;
        private System.Windows.Forms.PictureBox pictureBox1Asteroid;
        private System.Windows.Forms.Timer timerAsteroid;
    }
}

