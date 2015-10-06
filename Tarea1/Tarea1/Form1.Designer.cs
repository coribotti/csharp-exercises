namespace Tarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tx4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx5 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(38, 22);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(40, 20);
            this.tx1.TabIndex = 1;
            this.tx1.Text = "0";
            this.tx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx1.Click += new System.EventHandler(this.tx1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b=";
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(127, 22);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(45, 20);
            this.tx2.TabIndex = 3;
            this.tx2.Text = "0";
            this.tx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx2.Click += new System.EventHandler(this.tx2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "c=";
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(217, 22);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(42, 20);
            this.tx3.TabIndex = 5;
            this.tx3.Text = "0";
            this.tx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx3.Click += new System.EventHandler(this.tx3_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(104, 93);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "x1=";
            // 
            // tx4
            // 
            this.tx4.BackColor = System.Drawing.SystemColors.Control;
            this.tx4.Location = new System.Drawing.Point(63, 160);
            this.tx4.Name = "tx4";
            this.tx4.ReadOnly = true;
            this.tx4.Size = new System.Drawing.Size(57, 20);
            this.tx4.TabIndex = 8;
            this.tx4.Text = "0";
            this.tx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "x2=";
            // 
            // tx5
            // 
            this.tx5.BackColor = System.Drawing.SystemColors.Control;
            this.tx5.Location = new System.Drawing.Point(184, 160);
            this.tx5.Name = "tx5";
            this.tx5.ReadOnly = true;
            this.tx5.Size = new System.Drawing.Size(60, 20);
            this.tx5.TabIndex = 10;
            this.tx5.Text = "0";
            this.tx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(197, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "Siguiente";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tx5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.label1);
            this.Name = "window1";
            this.Text = "Fórmula General";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx5;
        private System.Windows.Forms.Button btn1;
    }
}

