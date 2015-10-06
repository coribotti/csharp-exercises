namespace Clase_01_02_2013
{
    partial class mayor
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
            this.num3 = new System.Windows.Forms.TextBox();
            this.resu = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(141, 52);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(37, 20);
            this.num3.TabIndex = 0;
            this.num3.Text = "0";
            this.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resu
            // 
            this.resu.Location = new System.Drawing.Point(12, 136);
            this.resu.Name = "resu";
            this.resu.Size = new System.Drawing.Size(100, 20);
            this.resu.TabIndex = 1;
            this.resu.Text = "0";
            this.resu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(78, 52);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(37, 20);
            this.num2.TabIndex = 2;
            this.num2.Text = "0";
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 52);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(36, 20);
            this.num1.TabIndex = 3;
            this.num1.Text = "0";
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 94);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "¡Soy el mayor! >:C";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // mayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.resu);
            this.Controls.Add(this.num3);
            this.Name = "mayor";
            this.Text = "Numero mayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox resu;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button btn1;
    }
}