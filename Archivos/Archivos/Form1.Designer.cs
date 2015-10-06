namespace Archivos
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txRead = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnReadBinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(105, 23);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 37);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Leer Texto";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txRead
            // 
            this.txRead.Location = new System.Drawing.Point(12, 72);
            this.txRead.Multiline = true;
            this.txRead.Name = "txRead";
            this.txRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txRead.Size = new System.Drawing.Size(254, 96);
            this.txRead.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReadBinary
            // 
            this.btnReadBinary.Location = new System.Drawing.Point(191, 23);
            this.btnReadBinary.Name = "btnReadBinary";
            this.btnReadBinary.Size = new System.Drawing.Size(75, 37);
            this.btnReadBinary.TabIndex = 3;
            this.btnReadBinary.Text = "Leer Binario";
            this.btnReadBinary.UseVisualStyleBackColor = true;
            this.btnReadBinary.Click += new System.EventHandler(this.btnReadBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 180);
            this.Controls.Add(this.btnReadBinary);
            this.Controls.Add(this.txRead);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnReadBinary;
    }
}

