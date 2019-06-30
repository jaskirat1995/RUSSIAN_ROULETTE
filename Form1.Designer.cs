namespace RUSSIAN_ROULETTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_Shootaway = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Load.Location = new System.Drawing.Point(177, 12);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(98, 43);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Spin.Location = new System.Drawing.Point(176, 87);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(98, 41);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = true;
            this.btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.Location = new System.Drawing.Point(178, 173);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(95, 39);
            this.btn_Shoot.TabIndex = 2;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = true;
            this.btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // btn_Shootaway
            // 
            this.btn_Shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shootaway.Location = new System.Drawing.Point(177, 257);
            this.btn_Shootaway.Name = "btn_Shootaway";
            this.btn_Shootaway.Size = new System.Drawing.Size(113, 37);
            this.btn_Shootaway.TabIndex = 3;
            this.btn_Shootaway.Text = "Shootaway";
            this.btn_Shootaway.UseVisualStyleBackColor = true;
            this.btn_Shootaway.Click += new System.EventHandler(this.Btn_Shootaway_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_playagain
            // 
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.Location = new System.Drawing.Point(373, 300);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(161, 38);
            this.btn_playagain.TabIndex = 5;
            this.btn_playagain.Text = "PLAY AGAIN";
            this.btn_playagain.UseVisualStyleBackColor = true;
            this.btn_playagain.Click += new System.EventHandler(this.Btn_playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Shootaway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_Shootaway;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_playagain;
    }
}

