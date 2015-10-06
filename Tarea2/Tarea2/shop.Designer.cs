namespace Tarea2
{
    partial class shop
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
            this.txPrice = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txCharge = new System.Windows.Forms.TextBox();
            this.txPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txRet = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Su pago: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Su cambio: $";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(116, 20);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(62, 20);
            this.txPrice.TabIndex = 4;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(184, 32);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(57, 23);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Calcular";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txCharge
            // 
            this.txCharge.Location = new System.Drawing.Point(116, 57);
            this.txCharge.Name = "txCharge";
            this.txCharge.ReadOnly = true;
            this.txCharge.Size = new System.Drawing.Size(62, 20);
            this.txCharge.TabIndex = 6;
            // 
            // txPay
            // 
            this.txPay.Location = new System.Drawing.Point(116, 117);
            this.txPay.Name = "txPay";
            this.txPay.Size = new System.Drawing.Size(62, 20);
            this.txPay.TabIndex = 7;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(184, 136);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(57, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txRet
            // 
            this.txRet.Location = new System.Drawing.Point(116, 158);
            this.txRet.Name = "txRet";
            this.txRet.ReadOnly = true;
            this.txRet.Size = new System.Drawing.Size(62, 20);
            this.txRet.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(241, 162);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(323, 197);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txRet);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txPay);
            this.Controls.Add(this.txCharge);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "shop";
            this.Text = "Tiendas de Silvermoon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txCharge;
        private System.Windows.Forms.TextBox txPay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txRet;
        private System.Windows.Forms.Button btnNext;
    }
}