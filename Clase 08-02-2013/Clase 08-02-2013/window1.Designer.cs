namespace Clase_08_02_2013
{
    partial class window1
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCyc = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnFact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(31, 71);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(117, 123);
            this.txtData.TabIndex = 0;
            // 
            // btnCyc
            // 
            this.btnCyc.Location = new System.Drawing.Point(12, 42);
            this.btnCyc.Name = "btnCyc";
            this.btnCyc.Size = new System.Drawing.Size(81, 23);
            this.btnCyc.TabIndex = 1;
            this.btnCyc.Text = "Tabla del 12";
            this.btnCyc.UseVisualStyleBackColor = true;
            this.btnCyc.Click += new System.EventHandler(this.btnCyc_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(73, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(36, 20);
            this.txtNum.TabIndex = 2;
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(99, 42);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(75, 23);
            this.btnFact.TabIndex = 3;
            this.btnFact.Text = "Factorial";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 206);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCyc);
            this.Controls.Add(this.txtData);
            this.Name = "window1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.window1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCyc;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnFact;
    }
}

