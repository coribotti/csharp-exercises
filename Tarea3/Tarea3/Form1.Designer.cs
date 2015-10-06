namespace Tarea3
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
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnHisto = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTria1 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTria2 = new System.Windows.Forms.Button();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnEcu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(12, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(179, 194);
            this.txtShow.TabIndex = 0;
            // 
            // btnHisto
            // 
            this.btnHisto.Location = new System.Drawing.Point(197, 38);
            this.btnHisto.Name = "btnHisto";
            this.btnHisto.Size = new System.Drawing.Size(75, 23);
            this.btnHisto.TabIndex = 1;
            this.btnHisto.Text = "Histograma";
            this.btnHisto.UseVisualStyleBackColor = true;
            this.btnHisto.Click += new System.EventHandler(this.btnHisto_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(226, 12);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(46, 20);
            this.txtValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "n =";
            // 
            // btnTria1
            // 
            this.btnTria1.Location = new System.Drawing.Point(197, 67);
            this.btnTria1.Name = "btnTria1";
            this.btnTria1.Size = new System.Drawing.Size(75, 23);
            this.btnTria1.TabIndex = 4;
            this.btnTria1.Text = "Triángulo";
            this.btnTria1.UseVisualStyleBackColor = true;
            this.btnTria1.Click += new System.EventHandler(this.btnTria1_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(197, 96);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(75, 23);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Text = "Cuadro";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTria2
            // 
            this.btnTria2.Location = new System.Drawing.Point(197, 125);
            this.btnTria2.Name = "btnTria2";
            this.btnTria2.Size = new System.Drawing.Size(75, 23);
            this.btnTria2.TabIndex = 6;
            this.btnTria2.Text = "Triángulo 2";
            this.btnTria2.UseVisualStyleBackColor = true;
            this.btnTria2.Click += new System.EventHandler(this.btnTria2_Click);
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(197, 154);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(75, 23);
            this.btnSerie.TabIndex = 7;
            this.btnSerie.Text = "n Términos";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            // 
            // btnEcu
            // 
            this.btnEcu.Location = new System.Drawing.Point(197, 183);
            this.btnEcu.Name = "btnEcu";
            this.btnEcu.Size = new System.Drawing.Size(75, 23);
            this.btnEcu.TabIndex = 8;
            this.btnEcu.Text = "Ecuación";
            this.btnEcu.UseVisualStyleBackColor = true;
            this.btnEcu.Click += new System.EventHandler(this.btnEcu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btnEcu);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnTria2);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnTria1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnHisto);
            this.Controls.Add(this.txtShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnHisto;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTria1;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTria2;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btnEcu;
    }
}

