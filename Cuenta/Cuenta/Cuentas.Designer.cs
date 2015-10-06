namespace Cuenta
{
    partial class Cuentas
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnDepo = new System.Windows.Forms.Button();
            this.labCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.labSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué desea hacer?";
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsulta.Location = new System.Drawing.Point(12, 39);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 38);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consulta de saldo";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            this.btnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetiro.Location = new System.Drawing.Point(93, 39);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 38);
            this.btnRetiro.TabIndex = 2;
            this.btnRetiro.Text = "Retiro de efectivo";
            this.btnRetiro.UseVisualStyleBackColor = true;
            // 
            // btnDepo
            // 
            this.btnDepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepo.Location = new System.Drawing.Point(174, 39);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(75, 38);
            this.btnDepo.TabIndex = 3;
            this.btnDepo.Text = "Depósito";
            this.btnDepo.UseVisualStyleBackColor = true;
            // 
            // labCant
            // 
            this.labCant.AutoSize = true;
            this.labCant.Location = new System.Drawing.Point(9, 130);
            this.labCant.Name = "labCant";
            this.labCant.Size = new System.Drawing.Size(61, 13);
            this.labCant.TabIndex = 4;
            this.labCant.Text = "Cantidad: $";
            this.labCant.Visible = false;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(67, 127);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(55, 20);
            this.txtCant.TabIndex = 5;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCant.Visible = false;
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            // 
            // labSaldo
            // 
            this.labSaldo.AutoSize = true;
            this.labSaldo.Location = new System.Drawing.Point(12, 158);
            this.labSaldo.Name = "labSaldo";
            this.labSaldo.Size = new System.Drawing.Size(80, 13);
            this.labSaldo.TabIndex = 6;
            this.labSaldo.Text = "Su saldo es de:";
            this.labSaldo.Visible = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(98, 155);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(80, 20);
            this.txtSaldo.TabIndex = 7;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(12, 83);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(237, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Crear una nueva cuenta";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(204, 148);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(51, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(128, 125);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(50, 23);
            this.btnCrea.TabIndex = 10;
            this.btnCrea.Text = "Crear";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Visible = false;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(267, 187);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.labSaldo);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.labCant);
            this.Controls.Add(this.btnDepo);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.Name = "Cuentas";
            this.Text = "Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnDepo;
        private System.Windows.Forms.Label labCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label labSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCrea;
    }
}

