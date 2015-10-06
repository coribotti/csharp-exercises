namespace Notify
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
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.Notif = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tmr
            // 
            this.Tmr.Enabled = true;
            this.Tmr.Interval = 200;
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Notif
            // 
            this.Notif.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notif.BalloonTipText = "Se cumplió el tiempo.";
            this.Notif.BalloonTipTitle = "Aviso.";
            this.Notif.Icon = ((System.Drawing.Icon)(resources.GetObject("Notif.Icon")));
            this.Notif.Text = "notifyIcon1";
            this.Notif.Visible = true;
            // 
            // btnPress
            // 
            this.btnPress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPress.Location = new System.Drawing.Point(98, 119);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(82, 23);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "¡Presióname!";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.NotifyIcon Notif;
        private System.Windows.Forms.Button btnPress;
    }
}

