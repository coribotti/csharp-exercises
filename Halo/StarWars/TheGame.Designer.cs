namespace StarWars
{
    partial class TheGame
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
            this.labAlienName = new System.Windows.Forms.Label();
            this.labHumanName = new System.Windows.Forms.Label();
            this.labAliens = new System.Windows.Forms.Label();
            this.labHumans = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbAliens = new System.Windows.Forms.GroupBox();
            this.txtAlien = new System.Windows.Forms.TextBox();
            this.gbHumans = new System.Windows.Forms.GroupBox();
            this.txtHuman = new System.Windows.Forms.TextBox();
            this.PBAliens = new System.Windows.Forms.ProgressBar();
            this.PBHumans = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbAliens.SuspendLayout();
            this.gbHumans.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAlienName
            // 
            this.labAlienName.AutoSize = true;
            this.labAlienName.Location = new System.Drawing.Point(12, 9);
            this.labAlienName.Name = "labAlienName";
            this.labAlienName.Size = new System.Drawing.Size(67, 13);
            this.labAlienName.TabIndex = 0;
            this.labAlienName.Text = "NombreAlien";
            this.labAlienName.Visible = false;
            // 
            // labHumanName
            // 
            this.labHumanName.AutoSize = true;
            this.labHumanName.Location = new System.Drawing.Point(414, 9);
            this.labHumanName.Name = "labHumanName";
            this.labHumanName.Size = new System.Drawing.Size(84, 13);
            this.labHumanName.TabIndex = 1;
            this.labHumanName.Text = "NombreHumano";
            this.labHumanName.Visible = false;
            // 
            // labAliens
            // 
            this.labAliens.AutoSize = true;
            this.labAliens.Location = new System.Drawing.Point(77, 28);
            this.labAliens.Name = "labAliens";
            this.labAliens.Size = new System.Drawing.Size(28, 13);
            this.labAliens.TabIndex = 2;
            this.labAliens.Text = "HP: ";
            this.labAliens.Visible = false;
            // 
            // labHumans
            // 
            this.labHumans.AutoSize = true;
            this.labHumans.Location = new System.Drawing.Point(243, 28);
            this.labHumans.Name = "labHumans";
            this.labHumans.Size = new System.Drawing.Size(28, 13);
            this.labHumans.TabIndex = 3;
            this.labHumans.Text = "HP: ";
            this.labHumans.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Halo.Properties.Resources.url;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Halo.Properties.Resources.halo01;
            this.pictureBox2.Location = new System.Drawing.Point(410, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // gbAliens
            // 
            this.gbAliens.Controls.Add(this.txtAlien);
            this.gbAliens.Location = new System.Drawing.Point(12, 80);
            this.gbAliens.Name = "gbAliens";
            this.gbAliens.Size = new System.Drawing.Size(167, 165);
            this.gbAliens.TabIndex = 6;
            this.gbAliens.TabStop = false;
            this.gbAliens.Text = "Log:";
            this.gbAliens.Visible = false;
            // 
            // txtAlien
            // 
            this.txtAlien.Location = new System.Drawing.Point(6, 16);
            this.txtAlien.Multiline = true;
            this.txtAlien.Name = "txtAlien";
            this.txtAlien.ReadOnly = true;
            this.txtAlien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlien.Size = new System.Drawing.Size(155, 143);
            this.txtAlien.TabIndex = 10;
            // 
            // gbHumans
            // 
            this.gbHumans.Controls.Add(this.txtHuman);
            this.gbHumans.Location = new System.Drawing.Point(291, 80);
            this.gbHumans.Name = "gbHumans";
            this.gbHumans.Size = new System.Drawing.Size(175, 165);
            this.gbHumans.TabIndex = 7;
            this.gbHumans.TabStop = false;
            this.gbHumans.Text = "Log:";
            this.gbHumans.Visible = false;
            // 
            // txtHuman
            // 
            this.txtHuman.Location = new System.Drawing.Point(6, 16);
            this.txtHuman.Multiline = true;
            this.txtHuman.Name = "txtHuman";
            this.txtHuman.ReadOnly = true;
            this.txtHuman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHuman.Size = new System.Drawing.Size(163, 143);
            this.txtHuman.TabIndex = 0;
            // 
            // PBAliens
            // 
            this.PBAliens.Location = new System.Drawing.Point(77, 44);
            this.PBAliens.MarqueeAnimationSpeed = 500;
            this.PBAliens.Name = "PBAliens";
            this.PBAliens.Size = new System.Drawing.Size(158, 30);
            this.PBAliens.TabIndex = 8;
            this.PBAliens.Visible = false;
            // 
            // PBHumans
            // 
            this.PBHumans.Location = new System.Drawing.Point(246, 44);
            this.PBHumans.MarqueeAnimationSpeed = 500;
            this.PBHumans.Name = "PBHumans";
            this.PBHumans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PBHumans.RightToLeftLayout = true;
            this.PBHumans.Size = new System.Drawing.Size(158, 30);
            this.PBHumans.TabIndex = 9;
            this.PBHumans.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(185, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "¡Empezar!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.txtStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 257);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.PBHumans);
            this.Controls.Add(this.PBAliens);
            this.Controls.Add(this.gbHumans);
            this.Controls.Add(this.gbAliens);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labHumans);
            this.Controls.Add(this.labAliens);
            this.Controls.Add(this.labHumanName);
            this.Controls.Add(this.labAlienName);
            this.Name = "TheGame";
            this.Text = "Aliens OP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbAliens.ResumeLayout(false);
            this.gbAliens.PerformLayout();
            this.gbHumans.ResumeLayout(false);
            this.gbHumans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAlienName;
        private System.Windows.Forms.Label labHumanName;
        private System.Windows.Forms.Label labAliens;
        private System.Windows.Forms.Label labHumans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbAliens;
        private System.Windows.Forms.TextBox txtAlien;
        private System.Windows.Forms.GroupBox gbHumans;
        private System.Windows.Forms.TextBox txtHuman;
        private System.Windows.Forms.ProgressBar PBAliens;
        private System.Windows.Forms.ProgressBar PBHumans;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;

    }
}

