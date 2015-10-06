namespace Clase_01_02_2013
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
            this.Btnpuls = new System.Windows.Forms.Button();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnpuls
            // 
            this.Btnpuls.Location = new System.Drawing.Point(12, 79);
            this.Btnpuls.Name = "Btnpuls";
            this.Btnpuls.Size = new System.Drawing.Size(75, 23);
            this.Btnpuls.TabIndex = 0;
            this.Btnpuls.Text = "Sumar";
            this.Btnpuls.UseVisualStyleBackColor = true;
            this.Btnpuls.Click += new System.EventHandler(this.Btnpuls_Click);
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(12, 27);
            this.Numero1.Name = "Numero1";
            this.Numero1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Numero1.Size = new System.Drawing.Size(75, 20);
            this.Numero1.TabIndex = 1;
            this.Numero1.Text = "0";
            this.Numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Numero1.TextChanged += new System.EventHandler(this.Numero1_TextChanged);
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(12, 53);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(75, 20);
            this.Numero2.TabIndex = 2;
            this.Numero2.Text = "0";
            this.Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(12, 117);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(162, 79);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Otra ventana";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 158);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.Btnpuls);
            this.Name = "Form1";
            this.Text = "SumaSimple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnpuls;
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button btn;
    }
}

