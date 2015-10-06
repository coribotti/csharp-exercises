namespace Tarea2
{
    partial class payments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cat1 = new System.Windows.Forms.RadioButton();
            this.cat2 = new System.Windows.Forms.RadioButton();
            this.cat3 = new System.Windows.Forms.RadioButton();
            this.cat4 = new System.Windows.Forms.RadioButton();
            this.cat5 = new System.Windows.Forms.RadioButton();
            this.btnTot = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su sueldo: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas extras trabajadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorías:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(72, 12);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(58, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // cat1
            // 
            this.cat1.AutoSize = true;
            this.cat1.Location = new System.Drawing.Point(12, 105);
            this.cat1.Name = "cat1";
            this.cat1.Size = new System.Drawing.Size(31, 17);
            this.cat1.TabIndex = 5;
            this.cat1.TabStop = true;
            this.cat1.Text = "1";
            this.cat1.UseVisualStyleBackColor = true;
            // 
            // cat2
            // 
            this.cat2.AutoSize = true;
            this.cat2.Location = new System.Drawing.Point(12, 128);
            this.cat2.Name = "cat2";
            this.cat2.Size = new System.Drawing.Size(31, 17);
            this.cat2.TabIndex = 6;
            this.cat2.TabStop = true;
            this.cat2.Text = "2";
            this.cat2.UseVisualStyleBackColor = true;
            // 
            // cat3
            // 
            this.cat3.AutoSize = true;
            this.cat3.Location = new System.Drawing.Point(12, 151);
            this.cat3.Name = "cat3";
            this.cat3.Size = new System.Drawing.Size(31, 17);
            this.cat3.TabIndex = 7;
            this.cat3.TabStop = true;
            this.cat3.Text = "3";
            this.cat3.UseVisualStyleBackColor = true;
            // 
            // cat4
            // 
            this.cat4.AutoSize = true;
            this.cat4.Location = new System.Drawing.Point(12, 174);
            this.cat4.Name = "cat4";
            this.cat4.Size = new System.Drawing.Size(31, 17);
            this.cat4.TabIndex = 8;
            this.cat4.TabStop = true;
            this.cat4.Text = "4";
            this.cat4.UseVisualStyleBackColor = true;
            // 
            // cat5
            // 
            this.cat5.AutoSize = true;
            this.cat5.Location = new System.Drawing.Point(12, 197);
            this.cat5.Name = "cat5";
            this.cat5.Size = new System.Drawing.Size(71, 17);
            this.cat5.TabIndex = 9;
            this.cat5.TabStop = true;
            this.cat5.Text = "5 o mayor";
            this.cat5.UseVisualStyleBackColor = true;
            // 
            // btnTot
            // 
            this.btnTot.Location = new System.Drawing.Point(136, 171);
            this.btnTot.Name = "btnTot";
            this.btnTot.Size = new System.Drawing.Size(70, 23);
            this.btnTot.TabIndex = 10;
            this.btnTot.Text = "¡Págame!";
            this.btnTot.UseVisualStyleBackColor = true;
            this.btnTot.Click += new System.EventHandler(this.btnTot_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(136, 45);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(36, 20);
            this.txtExtra.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(150, 205);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 237);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.btnTot);
            this.Controls.Add(this.cat5);
            this.Controls.Add(this.cat4);
            this.Controls.Add(this.cat3);
            this.Controls.Add(this.cat2);
            this.Controls.Add(this.cat1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "payments";
            this.Text = "Pagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.RadioButton cat1;
        private System.Windows.Forms.RadioButton cat2;
        private System.Windows.Forms.RadioButton cat3;
        private System.Windows.Forms.RadioButton cat4;
        private System.Windows.Forms.RadioButton cat5;
        private System.Windows.Forms.Button btnTot;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.TextBox txtTotal;
    }
}